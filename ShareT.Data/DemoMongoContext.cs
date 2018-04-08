
using ShareT.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Data
{
    public class DemoMongoContext : MongoContext
    {
        public DemoMongoContext(MongoOptions options) : base(options)
        {
        }
    }
}
