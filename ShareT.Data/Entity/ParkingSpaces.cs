using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ParkingSpaces
    {
        public Guid Id { get; set; }
        public int? ParkingAreaId { get; set; }
        public int? CityId { get; set; }
        public string PlateNumber { get; set; }
        public string SpaceNumber { get; set; }
        public int? ProvinceId { get; set; }
        public string SpacesName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Location { get; set; }
        public string BaiduMap { get; set; }

        public BaiduCity City { get; set; }
        public ParkingArea ParkingArea { get; set; }
        public BaiduCity Province { get; set; }
    }
}
