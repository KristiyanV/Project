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

            foreach (var order in orders)
            {
                order.Car = context.Cars.Find(order.CarId);
                order.Customer = context.Users.Find(order.CustomerId);
            }

            return orders;
        }
        public List<Order> My(string customerId)
        {
            var orders = context.Orders.Where(x => x.CustomerId == customerId).ToList();
            var list = context.Cars.ToList();

            foreach (var order in orders)
            {
                order.Car = context.Cars.Find(order.CarId);
                order.Customer = context.Users.Find(order.CustomerId);
            }

            return orders;
        }

        public bool Create(string Id, string CustomerId, string userid, ApplicationUser Customer, string CarId, Car Car, DateTime OrderedOn, int Quantity)
        {
            var user = context.Users.SingleOrDefault(s => s.Id == CustomerId);

            Order orders = new Order
            {
                Id = Id,
                CarId = CarId,
                CustomerId = userid,
                Car = Car,
                OrderedOn = OrderedOn,
                Quantity = Quantity
            };
            var car = context.Cars.SingleOrDefault(x => x.Id == CarId);
            car.Quantity -= Quantity;
            context.Cars.Update(car);
            context.Orders.Add(orders);
            return context.SaveChanges() != 0;
        }
    }
}
