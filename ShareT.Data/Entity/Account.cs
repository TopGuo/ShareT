using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Account
    {
        public Account()
        {
            ApplyInvoice = new HashSet<ApplyInvoice>();
            CarBreakContract = new HashSet<CarBreakContract>();
            CarFaultReport = new HashSet<CarFaultReport>();
            CarIllegal = new HashSet<CarIllegal>();
            CarUsage = new HashSet<CarUsage>();
            DepositHistory = new HashSet<DepositHistory>();
            Feedbacks = new HashSet<Feedbacks>();
            OrdersAccount = new HashSet<Orders>();
            OrdersTargetAccount = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int AccountType { get; set; }
        public int AccountStatus { get; set; }
        public decimal Deposit { get; set; }
        public decimal DepositSetting { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string HeadPicture { get; set; }
        public string IdCard { get; set; }
        public string IdCardPicture { get; set; }
        public string HandheldIdCardPicture { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string DriversLicenseOriginalPicture { get; set; }
        public string DriversLicenseCopyPicture { get; set; }
        public DateTime? DriversLicenseStartTime { get; set; }
        public DateTime? DriversLicenseEndTime { get; set; }
        public string DriversLicenseType { get; set; }
        public string NickName { get; set; }
        public int SourceType { get; set; }
        public int Gender { get; set; }
        public decimal RechargeAmount { get; set; }
        public decimal? RechargeTotal { get; set; }
        public decimal RechargeRate { get; set; }
        public string Email { get; set; }
        public decimal AvailableInvoice { get; set; }
        public int IllegalAmount { get; set; }
        public int? TryTimes { get; set; }
        public int UsedCarAmount { get; set; }
        public DateTime? ApproveTime { get; set; }
        public int? RecommendAccountId { get; set; }
        public DateTime? LastUseCarTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string LastLoginIp { get; set; }
        public bool IsDisabled { get; set; }
        public decimal UseCarCost { get; set; }
        public int? ApproveModel { get; set; }
        public string Remarks { get; set; }
        public string OpenId { get; set; }
        public string Unionid { get; set; }
        public string WxNickname { get; set; }
        public string Headimgurl { get; set; }
        public decimal RedPacketRemainder { get; set; }

        public ICollection<ApplyInvoice> ApplyInvoice { get; set; }
        public ICollection<CarBreakContract> CarBreakContract { get; set; }
        public ICollection<CarFaultReport> CarFaultReport { get; set; }
        public ICollection<CarIllegal> CarIllegal { get; set; }
        public ICollection<CarUsage> CarUsage { get; set; }
        public ICollection<DepositHistory> DepositHistory { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }
        public ICollection<Orders> OrdersAccount { get; set; }
        public ICollection<Orders> OrdersTargetAccount { get; set; }
    }
}
