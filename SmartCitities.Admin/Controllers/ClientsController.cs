using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SmartCitities.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ClientsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ClientsController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            this.unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await unitOfWork.GetRepository<Client>().FindAllAsync(new[] { "User" }));
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await unitOfWork.GetRepository<Client>().GetByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ClientVM vm)
        {
           
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var client = new Client();
                client.Name= vm.Name;
                client.Email= vm.Email;
                client.WebSiteUrl=vm.WebSiteUrl;
                client.phoneNumber=vm.phoneNumber;
                client.Country = vm.Country;
                client.City = vm.City;
                client.Area = vm.Area;
            client.level = vm.level;
                client.CreateBy = userId;
                client.UpdateBy=userId;

                client.CreateAt = DateTime.UtcNow;
                if (vm.Logo != null)
                {
                    string folder = "Images/";
                    string imageUrl = await UploadImage(folder, vm.Logo);
                    client.Logo = imageUrl;



                }
            else
            {
                client.Logo ="Images/notfound.png";
                
            }

                await unitOfWork.GetRepository<Client>().AddAsync(client);
                await unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
         
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await unitOfWork.GetRepository<Client>().GetByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            var vm = new ClientVM()
            {
                Name = client.Name,
                Country=client.Country,
                City=client.City,
                Area=client.Area,
                Email=client.Email,
                phoneNumber=client.phoneNumber,
                level=client.level, 
                LogoUrl=client.Logo,
                WebSiteUrl=client.WebSiteUrl,
                

            };
            return View(vm);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,ClientVM VM)
        {
            if (id != VM.Id)
            {
                return NotFound();
            }
            try
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var client = unitOfWork.GetRepository<Client>().GetById(id);
                if (client != null)
                {
                    client.UpdateBy = userId;
                    client.UpdateAt = DateTime.UtcNow;
                    client.Country = VM.Country;
                    client.City = VM.City;
                    client.Area = VM.Area;
                    client.Email = VM.Email;
                    client.phoneNumber = VM.phoneNumber;
                    client.Name = VM.Name;
                    client.level = client.level;
                    if (VM.Logo != null)
                    {
                        string folder = "Images/";
                        string imageUrl = await UploadImage(folder, VM.Logo);
                        client.Logo = imageUrl;

                    }

                    unitOfWork.GetRepository<Client>().Update(client);
                    await unitOfWork.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(VM.Id).Result)
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

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return await Task.FromResult(NotFound());
            }

            var client=unitOfWork.GetRepository<Client>().GetById(id);
            if (client == null)
            {
                return await Task.FromResult(NotFound());
            }

            return await Task.FromResult(View(client));
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (id == null)
            {
                return await Task.FromResult(NotFound());
            }

            var client = unitOfWork.GetRepository<Client>().GetById(id);
            if (client == null)
            {
                return await Task.FromResult(NotFound());
            }
            if (client != null)
            {
                unitOfWork.GetRepository<Client>().Delete(client);
                await unitOfWork.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }

        private async Task<bool> ClientExists(string id)
        {
            Expression<Func<Client, bool>> criteria = client => client.Id == id;

            return  await unitOfWork.GetRepository<Client>().FindAsync(criteria)!=null;
            
        }
    }
}
