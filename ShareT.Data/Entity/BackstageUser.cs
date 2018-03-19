using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class BackstageUser
    {
        public BackstageUser()
        {
            CarAegisBackstageUser = new HashSet<CarAegis>();
            CarAegisHandleUser = new HashSet<CarAegis>();
            CarSchedulingBackstageUser = new HashSet<CarScheduling>();
            CarSchedulingSchedulingUser = new HashSet<CarScheduling>();
            CarUsage = new HashSet<CarUsage>();
            Feedbacks = new HashSet<Feedbacks>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public int AccountType { get; set; }
        public int AccountStatus { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public int? SourceType { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string LastLoginIp { get; set; }
        public string OpenId { get; set; }
        public string IdCard { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public SystemRoles Role { get; set; }
        public ICollection<CarAegis> CarAegisBackstageUser { get; set; }
        public ICollection<CarAegis> CarAegisHandleUser { get; set; }
        public ICollection<CarScheduling> CarSchedulingBackstageUser { get; set; }
        public ICollection<CarScheduling> CarSchedulingSchedulingUser { get; set; }
        public ICollection<CarUsage> CarUsage { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }
    }
}
