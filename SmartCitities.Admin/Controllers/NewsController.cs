using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;
using SmartCitities.Admin.ViewModels;

namespace SmartCitities.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class NewsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NewsController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var news = await _unitOfWork.GetRepository<New>().FindAllAsync(new[] { "User"} );
            return View(news);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _unitOfWork.GetRepository<New>().GetByIdAsync(id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewVM vm)
        {

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            New @new=new New();
            @new.Title = vm.Title;
            @new.Description = vm.Description;

            if (vm.Picture != null)
            {
                string folder = "Images/";
                string imageUrl = await UploadImage(folder, vm.Picture);
                @new.ImageUrl = imageUrl;
              

            }
            if (vm.video != null)
            {
                string folder = "Images/";
                string videourl = await UploadImage(folder, vm.video);
                @new.LinkUrl = videourl;


            }

                @new.CreateBy = userId;
          
                @new.UpdateBy = userId;
                @new.CreateAt = DateTime.UtcNow;
                await _unitOfWork.GetRepository<New>().AddAsync(@new);
                await _unitOfWork.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @new = await _unitOfWork.GetRepository<New>().GetByIdAsync(id);
            if (@new == null)
            {
                return NotFound();
            }
            var vm = new NewVM {
            Title= @new.Title,
            Description= @new.Description,
            ImageUrl= @new.ImageUrl,
            VideoUrl=@new.ImageUrl


            
            };
      
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, NewVM vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            New @new = _unitOfWork.GetRepository<New>().GetById(id);

            try
            {
                @new.UpdateBy = userId;
                @new.Title = vm.Title;
                @new.Description = vm.Description;
                if (vm.Picture != null)
                {
                    string folder = "Images/";
                    string imageUrl = await UploadImage(folder, vm.Picture);
                    @new.ImageUrl = imageUrl;


                }
                else
                {


                    @new.ImageUrl = "Images/default.jpg";


                }
                if (vm.video != null)
                {
                    string folder = "Images/";
                    string videourl = await UploadImage(folder, vm.video);
                    @new.LinkUrl = videourl;


                }
                else
                {


                    @new.LinkUrl = "Images/default.jpg";


                }

                _unitOfWork.GetRepository<New>().Update(@new);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewExists(@new.Id).Result)
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

  




    public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @new = await _unitOfWork.GetRepository<New>().GetByIdAsync(id);
            if (@new == null)
            {
                return NotFound();
            }

            return View(@new);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var @new = await _unitOfWork.GetRepository<New>().GetByIdAsync(id);
            if (@new != null)
            {
                _unitOfWork.GetRepository<New>().Delete(@new);
            }

            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> NewExists(string id)
        {
            return await _unitOfWork.GetRepository<New>().FindAsync(n => n.Id == id) != null;
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }
    }


}

