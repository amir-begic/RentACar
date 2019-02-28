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

        // GET api/cars
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_carService.GetCars());
        }
        

        [HttpPost]
        public ActionResult<string> Post([FromBody] Car newCar)
        {
            return new JsonResult(_carService.AddCar(newCar));
        }
    }
}