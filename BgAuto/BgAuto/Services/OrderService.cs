using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Services
{
    public class OrderService:IOrderService
    {
        private readonly ApplicationDbContext context;

        public OrderService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public List<Order> All()
        {
            var orders = context.Orders.ToList();

            return orders;
        }
        public List<Order> My(string customerId)
        {
            var orders = context.Orders.ToList();

            return orders;
        }

        public bool Create(string Id, string CarId, Car Car, DateTime OrderedOn, string Count)
        {
            var user = context.Users.SingleOrDefault(s => s.Id == CarId);

            Order orders = new Order
            {
                Id = Id,
                CarId = CarId,
                Car = Car,
                OrderedOn = OrderedOn,
                Count = Count
            };
            context.Orders.Add(orders);
            return context.SaveChanges() != 0;
        }
    }
}
