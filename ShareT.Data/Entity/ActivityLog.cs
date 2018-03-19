using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ActivityLog
    {
        public Guid Id { get; set; }
        public int? AccountId { get; set; }
        public int ActivityId { get; set; }
        public DateTime Createtime { get; set; }
        public string UserName { get; set; }
        public bool IsReceive { get; set; }
    }
}
