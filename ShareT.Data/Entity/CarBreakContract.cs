using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarBreakContract
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public Guid CarsId { get; set; }
        public Guid CarUsageId { get; set; }
        public DateTime BreakContractTime { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Guid? OrderId { get; set; }
        public string Complain { get; set; }
        public DateTime? ComplainTime { get; set; }
        public decimal Money { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int? UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public DateTime? UpdateTime { get; set; }

        public Account Account { get; set; }
        public CarUsage CarUsage { get; set; }
        public Cars Cars { get; set; }
    }
}
