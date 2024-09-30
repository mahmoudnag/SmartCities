using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class TeamVM
    {
       
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
 
        public IFormFile? img { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Job Title is required")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "FaceBook Url is required")]
        public string FaceBookUrl { get; set; }
        [Required(ErrorMessage = "LinkedIn Url is required")]
        public string LinkedInUrl { get; set; }
        [Required(ErrorMessage = "Twitter Url is required")]
        public string TwitterUrl { get; set; }
        [Required(ErrorMessage = "Instagram url is required")]
        public string Instagramurl { get; set; }
        public string Statues { get; set; }
        public string employedDate { get; set; }
        
    }
}
