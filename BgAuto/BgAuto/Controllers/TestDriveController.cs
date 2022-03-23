using BgAuto.Abstraction;
using BgAuto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class TestDriveController : Controller
    {
        private readonly ITestDriveService service;

        public TestDriveController(ITestDriveService _service)
        {
            this.service = _service;
        }
        public IActionResult All()
        {
            List<TestDriveListingViewModel> testdrive = service.All()
                .Select(x => new TestDriveListingViewModel
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    Customer = x.Customer.UserName,
                    Model = x.Car.Model,
                    Brand = x.Car.Brand,
                    OrderedOn = x.OrderedOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    TestOn = x.TestOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture)

                }).ToList();

            return View(testdrive);
        }
        public IActionResult My()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<TestDriveListingViewModel> testdrive = service.My(userId)
                .Select(x => new TestDriveListingViewModel
                {
                    Id = x.Id,
                    CustomerId = x.CustomerId,
                    Customer = x.Customer.UserName,
                    Model = x.Car.Model,
                    Brand = x.Car.Brand,
                    OrderedOn = x.OrderedOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture),
                    TestOn = x.TestOn.ToString("dd-MMM,yyyy hh:mm", CultureInfo.InvariantCulture)

                }).ToList();

            return View("All", testdrive);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TestDriveCreateBindingModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var created = service.Create(viewModel.Id, viewModel.CustomerId, userId, viewModel.Customer, viewModel.CarId, viewModel.Car, viewModel.OrderedOn, viewModel.TestOn);

                if (created)
                {
                    return RedirectToAction("My");
                }
            }
            return RedirectToAction();
        }
    }
}
