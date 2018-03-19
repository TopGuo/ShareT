using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarAegis
    {
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public int HandleStatus { get; set; }
        public int BackstageUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string PicPath { get; set; }
        public string Description { get; set; }
        public DateTime? HandleTime { get; set; }
        public int? HandleUserId { get; set; }
        public string NowAddress { get; set; }
        public bool? Wash { get; set; }
        public bool? Charge { get; set; }
        public bool? MoveCar { get; set; }

        public BackstageUser BackstageUser { get; set; }
        public Cars Car { get; set; }
        public BackstageUser HandleUser { get; set; }
    }
}
