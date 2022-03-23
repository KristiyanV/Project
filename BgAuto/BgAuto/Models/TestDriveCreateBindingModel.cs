using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Models
{
    public class TestDriveCreateBindingModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }
        public string CarId { get; set; }
        public Car Car { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime TestOn { get; set; }
    }
}
