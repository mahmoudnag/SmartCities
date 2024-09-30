using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Partener:BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Address { get; set; }
        public AppUser User { get; set; }

        public virtual ICollection<PartenerProducts> Products { get; set; }
    }
}
