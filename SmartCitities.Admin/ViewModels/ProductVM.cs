using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class ProductVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
       
        public IFormFile? Picture { get; set; }

        public string ImageUrl { get; set; }
        public string Logo { get; set; }

        public string? ParentProductId { get; set; }
    }
}
