using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class SystemLogsSms
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string Ip { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }
        public bool IsUsed { get; set; }
        public string Contents { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
