using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface ICarService
    {
        public bool Create(string Image, string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras, decimal Price, decimal Discount);
        public List<Car> GetCars();
        public Car GetCar(string Id);
        public bool RemoveCar(string Id);
        public bool UpdateCar(string Id, string Image, string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras, decimal Price, decimal Discount);
        public bool MakeDiscount(string id, int discount);
        public bool RemoveDiscount(string id);
    }
}
