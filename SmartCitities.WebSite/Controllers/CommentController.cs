using Microsoft.AspNetCore.Mvc;

namespace SmartCitities.WebSite.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CommentsDetails()
        {
            return View();
        }

    }
}
