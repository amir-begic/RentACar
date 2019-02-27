using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            return _carService.GetCars();
        }
        

        [HttpPost]
        public ActionResult<string> Post([FromBody] Car newCar)
        {
            return _carService.AddCar(newCar).ToString();
        }
    }
}