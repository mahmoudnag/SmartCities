using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Partener> Parteners { get; set; }
        public virtual ICollection<New> News { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
