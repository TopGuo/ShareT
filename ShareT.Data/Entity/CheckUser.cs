using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CheckUser
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string CarType { get; set; }
        public DateTime? CertTime { get; set; }
        public DateTime? ValidTime { get; set; }
        public string FileNo { get; set; }
        public int? ScoreDeduct { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public byte? CheckStatus { get; set; }
        public int? AccountNation { get; set; }
    }
}
