using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Mongo.Constants
{
    public class MongoOptionConstants
    {
        public const string Host = "HOST";
        public const string Port = "PORT";
        public const string Database = "DATABASE";

        public static readonly string[] Settings = new string[] {
            Host,
            Port,
            Database
        };
    }
}
