using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Client:BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string level { get; set; }

        public string Email { get; set; }
        public string phoneNumber { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Logo { get; set; }
        public string WebSiteUrl { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ClientProducts> Product { get; set; }
    }
}
