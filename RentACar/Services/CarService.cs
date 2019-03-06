using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Services
{
    public class CarService : ICarService
    {
        private readonly IDatabaseContext _databaseContext;

        public CarService(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Car> GetCars()
        {
            var db = _databaseContext.GetDatabase();

            var _cars = db.GetCollection<Car>("Cars");

            return _cars.Find(car => true).ToList();
        }

        public Car AddCar(Car car)
        {
            var db = _databaseContext.GetDatabase();

            var _cars = db.GetCollection<Car>("Cars");
            try
            {
                _cars.InsertOneAsync(car);
                return car;

            }
            catch
            {
                return new Car();
            }
        }

        public Car GetSpecificCar()
        {


            return new Car();
        }
    }
}
