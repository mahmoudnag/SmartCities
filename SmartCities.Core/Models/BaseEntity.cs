using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.Core.Models
{
    public class BaseEntity
    {
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
