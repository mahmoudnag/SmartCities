using System.ComponentModel.DataAnnotations;

namespace SmartCitities.WebSite.ViewModels
{
    public class ContactRequestVM
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = " Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Subject is required")]

        public string Subject { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "Message must have at least 10 characters.") ]
            
            
            [MaxLength(250, ErrorMessage = "Message must not be more than 250 characters.")]
        public string Message { get; set; }
    }
}
