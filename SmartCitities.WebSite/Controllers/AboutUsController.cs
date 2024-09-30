using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.WebSite.ViewModels;

namespace SmartCitities.WebSite.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public AboutUsController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
         
            var Teams = _unitofwork.GetRepository<Team>().GetAll().Take(4).ToList();
            int ClientCount = _unitofwork.GetRepository<Team>().GetAll().ToList().Count();
            int CountProjects = _unitofwork.GetRepository<Project>().GetAll().ToList().Count();
            Company company = _unitofwork.GetRepository<Company>().GetById("1");


            ContainerVM vm = new ContainerVM();
            vm.company = company;
         
            vm.Teams = Teams;
            vm.CountClients = ClientCount;
            vm.CountProjects = CountProjects;

            return View(vm);

        }
    }
}
