using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class HolidayInfo
    {
        public Guid Id { get; set; }
        public string HolidayName { get; set; }
        public DateTime HolidayTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
