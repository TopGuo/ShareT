using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class MyCoupon
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public int CouponType { get; set; }
        public decimal Amount { get; set; }
        public decimal? AvailableAmount { get; set; }
        public bool IsUsed { get; set; }
        public bool? IsExpired { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
