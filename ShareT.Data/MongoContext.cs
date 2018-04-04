using Microsoft.EntityFrameworkCore;
using ShareT.Data.MongoEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Data
{
    public class MongoContext: DefaultDbContext
    {
        public MongoContext(DbContextOptions<MongoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                //optionsBuilder.UseSqlServer(DbRepository.Configuration.GetConnectionString("DbConnection"));
            }
        }


        public virtual DbSet<Product> Product { get; set; }

    }
}
