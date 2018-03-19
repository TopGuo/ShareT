using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class SystemSettings
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
