
using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;
using SmartCitities.WebSite;
using SmartCitities.WebSite.Helpers;
using SmartCitities.WebSite.ViewModels;
using System.Configuration;


namespace smartcitities.website.controllers
{
   
    public class HomeController : Controller
    {

        private readonly IUnitOfWork _unitofwork;
        private readonly IConfiguration _configuration;


        public HomeController(IUnitOfWork unitofwork, IConfiguration configuration)
        {
          
            _unitofwork = unitofwork;
            _configuration = configuration;
        }

        public ActionResult index()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var products = _unitofwork.GetRepository<Product>().FindAll(new[] { "SubProducts" }).Take(4).ToList();
            var projects= _unitofwork.GetRepository<Project>().GetAll().Take(3).ToList();
            var Teams= _unitofwork.GetRepository<Team>().GetAll().Take(4).ToList();
            int ClientCount= _unitofwork.GetRepository<Team>().GetAll().ToList().Count();
            List<Client> Clients= _unitofwork.GetRepository<Client>().FindAll(new[] { "Comments" }).Take(4).ToList();
            int CountProjects = _unitofwork.GetRepository<Project>().GetAll().ToList().Count();
            Company company = _unitofwork.GetRepository<Company>().GetById("1");


            ContainerVM vm= new ContainerVM();
            vm.company= company;
            vm.projects = projects;
            vm.Products = products;
            vm.Teams = Teams;
            vm.Clients = Clients;
            vm.CountClients = ClientCount;
            vm.CountProjects = CountProjects;

            return View(vm);
        }

      public ActionResult CompanyDetails()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            Company company = _unitofwork.GetRepository<Company>().GetById("1");

            ContainerVM vm = new ContainerVM();
            vm.company = company;

            return View(vm);
        }

        [HttpPost]
        public ActionResult GetInTouch()
        {
            ContainerVM vm = new ContainerVM();
            Company company = _unitofwork.GetRepository<Company>().GetById("1");
           List<Product> Products= _unitofwork.GetRepository<Product>().GetAll().Take(5).ToList();
            vm.Products= Products;
            vm.company = company;
            return PartialView(vm);
        }


        public ActionResult Error()  
        {

            return View ();
        }
        public ActionResult NotFound(int? statusCode)
        {
            if (statusCode.HasValue && statusCode.Value == 404)
            {
                return View("404");
            }
            // Handle other status codes if needed
            return View("Error");
        }
        public ActionResult NoFound()
        {

            return View("404");
        }





    }
}
