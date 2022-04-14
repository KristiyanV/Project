using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Domain
{
    public class Order
    {
        public string Id { get; set; }
        public string CarId { get; set; }
        public Car Car { get; set; }
        public DateTime OrderedOn { get; set; }
        public string Count { get; set; }
    }
}
