using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace RentACar.Interfaces
{
    public interface IDatabaseContext
    {
        IMongoDatabase GetDatabase();
        IMongoClient GetMongoClient();
    }
}
