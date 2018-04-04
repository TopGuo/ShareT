using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.MongoDBCon.Model
{
    public class DataAccess
    {
        MongoClient _client;

        IMongoDatabase _db;

        public DataAccess()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            
            _db = _client.GetDatabase("EmployeeDB");
        }

        public IEnumerable<Product> GetProducts()
        {
            return _db.GetCollection<Product>("Products").Find(t=>true).ToEnumerable();
        }


        public Product GetProduct(ObjectId id)
        {
            var filter = Builders<Product>.Filter.Eq(t=>t.Id, id);
            return _db.GetCollection<Product>("Products").Find(filter).FirstOrDefault();
        }

        public Product Create(Product p)
        {
            _db.GetCollection<Product>("Products").InsertOne(p);
            return p;
        }

        public void Update(ObjectId id, Product p)
        {
            p.Id = id;
            var res = Builders<Product>.Filter.Eq(pd => pd.Id, id);
           // _db.GetCollection<Product>("Products").UpdateOne(res);
        }
        public void Remove(ObjectId id)
        {
            var res = Builders<Product>.Filter.Eq(e => e.Id, id);
            var operation = _db.GetCollection<Product>("Products").DeleteOne(res);
        }
    }
}
