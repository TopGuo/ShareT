using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class LotteryRecord
    {
        public int Id { get; set; }
        public Guid? LotteryId { get; set; }
        public int? AccountId { get; set; }
        public int? PrizeId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
