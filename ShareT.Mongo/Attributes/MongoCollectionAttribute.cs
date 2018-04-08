using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Mongo.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MongoCollectionAttribute : Attribute
    {
        public MongoCollectionAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
