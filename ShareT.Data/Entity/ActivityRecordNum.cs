using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ActivityRecordNum
    {
        public int Id { get; set; }
        public int? WebNum { get; set; }
        public int? DownNum { get; set; }
        public int? CarUsageNum { get; set; }
    }
}
