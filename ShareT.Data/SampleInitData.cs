using ShareT.Data.DbTestEntity_1;
using ShareT.Data.DbTestEntity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareT.Data
{
    public class SampleInitData
    {
        #region 添加种子学生信息
        

        public static void InitEf1Data(DbTestEntity_1Context context)
        {
            if (context.StudentInfo.Any())
            {
                return;
            }
            
            var StudentInfos = new[]
            {
                new StudentInfo {Name = "龙傲天", Age=12},
                new StudentInfo {Name = "龙傲天", Age=12},
                new StudentInfo {Name = "龙傲天", Age=12},
                new StudentInfo {Name = "龙傲天", Age=12},
            };
            foreach (var item in StudentInfos)
            {
                context.Add(item);
            }
            context.SaveChanges();

        }

        public static void InitEf2Data(DbTestEntity_2Context context)
        {
            if (context.PersonInfo.Any())
            {
                return;
            }
            var PersonInfos = new[]
            {
                new PersonInfo {Name = "学生", Age=12},
                new PersonInfo {Name = "学生", Age=12},
                new PersonInfo {Name = "学生", Age=12},
                new PersonInfo {Name = "学生", Age=12},
            };
            foreach (var item in PersonInfos)
            {
                context.Add(item);
            }
            context.SaveChanges();

        }


        #endregion

    }
}
