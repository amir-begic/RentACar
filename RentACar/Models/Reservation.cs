using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class Reservation
    {
        private string ReservationKey { get; set; }
        private Car Car { get; set; }
        private Customer Customer { get; set; }
        private DateTime From { get; set; }
        private DateTime To { get; set; }
    }
}
