using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class CarPromotionViewModel
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal Discount { get; set; }
        public string Image { get; set; }
    }
}
