using Microsoft.AspNetCore.Mvc;

namespace SmartCitities.WebSite.Controllers
{
    public class FAQsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
