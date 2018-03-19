using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class MaintLog
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string Handle { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? HandleTime { get; set; }
        public string OpenId { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public int? StartBattery { get; set; }
        public int? EndBattery { get; set; }
        public int? MaintStatus { get; set; }
        public int WarnId { get; set; }
        public int WashCost { get; set; }
        public int MoveCost { get; set; }
        public int ChargeCost { get; set; }
        public string ManAddr { get; set; }
    }
}
