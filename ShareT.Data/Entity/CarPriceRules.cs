using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarPriceRules
    {
        public CarPriceRules()
        {
            Cars = new HashSet<Cars>();
        }

        public Guid Id { get; set; }
        public int CityId { get; set; }
        public int CarTypeId { get; set; }
        public int ProvinceId { get; set; }
        public int? CarBrandId { get; set; }
        public decimal PerMinutesCost { get; set; }
        public decimal PerKilometerCost { get; set; }
        public decimal PerDayCost { get; set; }
        public decimal PerMonthCost { get; set; }
        public decimal PerMinutesNightCost { get; set; }
        public decimal PerKilometerNightCost { get; set; }
        public DateTime CreateTime { get; set; }

        public CarBrand CarBrand { get; set; }
        public CarType CarType { get; set; }
        public BaiduCity City { get; set; }
        public BaiduCity Province { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
