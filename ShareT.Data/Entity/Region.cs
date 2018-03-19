using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Region
    {
        public int Id { get; set; }
        public string RegionName { get; set; }
        public int? CityId { get; set; }
    }
}
