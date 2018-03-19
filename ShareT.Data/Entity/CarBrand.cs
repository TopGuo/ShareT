using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarBrand
    {
        public CarBrand()
        {
            CarPriceRules = new HashSet<CarPriceRules>();
            CarType = new HashSet<CarType>();
            Cars = new HashSet<Cars>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string BrandCode { get; set; }

        public ICollection<CarPriceRules> CarPriceRules { get; set; }
        public ICollection<CarType> CarType { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
