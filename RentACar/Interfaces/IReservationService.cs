using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentACar.Models;

namespace RentACar.Interfaces
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation GetReservation(string reservationId);
        Reservation AddReservation(Reservation newReservation);
        void DeleteReservation(string reservationId);
        void UpdateReservation(string reservationId, Reservation reservation);
    }
}
