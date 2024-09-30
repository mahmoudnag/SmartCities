using Microsoft.AspNetCore.Mvc;
using SmartCities.Core.Models;
using SmartCities.Core;
using SmartCitities.WebSite.ViewModels;

namespace SmartCitities.WebSite.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public FeaturesController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
        }

        public ActionResult index()
        {

            int ClientCount = _unitofwork.GetRepository<Team>().GetAll().ToList().Count();
            int CountProjects = _unitofwork.GetRepository<Project>().GetAll().ToList().Count();

            ContainerVM vm = new ContainerVM();
          
            vm.CountClients = ClientCount;
            vm.CountProjects = CountProjects;

            return View(vm);
        }
    }
}
