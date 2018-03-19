using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Advertising
    {
        public Guid Id { get; set; }
        public int AdLocation { get; set; }
        public string AdName { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string AdPic { get; set; }
        public string AdDescription { get; set; }
        public int? IsEnable { get; set; }
    }
}
