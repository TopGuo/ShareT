using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CouponCode
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int? AccountId { get; set; }
        public string Code { get; set; }
        public bool IsUsed { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UsedTime { get; set; }
    }
}
