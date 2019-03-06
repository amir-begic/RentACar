using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RentACar.Models
{
    public class Reservation
    {
        public ObjectId Id { get; set; }
        public string ReservationId { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        [BsonDateTimeOptions]
        public DateTime From { get; set; }
        [BsonDateTimeOptions]
        public DateTime To { get; set; }
        [BsonDateTimeOptions]
        public DateTime Expires { get; set; }
    }
}
