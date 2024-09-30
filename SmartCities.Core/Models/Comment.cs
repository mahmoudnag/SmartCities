using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Comment:BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

       public string ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
    }
}
