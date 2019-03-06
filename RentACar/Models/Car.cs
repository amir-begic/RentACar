using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace RentACar.Models
{
    public class Car
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public long LicenseNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        [BsonDateTimeOptions]
        public DateTime Manufactured { get; set; }
        public int PricePerDay { get; set; }
        public bool Available { get; set; }
    }
}
