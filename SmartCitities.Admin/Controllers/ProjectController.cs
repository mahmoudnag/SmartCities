using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;
using SmartCitities.Admin.ViewModels;
using System.Security.Claims;

namespace SmartCitities.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProjectController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProjectController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: ProjectController
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().FindAllAsync(new[] {"User"}));
            
        }

        // GET: ProjectController/Details/5
        public async Task< ActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            var members = _unitOfWork.GetRepository<Team>().GetAll();
            ViewBag.ItemsList = members;
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectVM vm)
        {

           

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            SmartCities.Core.Models.Project project = new SmartCities.Core.Models.Project();

            if (vm.Image != null)
            {
                string folder = "Images/";
                string imageUrl = await UploadImage(folder, vm.Image);
                project.ImageUrl = imageUrl;
                project.Logo=imageUrl;

            }
            else
            {


                project.ImageUrl = "Images/notfound.png";
                project.Logo = "Images/notfound.png";


            }
            project.Name = vm.Name;
            project.Statues = vm.Statues;
            project.Compeletion=vm.Compeletion;
            project.Budget = vm.Budget; 
            project.Description = vm.Description;

            project.CreateBy = userId;
            project.UpdateBy = userId;


           var pro= await _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().AddAsync(project);
            await _unitOfWork.SaveChangesAsync();


            foreach (var x in vm.teams)
            {
                ProjectTeam PT = new ProjectTeam();
                PT.TeamId = x;
                PT.ProjectId= pro.Id;

                await _unitOfWork.GetRepository<ProjectTeam>().AddAsync(PT);
                await _unitOfWork.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));

        }


        // GET: ProjectController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var members = _unitOfWork.GetRepository<Team>().GetAll();
            ViewBag.ItemsList = members;

            var project = await _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            var vm = new ProjectVM()
            {
                Id=project.Id,
                Budget=project.Budget,
                Statues=project.Statues,
                Compeletion=project.Compeletion,
            
                Name = project.Name,
                Description = project.Description,
                
                ImageUrl = project.ImageUrl,


            };
           
            return View(vm);
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ProjectVM vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            try
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var project = await _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetByIdAsync(id);
                project.UpdateBy = userId;
                project.UpdateAt = DateTime.UtcNow;
                project.Name = vm.Name;
                project.Description = vm.Description;
                project.Statues = vm.Statues;
                project.Budget=vm.Budget;
                project.Compeletion=vm.Compeletion;
                if (vm.Image != null)
                {
                    string folder = "Images/";
                    string imageUrl = await UploadImage(folder, vm.Image);
                    project.ImageUrl = imageUrl;

                }

                foreach (var x in vm.teams)
                {
                    ProjectTeam PT = new ProjectTeam();
                    PT.TeamId = x;
                    PT.ProjectId = id;

                    await _unitOfWork.GetRepository<ProjectTeam>().AddAsync(PT);
                    await _unitOfWork.SaveChangesAsync();

                }

                _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().Update(project);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
                    throw;
             
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: ProjectController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return await Task.FromResult(NotFound());
            }

            var project = _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetById(id);
            if (project == null)
            {
                return await Task.FromResult(NotFound());
            }

            return await Task.FromResult(View(project));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var project = _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetById(id);
            if (project == null)
            {
                return await Task.FromResult(NotFound());
            }
            if (project != null)
            {
                _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().Delete(project);
                await _unitOfWork.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: ProjectController/Delete/5
     
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {

            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }
    }
}
