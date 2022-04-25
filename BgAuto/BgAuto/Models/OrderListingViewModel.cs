using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class OrderListingViewModel
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string CustomerId { get; set; }
        public string Customer { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string OrderedOn { get; set; }
        public string TestOn { get; set; }
        public int Quantity { get; set; }
    }
}
