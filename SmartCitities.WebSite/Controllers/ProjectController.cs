using Microsoft.AspNetCore.Mvc;
using SmartCities.Core.Models;
using SmartCities.Core;
using SmartCitities.WebSite.ViewModels;
using SmartCitities.WebSite.Helpers;

namespace SmartCitities.WebSite.Controllers
{
    public class ProjectController : Controller
    {

        private readonly IUnitOfWork _unitofwork;
    

        public ProjectController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
          
        }

        public ActionResult index()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();
         
            ViewBag.ImagthPath = ImagthPathServer;
            var projects = _unitofwork.GetRepository<Project>().GetAll().Take(3).ToList();



            ContainerVM vm = new ContainerVM();
            vm.projects = projects;

            return View(vm);
        }
        public ActionResult ProjectsDetails()
        {

            return View();
        }


        public ActionResult Details(string id)
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var project = _unitofwork.GetRepository<Project>().GetById(id);
            return View(project);
          
        }
       

    }
        }

