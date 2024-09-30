using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Team:BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string JobTitle { get; set; }
        public string FaceBookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string Instagramurl { get; set; }
        public bool ?Statues { get; set; }
        

        public virtual AppUser User { get; set; }
        public virtual ICollection<ProjectTeam>? ProjectTeams { get; set; }
    }
}
