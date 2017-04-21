using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xpo.DriveXpo.Api.Models
{
    public class Load
    {
        public int LoadId { get; set; }
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public Stop[] Stops { get; set; }
        public string Equipment { get; set; }
        public string Commodity { get; set; }
        public decimal Weight { get; set; }
        public int? DispatchedBy { get; set; }
    }
}
