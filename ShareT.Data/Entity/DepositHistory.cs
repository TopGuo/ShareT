using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class DepositHistory
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime? PayTime { get; set; }
        public decimal PayAmount { get; set; }
        public DateTime? RefundTime { get; set; }
        public decimal? RefundAmount { get; set; }
        public string RefundRemark { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ApplyRefundTime { get; set; }
        public int DepositStatus { get; set; }
        public decimal IllegalMoney { get; set; }
        public decimal CarDamageMoney { get; set; }

        public Account Account { get; set; }
        public Orders Order { get; set; }
    }
}
