using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCitities.WebSite.Helpers;

namespace SmartCitities.WebSite.Controllers
{
    public class OfferController : Controller
    {
        private readonly IUnitOfWork _unitofwork;
      

        public OfferController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
         
        }

        public IActionResult Index()
        {
            var ImagthPathServer = AppConfig.GetImagthPathServer();

            ViewBag.ImagthPath = ImagthPathServer;
            var offer=_unitofwork.GetRepository<New>().GetAll();
            return View(offer);
        }
    }
}
