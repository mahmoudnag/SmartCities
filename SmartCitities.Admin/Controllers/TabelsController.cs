using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.Admin.ViewModels;


namespace SmartCitities.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TabelsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TabelsController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var Tables = new TableVM();
            List<ProjectVM> projects = _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetAll().Select(x => new ProjectVM

            {
                Name = x.Name,
                Budget = x.Budget,
                Statues=x.Statues,
                Compeletion=x.Compeletion,
                

                
            } ).ToList();


            List<TeamVM> Team = _unitOfWork.GetRepository<Team>().GetAll().Select(x => new TeamVM

            {
                Id= x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Statues = x.Statues == true ? "online" : "offline",
                employedDate = x.CreateAt.ToString()
            }).ToList();

            Tables.teams=Team;
            Tables.Projects = projects;

            return View(Tables);
        }
    }
}
