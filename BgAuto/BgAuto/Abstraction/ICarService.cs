﻿using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface ICarService
    {
        public bool Create(string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras);
        public List<Car> GetCars();
        public Car GetCar(string Id);
        public bool RemoveCar(string Id);
        public bool UpdateC(string Id, string CarNumber, string Brand, string Model, int Year, string Engine, string Color, string Country, string Extras);
    }
}