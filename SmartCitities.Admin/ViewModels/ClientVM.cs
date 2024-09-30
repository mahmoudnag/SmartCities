using SmartCities.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class ClientVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "level is required")]
        public string level { get; set; }

        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }
        [Required(ErrorMessage = "phone Number is required")]


        public string phoneNumber { get; set; }
        [Required(ErrorMessage = "Country Number is required")]


        public string Country { get; set; }
        [Required(ErrorMessage = "Area Number is required")]


        public string Area { get; set; }
        [Required(ErrorMessage = "City Url Number is required")]
        public string City { get; set; }
      
        public IFormFile ?Logo { get; set; }
        public string ?LogoUrl { get; set; }
        [Required(ErrorMessage = "WebSite Url Number is required")]


        public string WebSiteUrl { get; set; }
        
    }
}
