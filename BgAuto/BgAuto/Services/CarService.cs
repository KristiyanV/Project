using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext context;

        public CarService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        public bool Create(string Image, string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras, decimal Price, decimal Discount)
        {
            var car = new Car
            {
                Image = Image,
                CarNumber = CarNumber,
                Brand = Brand,
                Model = Model,
                Year = Year,
                Engine = Engine,
                Color = Color,
                Country = Country,
                Extras = Extras,
                Price = Price,
                Discount = Discount
            };
            context.
                Cars.Add(car);
            return context.SaveChanges() != 0;
        }

        public Car GetCar(string id)
        {
            var car = context.Cars.Find(id);

            return car;
        }

        public List<Car> GetCars()
        {
            var cars = context.Cars.ToList();

            return cars;
        }

        public bool RemoveCar(string id)
        {
            var car = context.Cars.Find(id);

            if (car == null)
            {
                return false;
            }

            context.Cars.Remove(car);

            return context.SaveChanges() != 0;
        }
        public bool UpdateCar(string Id, string Image, string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras, decimal Price, decimal Discount)
        {
            var car = context.Cars.Find(Id);

            if (car == null)
            {
                return false;
            }
            car.Image = Image;
            car.CarNumber = CarNumber;
            car.Brand = Brand;
            car.Model = Model;
            car.Year = Year;
            car.Engine = Engine;
            car.Color = Color;
            car.Country = Country;
            car.Extras = Extras;
            car.Price = Price;

            context.Cars.Update(car);
            return context.SaveChanges() != 0;
        }
        public bool MakeDiscount(string id, int discount)
        {
            var product = GetCar(id);

            if (product == null)
            {
                return false;
            }

            product.Discount = product.Price * discount / 100;
            product.Price -= product.Discount;

            context.Cars.Update(product);

            return context.SaveChanges() != 0;
        }

        public bool RemoveDiscount(string id)
        {
            var product = GetCar(id);

            if (product == null)
            {
                return false;
            }

            product.Price += product.Discount;
            product.Discount = 0;

            context.Cars.Update(product);

            return context.SaveChanges() != 0;
        }
    }
}
