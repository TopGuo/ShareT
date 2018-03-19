using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ApproveHistory
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public int ApproveType { get; set; }
        public string ApproveDetail { get; set; }
        public DateTime ApproveTime { get; set; }
        public int ApproveStatus { get; set; }
    }
}
