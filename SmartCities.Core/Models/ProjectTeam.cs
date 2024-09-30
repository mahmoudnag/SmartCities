using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class ProjectTeam
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project project { get; set; }

        public string TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Teams { get; set; }
    }
}
