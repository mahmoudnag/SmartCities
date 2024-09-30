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
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(IUnitOfWork unitOfWork,IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.GetRepository<Product>().FindAllAsync(new[] {"User"}));
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {

           List< Product> items = _unitOfWork.GetRepository<Product>().GetAll().ToList();

            Product product = new Product()
            {
                Id = "0",
                Name = "No Parent"
            };

            items.Add(product);

         ViewBag.Products = new SelectList(items, "Id", "Name");

            
            



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ProductVM vm)
        {
               string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var product = new Product();
                product.CreateBy =  userId ;   
                product.UpdateBy = userId ;   
                product.CreateAt = DateTime.UtcNow;
            product.Description= vm.Description;
            product.Name= vm.Name;

            if (vm.Picture != null)
            {
                string folder = "Images/";
                string imageUrl = await UploadImage(folder, vm.Picture);
                product.ImageUrl = imageUrl;
                product.Logo = imageUrl;


            }
            else
            {

                product.ImageUrl = "Images/notfound.png";
                product.Logo = "Images/notfound.png";

            }
            if(vm.ParentProductId != "0")
              product.ParentProductId=vm.ParentProductId;
            ViewData["ParentProductId"] = new SelectList(_unitOfWork.GetRepository<Product>().GetAll(), "Id", "Id", product.ParentProductId);
            await _unitOfWork.GetRepository<Product>().AddAsync(product);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
            
        }
    

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var vm = new ProductVM()
            {
                Name = product.Name,
                Description = product.Description,
                
                ImageUrl = product.ImageUrl,
                 Logo= product.Logo,



            };


            List<Product> items = _unitOfWork.GetRepository<Product>().GetAll().ToList();

            Product productNull = new Product()
            {
                Id = "0",
                Name = "No Parent"
            };

            items.Add(productNull);

            ViewData["ParentProductId"] = new SelectList(items, "Id", "Name", product.ParentProductId);
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ProductVM vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Product product = _unitOfWork.GetRepository<Product>().GetById(id);
            try
            {

                product.UpdateBy = userId;
                product.UpdateAt = DateTime.UtcNow;
                product.Name = vm.Name;
                product.Description = vm.Description;
                if (vm.ParentProductId!="0")
                     product.ParentProductId = vm.ParentProductId;
                if (vm.Picture != null)
                {
                    string folder = "Images/";
                    string imageUrl = await UploadImage(folder, vm.Picture);
                    product.ImageUrl = imageUrl;
                    product.Logo =imageUrl;


                }
                else 
                {
                    
              
                    product.Logo = "Images/default.jpg";


                }



                _unitOfWork.GetRepository<Product>().Update(product);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            ViewData["ParentProductId"] = new SelectList(_unitOfWork.GetRepository<Product>().GetAll(), "Id", "Id", product.ParentProductId);

                return RedirectToAction(nameof(Index));
            }
            
        

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _unitOfWork.GetRepository<Product>().GetByIdAsync(id);
            try
            {

        
            if (product != null )
            {
                _unitOfWork.GetRepository<Product>().Delete(product);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
            }
            catch
            {
                return View(product);
            }


        }

        private bool ProductExists(string id)
        {
            return _unitOfWork.GetRepository<Product>().FindAsync(p => p.Id == id).Result != null;
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
