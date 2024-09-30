using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;

namespace SmartCitities.Admin.Controllers
{
    public class PartenersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PartenersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var parteners = await _unitOfWork.GetRepository<Partener>().GetAllAsync();
            return View(parteners);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partener = await _unitOfWork.GetRepository<Partener>().GetByIdAsync(id);
            if (partener == null)
            {
                return NotFound();
            }

            return View(partener);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LogoUrl,Email,PhoneNumber,Address,CreateAt,UpdateAt,CreateBy,UpdateBy")] Partener partener)
        {
            if (ModelState.IsValid)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                partener.CreateBy = userId;
                partener.CreateAt = DateTime.UtcNow;
                await _unitOfWork.GetRepository<Partener>().AddAsync(partener);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partener);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partener = await _unitOfWork.GetRepository<Partener>().GetByIdAsync(id);
            if (partener == null)
            {
                return NotFound();
            }
            return View(partener);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,LogoUrl,Email,PhoneNumber,Address,CreateAt,UpdateAt,CreateBy,UpdateBy")] Partener partener)
        {
            if (id != partener.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    partener.UpdateBy = userId;
                    partener.UpdateAt = DateTime.UtcNow;
                    _unitOfWork.GetRepository<Partener>().Update(partener);
                    await _unitOfWork.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartenerExists(partener.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(partener);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partener = await _unitOfWork.GetRepository<Partener>().GetByIdAsync(id);
            if (partener == null)
            {
                return NotFound();
            }

            return View(partener);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var partener = await _unitOfWork.GetRepository<Partener>().GetByIdAsync(id);
            if (partener != null)
            {
                _unitOfWork.GetRepository<Partener>().Delete(partener);
                await _unitOfWork.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool PartenerExists(string id)
        {
            return _unitOfWork.GetRepository<Partener>().FindAsync(p => p.Id == id).Result != null;
        }
    }

}
