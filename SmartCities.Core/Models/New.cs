using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class New : BaseEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string LinkUrl { get; set; }
        public string ImageUrl { get; set; }
        public AppUser User { get; set; }
    }
}
