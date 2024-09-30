using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string AboutUs { get; set; }
        public string Mission { get; set; }
        public string  ?Aims { get; set; }
        public string vision { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Logo { get; set; }
        public string FaceBookUr { get; set; }
        public string TwiterUrl { get; set; }
        public string LinkedInUrl  { get; set;}
        public string InstagramUrl  { get; set;}
        public string youtubeUrl { get; set;}
      
    }
}
