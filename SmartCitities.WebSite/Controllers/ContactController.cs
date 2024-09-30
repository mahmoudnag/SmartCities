using Microsoft.AspNetCore.Mvc;
using SmartCities.Core;
using SmartCities.Core.Models;
using SmartCities.EF;
using SmartCitities.WebSite.ViewModels;

namespace SmartCitities.WebSite.Controllers
{
    public class ContactController : Controller
    {

        private readonly IUnitOfWork _unitofwork;

        public ContactController(IUnitOfWork unitofwork)
        {

            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ContactRequestVM vm)
        {
            if(ModelState.IsValid)
            {
                ContactRequests obj= new ContactRequests();
              
                obj.Name = vm.Name;
                obj.Email = vm.Email;
                obj.PhoneNumber = vm.PhoneNumber;
                obj.Subject = vm.Subject;
                obj.Message = vm.Message;
                _unitofwork.GetRepository<ContactRequests>().Add(obj);
                _unitofwork.SaveChangesAsync();
                return RedirectToAction("Reply");

            } 
            else
            {
                return RedirectToAction("Index");
            }

            
        }
        public IActionResult Reply()
        {
            return View();
        }
    }
}
