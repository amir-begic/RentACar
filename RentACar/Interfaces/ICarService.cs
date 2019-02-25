using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACar.Models;

namespace RentACar.Interfaces
{
    interface ICarService
    {
        IReadOnlyCollection<Car> GetCars();
    }
}
