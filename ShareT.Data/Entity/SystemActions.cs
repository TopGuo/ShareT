using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class SystemActions
    {
        public Guid ActionId { get; set; }
        public string ActionName { get; set; }
        public string ActionDescription { get; set; }
        public string Url { get; set; }
        public int? Orders { get; set; }
        public Guid? ParentAction { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
