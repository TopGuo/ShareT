using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class SystemRolePermission
    {
        public int RoleId { get; set; }
        public Guid ActionId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
