using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class NewVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }
        [Required(ErrorMessage = " Picture is required")]
        public IFormFile? Picture { get; set; }
        [Required(ErrorMessage = "video is required")]

        public IFormFile? video { get; set; }




        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
