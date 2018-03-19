using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class MaintLogFresh
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? HandleTime { get; set; }
        public string OpenId { get; set; }
        public string StartAddress { get; set; }
        public string EndAddress { get; set; }
        public int? StartBattery { get; set; }
        public int? EndBattery { get; set; }
        public bool? MaintStatus { get; set; }
        public int? WarnId { get; set; }
        public string ManAddr { get; set; }
        public string Wash { get; set; }
        public string Move { get; set; }
        public string Charge { get; set; }
        public string CheckCar { get; set; }
        public string HandleAddr { get; set; }
    }
}
