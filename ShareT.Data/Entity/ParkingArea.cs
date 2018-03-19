using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ParkingArea
    {
        public ParkingArea()
        {
            CarUsageFromParkingArea = new HashSet<CarUsage>();
            CarUsageToParkingArea = new HashSet<CarUsage>();
            Cars = new HashSet<Cars>();
            ParkingSpaces = new HashSet<ParkingSpaces>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Location { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int? ParkingAmount { get; set; }
        public bool? IsEnabled { get; set; }
        public string BusinessTime { get; set; }
        public string ParkingCost { get; set; }
        public int? ProvinceId { get; set; }
        public string BaiduMap { get; set; }
        public string MapRangeString { get; set; }

        public BaiduCity City { get; set; }
        public BaiduCity Province { get; set; }
        public ICollection<CarUsage> CarUsageFromParkingArea { get; set; }
        public ICollection<CarUsage> CarUsageToParkingArea { get; set; }
        public ICollection<Cars> Cars { get; set; }
        public ICollection<ParkingSpaces> ParkingSpaces { get; set; }
    }
}
