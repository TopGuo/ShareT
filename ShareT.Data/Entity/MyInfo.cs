using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class MyInfo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public string TargetId { get; set; }
        public int InfoType { get; set; }
        public int InfoStatus { get; set; }
        public bool IsViewed { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
