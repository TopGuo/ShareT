using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class BespeakRecord
    {
        public int Id { get; set; }
        public int? MyCardId { get; set; }
        public int? MaintId { get; set; }
        public int? IsMove { get; set; }
        public Guid? CarUsageId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public string BespeakAddr { get; set; }
        public int? WaitTime { get; set; }
        public string ParkAddr { get; set; }
        public string FailReason { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UsedTime { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public int WayType { get; set; }
        public int CarType { get; set; }
        public int AccountId { get; set; }
        public int ReletDay { get; set; }
        public int ActivityAddDay { get; set; }
        public Guid OrderId { get; set; }
        public DateTime UseEndTime { get; set; }
        public decimal InsuranceCost { get; set; }
        public int RizuActivityAddDay { get; set; }
        public int XuzuActivityAddDay { get; set; }
        public string DailyRentalImg { get; set; }
    }
}
