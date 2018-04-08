using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ShareT.Mongo.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Data.MongoEntity
{
    [MongoCollection("Demo")]
    class DemoModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }
}
