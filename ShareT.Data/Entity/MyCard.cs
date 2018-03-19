using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class MyCard
    {
        public int Id { get; set; }
        public Guid? CardId { get; set; }
        public int? AccountId { get; set; }
        public int? UsageCount { get; set; }
        public bool? IsExpired { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int PreCounts { get; set; }
    }
}
