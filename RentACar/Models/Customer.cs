using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RentACar.Models
{
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        [BsonDateTimeOptions]
        public DateTime Birthdate { get; set; }
        public string CustomerId { get; set; }
        public bool Available { get; set; }
    }
}
