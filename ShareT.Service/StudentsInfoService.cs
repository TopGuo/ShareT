using ShareT.Data;
using ShareT.Data.DbTestEntity_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareT.Service
{
    public class StudentsInfoService:BaseService<DbTestEntity_1Context>
    {
        public StudentsInfoService(DbTestEntity_1Context dbTestEntity_1Context)
        {
            _context = dbTestEntity_1Context;
        }

        public StudentInfo GetOneStrdentInfo()
        {
            var query = base.Where<StudentInfo>(t => true).FirstOrDefault();

            return query;

        }
    }
}
