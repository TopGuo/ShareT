using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class NewsManagement
    {
        public Guid Id { get; set; }
        public int NewsType { get; set; }
        public string NewsContent { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
