using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    interface IOrderService
    {
        public bool Create(string Id, string CarId, Car Car, DateTime OrderedOn, string Count);
        public List<Order> All();
        public List<Order> My(string customerId);
    }
}
