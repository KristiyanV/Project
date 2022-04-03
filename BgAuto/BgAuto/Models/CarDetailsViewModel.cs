using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class CarDetailsViewModel
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string CarNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public string Extras { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
