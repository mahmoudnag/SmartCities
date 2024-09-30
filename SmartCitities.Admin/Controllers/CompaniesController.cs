using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    public class CompaniesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CompaniesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _unitOfWork.GetRepository<Company>().GetAllAsync();
            return View(companies);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _unitOfWork.GetRepository<Company>().GetByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CompanyVM vm)
        {
            
             string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
             var company = new Company();
            company.PhoneNumber = vm.PhoneNumber;
            company.Name = vm.Name;
            company.vision= vm.vision;
            company.Email = vm.Email;
            company.Address = vm.Address;
            company.AboutUs= vm.AboutUs;
            company.Mission= vm.Mission;
            company.FaceBookUr= vm.FaceBookUr;
            company.TwiterUrl= vm.TwiterUrl;
            company.LinkedInUrl= vm.LinkedInUrl;
            company.InstagramUrl= vm.InstagramUrl;
            company.youtubeUrl= vm.youtubeUrl;
            if (vm.imge != null)
            {
                string folder = "Images/";
                string imageUrl = await UploadImage(folder, vm.imge);
                company.Logo = imageUrl;
          


            }


            await _unitOfWork.GetRepository<Company>().AddAsync(company);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
          ;
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _unitOfWork.GetRepository<Company>().GetByIdAsync(id);

       
            if (company == null)
            {
                return NotFound();
            }
            var vm = new CompanyVM()
            {
                Name = company.Name,
                PhoneNumber = company.PhoneNumber,
                Email = company.Email,
                Mission = company.Mission,
                vision = company.vision,
                AboutUs = company.AboutUs,
                FaceBookUr = company.FaceBookUr,
                InstagramUrl = company.InstagramUrl,
                youtubeUrl = company.youtubeUrl,
                LinkedInUrl = company.LinkedInUrl,
                TwiterUrl = company.TwiterUrl,
                Address = company.Address,
                Logo = company.Logo,


            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, CompanyVM  vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

           
                try
                {
                var company= _unitOfWork.GetRepository<Company>().GetById(id);
                if (company != null)
                {
                    company.Name=vm.Name;
                    company.PhoneNumber=vm.PhoneNumber;
                    company.Email=vm.Email;
                    company.Mission=vm.Mission;
                    company.vision = vm.vision;
                    company.Address=vm.Address;
                    company.AboutUs=vm.AboutUs;
                    company.FaceBookUr = vm.FaceBookUr;
                    company.TwiterUrl = vm.TwiterUrl;
                    company.LinkedInUrl= vm.LinkedInUrl;
                    company.youtubeUrl = vm.youtubeUrl;
                    company.InstagramUrl = vm.InstagramUrl;
                    if (vm.imge != null)
                    {
                        string folder = "Images/";
                        string imageUrl = await UploadImage(folder, vm.imge);
                        company.Logo = imageUrl;

                    }

                    _unitOfWork.GetRepository<Company>().Update(company);
                    await _unitOfWork.SaveChangesAsync();

                }
                else
                {
                    return NotFound();
                }
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(vm.Id))
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

            var company = await _unitOfWork.GetRepository<Company>().GetByIdAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var company = await _unitOfWork.GetRepository<Company>().GetByIdAsync(id);
            if (company != null)
            {
                _unitOfWork.GetRepository<Company>().Delete(company);
            }

            await _unitOfWork.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(string id)
        {
            return _unitOfWork.GetRepository<Company>().FindAsync(c => c.Id == id).Result != null;
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
