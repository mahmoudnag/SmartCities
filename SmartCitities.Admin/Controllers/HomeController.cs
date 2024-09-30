using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.Admin.Models;
using SmartCitities.Admin.StaticF;
using SmartCitities.Admin.ViewModels;
using System.Diagnostics;

namespace SmartCitities.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

     
        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexRTL()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult PartialHome()
        {
            var vm = new HomeVM();
            try
            {


                var company = _unitOfWork.GetRepository<Company>().GetById("1");

                var requests = _unitOfWork.GetRepository<ContactRequests>().GetAll().Take(4).ToList();
                var projects = _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetAll().Take(4)

                    .Select(x => new ProjectVM
                    {
                        Name = x.Name,
                        Budget = x.Budget,
                        Compeletion = x.Compeletion,
                        ImageUrl = x.ImageUrl


                    }).ToList();
                vm.Projects = projects;
                vm.Requests = requests;
                vm.Company = company;
                return PartialView(vm);
            }
            catch (Exception ex)
            {
                return Json("Page Not Available Now ");
            }

        }
        [HttpPost]
        public IActionResult PartialHomeArabic()
        {
            var vm = new HomeVM();
            try
            {


                var company = _unitOfWork.GetRepository<Company>().GetById("1");

                var requests = _unitOfWork.GetRepository<ContactRequests>().GetAll().Take(4).ToList();
                var projects = _unitOfWork.GetRepository<SmartCities.Core.Models.Project>().GetAll().Take(4)

                    .Select(x => new ProjectVM
                    {
                        Name = x.Name,
                        Budget = x.Budget,
                        Compeletion = x.Compeletion,
                        ImageUrl = x.ImageUrl


                    }).ToList();
                vm.Projects = projects;
                vm.Requests = requests;
                vm.Company = company;
                return PartialView(vm);
            }
            catch (Exception ex)
            {
                return Json("Page Not Available Now ");
            }

        }
        public ActionResult ChangeLanguageToE()
        {
            CostantsVaules.LayoutType = "~/Views/Shared/_Layout.cshtml";
            return RedirectToAction("Index");
        }
        public ActionResult ChangeLanguageToA()
        {
            CostantsVaules.LayoutType = "~/Views/Shared/_LayoutArab.cshtml";
            return RedirectToAction("Index");
        }
    }
}
