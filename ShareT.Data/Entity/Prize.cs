using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Prize
    {
        public int Id { get; set; }
        public string PrizeName { get; set; }
        public int? PrizeType { get; set; }
        public decimal? PrizeMoney { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
