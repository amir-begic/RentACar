using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using RentACar.Configuration;
using RentACar.Interfaces;

namespace RentACar.Services
{
    public class DatabaseContext : IDatabaseContext
    {

        private readonly IMongoDatabase _database;
        private readonly IMongoClient _mongoClient;

        public DatabaseContext(IOptions<MongoDbConnectionConfiguration> config)
        {
            _mongoClient = new MongoClient(config.Value.ConnectionString);
            _database = _mongoClient.GetDatabase(config.Value.Database);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }

        public IMongoClient GetMongoClient()
        {
            return _mongoClient;
        }

    }
}
