using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_reservationService.GetReservations());
        }

        [HttpGet("{reservationId}")]
        public JsonResult Get(string reservationId)
        {
            return new JsonResult(_reservationService.GetReservation(reservationId));
        }

        [HttpPost]
        public JsonResult Post([FromBody]Reservation newReservation)
        {
            return new JsonResult(_reservationService.AddReservation(newReservation));
        }

        [HttpPut("{reservationId}")]
        public void Put(string reservationId, [FromBody]Reservation updateReservation)
        {
            _reservationService.UpdateReservation(reservationId, updateReservation);
        }

        [HttpDelete("{reservationId}")]
        public void Delete(string reservationId)
        {
            _reservationService.DeleteReservation(reservationId);
        }
    }
}