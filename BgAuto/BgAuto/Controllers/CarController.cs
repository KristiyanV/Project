using BgAuto.Abstraction;
using BgAuto.Domain;
using BgAuto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService service;

        public CarController(ICarService _service)
        {
            this.service = _service;
        }

        public IActionResult All()
        {
            List<CarAllViewModel> car = service.GetCars()
                .Select(x => new CarAllViewModel
                {
                    Id = x.Id,
                    Image = x.Image,
                    CarNumber = x.CarNumber,
                    Color = x.Color,
                    Country = x.Country,
                    Brand = x.Brand,
                    Engine = x.Engine,
                    Extras = x.Extras,
                    Model = x.Model,
                    Year = x.Year,
                    Price = x.Price,
                    Discount = x.Discount
                }).ToList();


            return View("All", car);
        }

        public IActionResult Details(string id)
        {
            var x = service.GetCar(id);

            CarDetailsViewModel detailsViewModel = new CarDetailsViewModel
            {
                Id = x.Id,
                Image = x.Image,
                CarNumber = x.CarNumber,
                Color = x.Color,
                Country = x.Country,
                Brand = x.Brand,
                Engine = x.Engine,
                Extras = x.Extras,
                Model = x.Model,
                Year = x.Year,
                Price = x.Price,
                Discount = x.Discount
            };

            return View("Details", detailsViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarCreateViewModel car)
        {
            if (ModelState.IsValid)
            {
                var isCreated = service.Create(car.Image, car.CarNumber, car.Brand, car.Model, car.Year, car.Engine, car.Color, car.Country, car.Extras, car.Price, car.Discount);

                if (isCreated)
                {
                    return RedirectToAction("All");
                }
            }
            return View();
        }

        public IActionResult Edit(string id)
        {
            {
                Car item = service.GetCar(id);
                if (item == null)
                {
                    return NotFound();
                }
                CarCreateViewModel car = new CarCreateViewModel()
                {
                    Id = item.Id,
                    Image = item.Image,
                    CarNumber = item.CarNumber,
                    Color = item.Color,
                    Country = item.Country,
                    Brand = item.Brand,
                    Engine = item.Engine,
                    Extras = item.Extras,
                    Model = item.Model,
                    Year = item.Year,
                    Price = item.Price,
                    Discount = item.Discount

                };
                return View(car);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, CarCreateViewModel createCar)
        {
            if (ModelState.IsValid)
            {
                var updated = service.UpdateCar(createCar.Id, createCar.Image, createCar.CarNumber, createCar.Brand, createCar.Model, createCar.Year, createCar.Engine, createCar.Color, createCar.Country, createCar.Extras, createCar.Price, createCar.Discount);
                if (updated)
                {
                    return this.RedirectToAction("All");
                }
            }
            return View();
        }

        public IActionResult Delete(string id)
        {
            var item = service.GetCar(id);

            if (item == null)
            {
                return NotFound();
            }
            var deleteModel = new CarCreateViewModel

            {
                Id = item.Id,
                Image = item.Image,
                CarNumber = item.CarNumber,
                Color = item.Color,
                Country = item.Country,
                Brand = item.Brand,
                Engine = item.Engine,
                Extras = item.Extras,
                Model = item.Model,
                Year = item.Year
            };
            return View(deleteModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id, IFormCollection collection)
        {
            var deleted = service.RemoveCar(id);
            if (deleted)
            {
                return this.RedirectToAction("All");
            }
            else
            {
                return View();
            }
        }
        public IActionResult MakeDiscount(string id)
        {
            var x = service.GetCar(id);

            CarPromotionViewModel product = new CarPromotionViewModel
            {
                Id = x.Id,
                Model = x.Model,
                Brand = x.Brand,
                OldPrice = x.Price,
                NewPrice = x.Price,
                Image = x.Image
            };
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MakeDiscount(string id, int discount)
        {
            service.MakeDiscount(id, discount);

            return this.RedirectToAction("All");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveDiscount(string id, int discount)
        {
            service.RemoveDiscount(id);

            return this.RedirectToAction("All");
        }
        public IActionResult AllDiscounts()
        {
            var products = new List<CarAllViewModel>();

            foreach (var product in service.GetCars().Where(x => x.Discount != 0))
            {
                var viewModel = new CarAllViewModel
                {
                    Id = product.Id,
                    Image = product.Image,
                    CarNumber = product.CarNumber,
                    Color = product.Color,
                    Country = product.Country,
                    Brand = product.Brand,
                    Engine = product.Engine,
                    Extras = product.Extras,
                    Model = product.Model,
                    Year = product.Year,
                    Price = product.Price,
                    Discount = product.Discount
                };
                products.Add(viewModel);
            }
            return View("All", products);
        }
        public IActionResult Promotion()
        {
            List<CarAllViewModel> car = service.GetCars()
                .Select(x => new CarAllViewModel
                {
                    Id = x.Id,
                    Image = x.Image,
                    CarNumber = x.CarNumber,
                    Color = x.Color,
                    Country = x.Country,
                    Brand = x.Brand,
                    Engine = x.Engine,
                    Extras = x.Extras,
                    Model = x.Model,
                    Year = x.Year,
                    Price = x.Price,
                    Discount = x.Discount
                }).ToList();


            return View("Promotion", car);
        }
    }
}
