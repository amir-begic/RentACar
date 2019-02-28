using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Interfaces
{
    public interface ICarService
    {
        List<Car> GetCars();
        Car AddCar(Car car);
       // string GetSpecificCar(string licenseNumber);
    }
}
