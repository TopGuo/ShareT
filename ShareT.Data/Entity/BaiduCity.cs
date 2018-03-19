using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class BaiduCity
    {
        public BaiduCity()
        {
            CarPriceRulesCity = new HashSet<CarPriceRules>();
            CarPriceRulesProvince = new HashSet<CarPriceRules>();
            CarsCity = new HashSet<Cars>();
            CarsProvince = new HashSet<Cars>();
            ParkingAreaCity = new HashSet<ParkingArea>();
            ParkingAreaProvince = new HashSet<ParkingArea>();
            ParkingSpacesCity = new HashSet<ParkingSpaces>();
            ParkingSpacesProvince = new HashSet<ParkingSpaces>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool IsEnabled { get; set; }
        public string CityCode { get; set; }
        public int VinLength { get; set; }

        public ICollection<CarPriceRules> CarPriceRulesCity { get; set; }
        public ICollection<CarPriceRules> CarPriceRulesProvince { get; set; }
        public ICollection<Cars> CarsCity { get; set; }
        public ICollection<Cars> CarsProvince { get; set; }
        public ICollection<ParkingArea> ParkingAreaCity { get; set; }
        public ICollection<ParkingArea> ParkingAreaProvince { get; set; }
        public ICollection<ParkingSpaces> ParkingSpacesCity { get; set; }
        public ICollection<ParkingSpaces> ParkingSpacesProvince { get; set; }
    }
}
