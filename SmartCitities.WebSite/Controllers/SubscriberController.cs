using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;

namespace SmartCitities.WebSite.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public SubscriberController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string  email)
        {
            Subscriber obj = new Subscriber();
            try
            {
           
                obj.Email = email;


                _unitofwork.GetRepository<Subscriber>().Add(obj);
                _unitofwork.SaveChangesAsync();
                return Json(obj);
            }
            catch
            {
                return Json(obj);
            }

        }
    }
}
