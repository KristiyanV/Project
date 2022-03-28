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
                 Year = x.Year

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
                Year = x.Year
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
                var isCreated = service.Create(car.Image, car.CarNumber, car.Brand, car.Model, car.Year, car.Engine, car.Color, car.Country, car.Extras);

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
                    Year = item.Year

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
                var updated = service.UpdateCar(createCar.Id, createCar.Image, createCar.CarNumber, createCar.Brand, createCar.Model, createCar.Year, createCar.Engine, createCar.Color, createCar.Country, createCar.Extras);
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
            var editModel = new CarCreateViewModel

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
            return View(editModel);
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
    }
}
