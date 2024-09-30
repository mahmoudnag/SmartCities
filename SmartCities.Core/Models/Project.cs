using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public  class Project:BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ?Statues { get; set; }
        public string ?Budget { get; set; }
        public string ?Compeletion { get; set; }
        

        public string ImageUrl { get; set; }
        public string Logo { get; set; }
        public AppUser User { get; set; }
        public virtual ICollection<ProjectTeam>? ProjectTeams { get; set;}

    }
}
