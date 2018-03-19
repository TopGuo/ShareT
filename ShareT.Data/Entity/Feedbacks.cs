using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Feedbacks
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public int? AccountId { get; set; }
        public string Contents { get; set; }
        public string Images { get; set; }
        public string HandlerMessage { get; set; }
        public bool IsHandled { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? HandledUserId { get; set; }

        public Account Account { get; set; }
        public BackstageUser HandledUser { get; set; }
    }
}
