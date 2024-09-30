using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class ContactRequests:BaseEntity
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        
        public string Subject { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }

    }
}
