using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Common
{
    public class MvcHelper
    {
        public MvcHelper()
        {

        }
        public void InitConfiguration(IConfiguration config)
        {
            _config = config;
        }
        static IConfiguration _config;

        public static string DbConnection
        {
            get
            {
                string connection = _config.GetConnectionString("DbConnection");
                if (string.IsNullOrEmpty(connection))
                {
                    throw new Exception(" empty connection string");
                }
                return connection;
            }
        }


        public static string DbConnectionT1
        {
            get
            {
                string connection = _config.GetConnectionString("DbContextion_T1");
                if (string.IsNullOrEmpty(connection))
                {
                    throw new Exception(" empty connection string");
                }
                return connection;
            }
        }

        public static string DbConnectionT2
        {
            get
            {
                string connection = _config.GetConnectionString("DbContextion_T2");
                if (string.IsNullOrEmpty(connection))
                {
                    throw new Exception(" empty connection string");
                }
                return connection;
            }
        }

        public static string DbConnectionMongo
        {
            get
            {
                string connection = _config.GetConnectionString("DbContextion_Mongo");
                if (string.IsNullOrEmpty(connection))
                {
                    throw new Exception(" empty connection string");
                }
                return connection;
            }
        }
    }
}
