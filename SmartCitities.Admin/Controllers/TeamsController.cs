using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;
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
    public class TeamsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
         private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamsController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            this.unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            return View(await unitOfWork.GetRepository<Team>().FindAllAsync(new[]{"User"}));
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await unitOfWork.GetRepository<Team>().GetByIdAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // GET: Teams/Create
        public  IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamVM vm)
        {
           
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                Team team= new Team();

                if (vm.img != null)
                {
                    string folder = "Images/";
                    string imageUrl = await UploadImage(folder,vm.img);
                    team.ImageUrl = imageUrl;

                }
               else  
                 {
                string folder = "Images/";

                vm.ImageUrl = "Images/notfound.png";


             }
            team.Name = vm.Name;
                team.TwitterUrl= vm.TwitterUrl;
                team.FaceBookUrl= vm.FaceBookUrl;
                team.Instagramurl = vm.Instagramurl;
                team.LinkedInUrl = vm.LinkedInUrl;
                team.JobTitle = vm.JobTitle;
                team.CreateBy = userId;
                team.UpdateBy= userId;


                await unitOfWork.GetRepository<Team>().AddAsync(team);
                await unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }
       
        [HttpPost]
        // Controller action to handle image upload
        [HttpPost]
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }

        // GET: Teams/Edit/5

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await unitOfWork.GetRepository<Team>().GetByIdAsync(id);
            var vm = new TeamVM()
            {
                Name = team.Name,
                JobTitle= team.JobTitle,
                FaceBookUrl= team.FaceBookUrl,
                LinkedInUrl = team.LinkedInUrl,
                Instagramurl=team.Instagramurl,
                TwitterUrl=team.TwitterUrl,
                ImageUrl=team.ImageUrl,


            };
            if (team == null)
            {
                return NotFound();
            }
            return View(vm);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, TeamVM vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

             try
                {
                    string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    Team team = await unitOfWork.GetRepository<Team>().GetByIdAsync(id);
                    team.UpdateBy = userId;
                    team.UpdateAt = DateTime.UtcNow;
                    if (vm.img != null)
                    {
                        string folder = "Images/";
                        string imageUrl = await UploadImage(folder, vm.img);
                        team.ImageUrl = imageUrl;

                    }
                    
                    team.Name = vm.Name;
                    team.JobTitle = vm.JobTitle;
                    team.FaceBookUrl = vm.FaceBookUrl;
                    team.Instagramurl = vm.Instagramurl;
                    unitOfWork.GetRepository<Team>().Update(team);
                    await unitOfWork.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(vm.Id).Result)
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

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return await Task.FromResult(NotFound());
            }

            var team = unitOfWork.GetRepository<Team>().GetById(id);
            if (team == null)
            {
                return await Task.FromResult(NotFound());
            }

            return await Task.FromResult(View(team));
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var team = unitOfWork.GetRepository<Team>().GetById(id);
            if (team == null)
            {
                return await Task.FromResult(NotFound());
            }
            if (team != null)
            {
                unitOfWork.GetRepository<Team>().Delete(team);
                await unitOfWork.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> TeamExists(string id)
        {
            Expression<Func<Client, bool>> criteria = client => client.Id == id;

            return await unitOfWork.GetRepository<Client>().FindAsync(criteria) != null;
        }
    }
}

