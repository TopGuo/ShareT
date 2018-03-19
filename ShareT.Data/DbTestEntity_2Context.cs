using Microsoft.EntityFrameworkCore;
using ShareT.Data.DbTestEntity_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Data
{
    public class DbTestEntity_2Context:DefaultDbContext
    {
        public DbTestEntity_2Context(DbContextOptions<DbTestEntity_2Context>options):base(options)
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

        public virtual DbSet<PersonInfo> PersonInfo { get; set; }
    }
}
