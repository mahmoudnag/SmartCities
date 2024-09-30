using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartCities.Core.Models;
using SmartCitities.Admin.ViewModels;
using SmartCitities.Admin.ViewModels.AccountVM;

namespace SmartCitities.Admin.Controllers
{
    public class AccountController : Controller
    {
        SignInManager<AppUser> SignInManager;
        UserManager<AppUser> UserManager;

        public AccountController(SignInManager<AppUser> _SignInManager,
            UserManager<AppUser> userManager)
        {



            SignInManager = _SignInManager;
            UserManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                AppUser User = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName=model.FirstName,
                    LastName=model.LastName
                   
                  ,
                };
                IdentityResult result =
                await UserManager.CreateAsync(User, model.Password);
                await UserManager.AddToRoleAsync(User, "Admin");
                if (!result.Succeeded)
                {
                    result.Errors.ToList().ForEach(
                        i =>
                        {
                            ModelState.AddModelError("", i.Description);
                        }
                        );
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }



     
      
        public IActionResult SignIn(string ReturnUrl)
        {
            ViewBag.url = ReturnUrl;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(LoginModel model)
        
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                var result =
                await SignInManager.PasswordSignInAsync(model.UserName, model.Password,
                        model.RememberMe, true);

                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "Your Account Is Locked Out Try After 1 Minute");
                    return View();
                }
                else
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Invalid User Name Or password");
                    return View();
                }

                else
                    if (!string.IsNullOrEmpty( model.ReturnUrl))
                {

                    string url= "https://localhost:7294"+model.ReturnUrl;
                    return Redirect(model.ReturnUrl);
                }
                else
                {

                    return RedirectToAction("Index", "Home");
                }
            }

        }

        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }


}
