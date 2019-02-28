using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace RentACar.Models
{
    public class Reservation
    {
        private string ReservationId { get; set; }
        private Car Car { get; set; }
        private Customer Customer { get; set; }
        [BsonDateTimeOptions]
        private DateTime From { get; set; }
        [BsonDateTimeOptions]
        private DateTime To { get; set; }
    }
}
