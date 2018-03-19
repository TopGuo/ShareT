using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarUsage
    {
        public CarUsage()
        {
            CarBreakContract = new HashSet<CarBreakContract>();
            CarFaultReport = new HashSet<CarFaultReport>();
            CarIllegal = new HashSet<CarIllegal>();
            CarTravelTrack = new HashSet<CarTravelTrack>();
            Orders = new HashSet<Orders>();
        }

        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public int CarUsageStatus { get; set; }
        public int AccountId { get; set; }
        public int BillType { get; set; }
        public string BreakRulesDetail { get; set; }
        public bool? HasBreakRules { get; set; }
        public int? FromParkingAreaId { get; set; }
        public int? ToParkingAreaId { get; set; }
        public bool IsAdvanceBilling { get; set; }
        public bool IsInsurance { get; set; }
        public decimal MinutesCost { get; set; }
        public decimal MileageCost { get; set; }
        public decimal DayCost { get; set; }
        public string PriceRules { get; set; }
        public string CostDetails { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal? Mileage { get; set; }
        public decimal StartMileage { get; set; }
        public decimal EndMileage { get; set; }
        public int TotalMinutes { get; set; }
        public string Remark { get; set; }
        public string ExternalPicture { get; set; }
        public string InsidePicture { get; set; }
        public DateTime CreateTime { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int? AdminId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string OtherImage { get; set; }
        public int ParkingStatus { get; set; }
        public int IsRedCarTravel { get; set; }
        public DateTime? EndTimeFlag { get; set; }
        public decimal EndMileageFlag { get; set; }

        public Account Account { get; set; }
        public BackstageUser Admin { get; set; }
        public Cars Car { get; set; }
        public ParkingArea FromParkingArea { get; set; }
        public ParkingArea ToParkingArea { get; set; }
        public ICollection<CarBreakContract> CarBreakContract { get; set; }
        public ICollection<CarFaultReport> CarFaultReport { get; set; }
        public ICollection<CarIllegal> CarIllegal { get; set; }
        public ICollection<CarTravelTrack> CarTravelTrack { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
