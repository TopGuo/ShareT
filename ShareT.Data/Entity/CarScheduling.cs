using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarScheduling
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public int HandleStatus { get; set; }
        public int SchedulingType { get; set; }
        public int BackstageUserId { get; set; }
        public string NowAddress { get; set; }
        public string SchedulingAddress { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? SchedulingTime { get; set; }
        public int? SchedulingUserId { get; set; }

        public BackstageUser BackstageUser { get; set; }
        public Cars Car { get; set; }
        public BackstageUser SchedulingUser { get; set; }
    }
}
