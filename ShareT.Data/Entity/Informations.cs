using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Informations
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
