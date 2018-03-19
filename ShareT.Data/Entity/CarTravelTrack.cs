using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarTravelTrack
    {
        public Guid Id { get; set; }
        public int? Status { get; set; }
        public Guid CarUsageId { get; set; }
        public int AccountId { get; set; }
        public string PlateNumber { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Mileage { get; set; }
        public int Battery { get; set; }
        public string Door { get; set; }
        public string Charging { get; set; }
        public int? Motor { get; set; }
        public int? Speed { get; set; }
        public string Compres { get; set; }
        public string Startup { get; set; }
        public string GearPos { get; set; }
        public string BackDoor { get; set; }
        public string BackDoorLocked { get; set; }
        public DateTime CreateTime { get; set; }

        public CarUsage CarUsage { get; set; }
    }
}
