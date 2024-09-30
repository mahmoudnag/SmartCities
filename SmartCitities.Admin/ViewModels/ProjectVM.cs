using Microsoft.AspNetCore.Mvc.Rendering;
using SmartCities.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartCitities.Admin.ViewModels
{
    public class ProjectVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        
        public IFormFile ?Image { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Statues is required")]
        public string? Statues { get; set; }
        [Required(ErrorMessage = "Budget is required")]
        public string? Budget { get; set; }
        [Required(ErrorMessage = "Compeletion is required")]
        public string? Compeletion { get; set; }
        public List<string>? teams { get; set; }
        public List<string> SelectedItems { get; set; }
        public List<SelectListItem> AvailableItems { get; set; }

    }
}
