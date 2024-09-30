using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class Subscriber:BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
