using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Mongo
{
    public class MongoContext
    {
        private IMongoDatabase _database;

        public MongoContext(MongoOptions options)
        {
            _database = new MongoClient(options.MongoClientSettings).GetDatabase(options.Database);
        }

        public IMongoDatabase Database => _database;
    }
    
}
