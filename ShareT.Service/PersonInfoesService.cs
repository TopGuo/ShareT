using ShareT.Data;
using ShareT.Data.DbTestEntity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareT.Service
{
    public class PersonInfoesService : BaseService<DbTestEntity_2Context>
    {
        public PersonInfoesService(DbTestEntity_2Context dbTestEntity_2Context)
        {
            _context = dbTestEntity_2Context;
        }

        //将controller 里的逻辑转移到 service

        public IQueryable GetAllPersonInfo()
        {
            var query = base.Where<PersonInfo>(t=>true);

            return query;

        }

    }
}
