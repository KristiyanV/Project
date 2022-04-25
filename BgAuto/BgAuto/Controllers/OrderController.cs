using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using BgAuto.Models;
using BgAuto.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderService service;

        public OrderController(IOrderService _service)
        {
            this.service = _service;
        }
        public IActionResult All()
        {
            List<OrderListingViewModel> order = service.All()
                .Select(x => new OrderListingViewModel
                {
                    Id = x.Id,
                    Image = x.Car.Image,
                    CustomerId = x.CustomerId,
                    Customer = x.Customer.UserName,
                    Price = x.Car.Price * x.Quantity,
                    Model = x.Car.Model,
                    Brand = x.Car.Brand,
                    OrderedOn = x.OrderedOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    Quantity = x.Quantity

                }).ToList();
            return View(order);
        }
        public IActionResult My()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<OrderListingViewModel> order = service.My(userId)
                .Select(x => new OrderListingViewModel
                {
                    Id = x.Id,
                    Image = x.Car.Image,
                    CustomerId = x.CustomerId,
                    Customer = x.Customer.UserName,
                    Price = x.Car.Price * x.Quantity,
                    Model = x.Car.Model,
                    Brand = x.Car.Brand,
                    OrderedOn = x.OrderedOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    Quantity = x.Quantity

                }).ToList();
            return View(order);
        }
        public IActionResult Create(string carId)
        {
            OrderCreateViewModel order = new OrderCreateViewModel()
            {
                CarId = carId,
                OrderedOn = DateTime.Now
            };
            return View(order);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var created = service.Create(viewModel.Id, viewModel.CustomerId, userId, viewModel.Customer, viewModel.CarId, viewModel.Car, viewModel.OrderedOn, viewModel.Quantity);

                if (created)
                {
                    return RedirectToAction("My");
                }
            }
            return RedirectToAction();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
