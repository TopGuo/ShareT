using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class Cars
    {
        public Cars()
        {
            CarAegis = new HashSet<CarAegis>();
            CarBreakContract = new HashSet<CarBreakContract>();
            CarFaultReport = new HashSet<CarFaultReport>();
            CarIllegal = new HashSet<CarIllegal>();
            CarScheduling = new HashSet<CarScheduling>();
            CarTravelTrackLogs = new HashSet<CarTravelTrackLogs>();
            CarUsage = new HashSet<CarUsage>();
        }

        public Guid Id { get; set; }
        public string PlateNumber { get; set; }
        public int CarStatus { get; set; }
        public string Vin { get; set; }
        public string Sn { get; set; }
        public string CarCode { get; set; }
        public int MachineType { get; set; }
        public decimal? LifeMileage { get; set; }
        public bool? IsEnabled { get; set; }
        public bool InOperation { get; set; }
        public int Battery { get; set; }
        public decimal Mileage { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Location { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public int CarBrandId { get; set; }
        public int ParkingAreaId { get; set; }
        public int CarTypeId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int UsedTimes { get; set; }
        public decimal IncomeAmount { get; set; }
        public DateTime? LastUsedTime { get; set; }
        public DateTime? AnnualInspectionTime { get; set; }
        public DateTime? AnnualInspectionEndTime { get; set; }
        public DateTime? InsuranceTime { get; set; }
        public DateTime? InsuranceEndTime { get; set; }
        public int? CarAge { get; set; }
        public string EngineModel { get; set; }
        public string LastUsageImage { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public CarPriceRules C { get; set; }
        public CarBrand CarBrand { get; set; }
        public CarType CarType { get; set; }
        public BaiduCity City { get; set; }
        public ParkingArea ParkingArea { get; set; }
        public BaiduCity Province { get; set; }
        public ICollection<CarAegis> CarAegis { get; set; }
        public ICollection<CarBreakContract> CarBreakContract { get; set; }
        public ICollection<CarFaultReport> CarFaultReport { get; set; }
        public ICollection<CarIllegal> CarIllegal { get; set; }
        public ICollection<CarScheduling> CarScheduling { get; set; }
        public ICollection<CarTravelTrackLogs> CarTravelTrackLogs { get; set; }
        public ICollection<CarUsage> CarUsage { get; set; }
    }
}
