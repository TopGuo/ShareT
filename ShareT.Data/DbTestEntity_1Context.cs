using Microsoft.EntityFrameworkCore;
using ShareT.Data.DbTestEntity_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Data
{
    public class DbTestEntity_1Context:DefaultDbContext
    {
        public DbTestEntity_1Context(DbContextOptions<DbTestEntity_1Context> options) :base(options)
        {

        }


        public virtual DbSet<StudentInfo> StudentInfo { get; set; }
    }
}
