using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public int UsedAmount { get; set; }
        public bool IsReuse { get; set; }
        public string ReuseCode { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Image { get; set; }
        public int PrizeType { get; set; }
        public string PrizeDetail { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
