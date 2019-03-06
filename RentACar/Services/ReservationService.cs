using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using RentACar.Interfaces;
using RentACar.Models;

namespace RentACar.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IDatabaseContext _databaseContext;

        public ReservationService(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Reservation AddReservation(Reservation reservation)
        {
            var db = _databaseContext.GetDatabase();

            var _reservations = db.GetCollection<Reservation>("Reservations");
            try
            {
                reservation.Id = new ObjectId(reservation.Id.ToString());
                _reservations.InsertOneAsync(reservation);
                return reservation;
            }
            catch
            {
                return new Reservation();
            }
        }

        public void DeleteReservation(string reservationId)
        {
            var db = _databaseContext.GetDatabase();

            var _reservations = db.GetCollection<Reservation>("Reservations");

            _reservations.DeleteOneAsync(r => r.ReservationId == reservationId);
        }

        public Reservation GetReservation(string reservationId) 
        {
        
            var db = _databaseContext.GetDatabase();

            var _reservations = db.GetCollection<Reservation>("Reservations");

            return _reservations.Find(r => r.ReservationId == reservationId).Single();
            
        }

        public List<Reservation> GetReservations()
        {
            var db = _databaseContext.GetDatabase();

            var _reservations = db.GetCollection<Reservation>("Reservations");

            return _reservations.Find(reservation => true).ToList();
        }

        public void UpdateReservation(string reservationId, Reservation updatedReservation)
        {
            var db = _databaseContext.GetDatabase();

            var _reservations = db.GetCollection<Reservation>("Reservations");

            _reservations.ReplaceOneAsync(customer => customer.ReservationId == reservationId, updatedReservation);
        }
    }
}
