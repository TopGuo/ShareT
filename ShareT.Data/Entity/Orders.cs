using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Orders
    {
        public Orders()
        {
            DepositHistory = new HashSet<DepositHistory>();
        }

        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public int OrderType { get; set; }
        public int BillType { get; set; }
        public int OrderStatus { get; set; }
        public int AccountId { get; set; }
        public int? TargetAccountId { get; set; }
        public bool HasInvoiced { get; set; }
        public int PayType { get; set; }
        public string TargetId { get; set; }
        public Guid? CarUsageId { get; set; }
        public Guid? PackageId { get; set; }
        public decimal PayAmount { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal? RealWalletAmount { get; set; }
        public decimal WalletAmount { get; set; }
        public decimal PackageAmount { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string AlipayId { get; set; }

        public Account Account { get; set; }
        public CarUsage CarUsage { get; set; }
        public Account TargetAccount { get; set; }
        public ICollection<DepositHistory> DepositHistory { get; set; }
    }
}
