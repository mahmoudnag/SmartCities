using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class CompanyVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mission is required")]
        public string Mission { get; set; }
        [Required(ErrorMessage = "vision is required")]
        public string vision { get; set; }
        [Required(ErrorMessage = "AboutUs is required")]
        public string AboutUs { get; set; }
        

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]

        public string PhoneNumber { get; set; }
        public string Logo { get; set; }
        public IFormFile ?imge { get; set; }

        [Required(ErrorMessage = "FaceBook Url is required")]

        public string FaceBookUr { get; set; }
        [Required(ErrorMessage = "Twiter Url is required")]

        public string TwiterUrl { get; set; }
        [Required(ErrorMessage = "LinkedIn Url is required")]

        public string LinkedInUrl { get; set; }
        [Required(ErrorMessage = "Instagram Url is required")]

        public string InstagramUrl { get; set; }
        [Required(ErrorMessage = "youtube Url is required")]

        public string youtubeUrl { get; set; }
    }
}
