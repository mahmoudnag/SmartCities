using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class ClientProducts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public string ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
    }
}
