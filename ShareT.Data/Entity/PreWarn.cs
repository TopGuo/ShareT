using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class PreWarn
    {
        public int Id { get; set; }
        public string Sn { get; set; }
        public int? Battery { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? HandleStatus { get; set; }
        public string OpenId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? WarnStatus { get; set; }
        public string PlateNumber { get; set; }
        public int? WarnLevel { get; set; }
    }
}
