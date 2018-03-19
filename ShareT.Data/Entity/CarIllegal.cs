using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarIllegal
    {
        public Guid Id { get; set; }
        public int? AccountId { get; set; }
        public Guid? CarUsageId { get; set; }
        public Guid CarsId { get; set; }
        public string PlateNumber { get; set; }
        public int ReduceScore { get; set; }
        public string Address { get; set; }
        public string BreakRule { get; set; }
        public int Penalty { get; set; }
        public bool IsHandled { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime SystemTime { get; set; }

        public Account Account { get; set; }
        public CarUsage CarUsage { get; set; }
        public Cars Cars { get; set; }
    }
}
