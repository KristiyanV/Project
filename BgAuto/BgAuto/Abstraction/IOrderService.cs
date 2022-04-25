using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface IOrderService
    {
        public bool Create(string Id, string CustomerId, string userId, ApplicationUser Customer, string CarId, Car Car, DateTime OrderedOn, int Quantity);
        public List<Order> All();
        public List<Order> My(string customerId);
    }
}
