using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.WebSite.Helpers;
using SmartCitities.WebSite.ViewModels;

namespace SmartCitities.WebSite.Controllers
{
    public class TeamController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
  
        public TeamController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
          
        }

        public IActionResult Index()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;

            var team= _unitofwork.GetRepository<Team>().GetAll();
            return View(team);
        }
        public IActionResult TeamsDetails()
        {

            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var Teams= _unitofwork.GetRepository<Team>().GetAll().ToList();


            ContainerVM vm = new ContainerVM();
            vm.Teams = Teams;

            return View(vm);
   
        
        
        
        }
    }
}
