using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ZhimaHistory
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string BizNo { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
