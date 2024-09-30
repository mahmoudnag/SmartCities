using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.WebSite.Helpers;
using SmartCitities.WebSite.ViewModels;

namespace SmartCitities.WebSite.Controllers
{
    public class ServiceController : Controller
    {

        private readonly IUnitOfWork _unitofwork;
    

        public ServiceController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
           
        }

        public IActionResult Index()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var products = _unitofwork.GetRepository<Product>().FindAll(new[] { "SubProducts" }).Take(4).ToList();

            List<Client> Clients = _unitofwork.GetRepository<Client>().FindAll(new[] { "Comments" }).Take(4).ToList();
            ContainerVM vm = new ContainerVM();
         
            vm.Products = products;
            vm.Clients = Clients;


            return View(vm);
        }



        public IActionResult ServiceDetails()
        {

            return View();


        }
        public IActionResult Details(string id)
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var product= _unitofwork.GetRepository<Product>().FindAll(b=>b.ParentProductId== id, new[] { "ParentProduct" });
            if(product.Count()==0)
            {

                product= _unitofwork.GetRepository<Product>().FindAll(b => b.Id == id);
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult ProductList()
        {
            var product = _unitofwork.GetRepository<Product>().GetAll();
            return PartialView(product);
        }
    }
}
