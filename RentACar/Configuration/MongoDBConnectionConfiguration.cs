using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Configuration
{
    public class MongoDbConnectionConfiguration
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
