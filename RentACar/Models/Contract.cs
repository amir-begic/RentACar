using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RentACar.Models
{
    public class Contract
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ContractId { get; set; }
        public Reservation Reservation { get; set; }
        public double Price { get; set; }
        [BsonDateTimeOptions]
        public DateTime DueDate { get; set; }
    }
}
