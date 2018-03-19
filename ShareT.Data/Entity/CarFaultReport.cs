using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarFaultReport
    {
        public int Id { get; set; }
        public Guid CarsId { get; set; }
        public int? AccountId { get; set; }
        public Guid? CarUsageId { get; set; }
        public int? WarningGrade { get; set; }
        public string WarningAddress { get; set; }
        public string Location { get; set; }
        public bool? ProcessStatus { get; set; }
        public string ProcessResult { get; set; }
        public string ReportDetail { get; set; }
        public int FaultReportType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? DealTime { get; set; }

        public Account Account { get; set; }
        public CarUsage CarUsage { get; set; }
        public Cars Cars { get; set; }
    }
}
