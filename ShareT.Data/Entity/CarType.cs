using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class CarType
    {
        public CarType()
        {
            CarPriceRules = new HashSet<CarPriceRules>();
            Cars = new HashSet<Cars>();
        }

        public int Id { get; set; }
        public int BrandId { get; set; }
        public string CarModel { get; set; }
        public int CarLife { get; set; }
        public string CarPicture { get; set; }
        public string ShiftType { get; set; }
        public string Remark { get; set; }
        public string SeatStructure { get; set; }
        public DateTime CreateTime { get; set; }
        public string CarName { get; set; }
        public string CarIcon { get; set; }
        public string RedCarIcon { get; set; }

        public CarBrand Brand { get; set; }
        public ICollection<CarPriceRules> CarPriceRules { get; set; }
        public ICollection<Cars> Cars { get; set; }
    }
}
