using Microsoft.AspNetCore.Mvc;

namespace SmartCitities.WebSite
{
    public class ConfigurationViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public ConfigurationViewComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IViewComponentResult Invoke(string key)
        {
            return View(key, _configuration[key]);
        }
    }

}

