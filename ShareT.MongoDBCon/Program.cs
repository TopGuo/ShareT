using MongoDB.Bson;
using MongoDB.Driver;
using ShareT.MongoDBCon.Model;
using System;
using System.Linq;

namespace ShareT.MongoDBCon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 添加简单的mongodb demo
            //// 使用连接字符串连接  
            //var client = new MongoClient("mongodb://localhost:27017");

            //// 制定多个地址和端口，让程序自动选择一个进行连接。  
            ////var client = new MongoClient("mongodb://localhost:27017,localhost:27018,localhost:27019");

            //var database = client.GetDatabase("foo");

            //var collection = database.GetCollection<BsonDocument>("bar");

            var document = new BsonDocument
            {
                { "name", "MongoDB" },
                { "type", "Database" },
                { "count", 1 },
                { "info", new BsonDocument
                {
                    { "x", 203 },
                    { "y", 102 }
                }}
            };
            //collection.InsertOne(document);

            //var documents = Enumerable.Range(0, 100).Select(i => new BsonDocument("counter", i));

            //collection.InsertMany(documents);

            //var count = collection.Count(new BsonDocument());  //产生一个空BsonDocument的过滤器，指对该类型的文档进行计数 
            #endregion

            #region mongoDb简单查询

            //var client = new MongoClient("mongodb://localhost:27017");

            //// 制定多个地址和端口，让程序自动选择一个进行连接。  
            ////var client = new MongoClient("mongodb://localhost:27017,localhost:27018,localhost:27019");
            //var database = client.GetDatabase("foo");

            //var collection = database.GetCollection<BsonDocument>("bar");
            //// 获取默认一条数据
            //var document = collection.Find(new BsonDocument()).FirstOrDefault();
            //Console.WriteLine(document.ToString());

            //// var document2 = await collection.Find(new BsonDocument()).FirstOrDefaultAsync();
            //// Console.WriteLine(document2.ToString());

            //// 获取所有数据

            //var documents = collection.Find(new BsonDocument()).ToList();

            //Console.WriteLine(documents);

            //var cursor = collection.Find(new BsonDocument()).ToCursor();
            //foreach (var item in cursor.ToEnumerable())
            //{
            //    Console.WriteLine(item);
            //}


            //var filter = Builders<BsonDocument>.Filter.Eq("counter", 71);

            //Console.WriteLine(filter);

            ////我们在Find()后，调用了Fist方法，所以获取的只是一条数据，如果不调用该函数，则获取的是一个数据集合
            //var document3 = collection.Find(filter).First();

            //Console.WriteLine(document3);

            ////获取i>50的数据，我们先设计一个这样的筛选器  大于Gt
            //var filter2 = Builders<BsonDocument>.Filter.Gt("counter", 50);
            //var cursor2 = collection.Find(filter2).ToCursor();
            //foreach (var document2 in cursor2.ToEnumerable())
            //{
            //    Console.WriteLine(document2);
            //}

            ////获取50 < i <= 100，我们可以设计一个这样的筛选器  小于 Lte
            //var filterBuilder = Builders<BsonDocument>.Filter;
            //var filter3 = filterBuilder.Gt("counter", 50) & filterBuilder.Lte("counter", 100);


            //var cursor4 = collection.Find(filter3).ToCursor();
            //foreach (var document4 in cursor4.ToEnumerable())
            //{
            //    Console.WriteLine(document4);
            //}
            #endregion


            #region 测试封装方法里的mongodb
            //DataAccess dataAccess = new DataAccess();

            ////查一下
            //var query= dataAccess.GetProducts();
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //var p = new Product() {
            //    ProductId=465,
            //    ProductName="郭东生",
            //    Price=456,
            //    Category="999",
            //};
            ////加一条数据
            //var products= dataAccess.Create(p);

            //Console.WriteLine(products);

            #endregion


            #region 测试冬瓜的baserepository
            //IMongoDatabase _db;
            //MongoClient _client;
            //_client = new MongoClient("mongodb://localhost:27017");
            //_db = _client.GetDatabase("EmployeeDB");
            //MongoHelper<Product> mongoHelper = new MongoHelper<Product>(_db,"Products");

            #endregion


            #region 测试明mongodb
            string con = "mongodb://localhost:27017";
            string db = "EmployeeDB";
            MongoDBHelper mongoDBHelper = new MongoDBHelper(con,db);
            var data= mongoDBHelper.GetDocumentsByFilter<Product>("Products", "ProductId", "1");

            foreach (var item in data)
            {
                Console.WriteLine(item.ProductName);
            }


            #endregion

        }
    }
}
