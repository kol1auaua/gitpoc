using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class CouplingEvent
    {
        public int VehicleId { get; set; }
        public string VehicleLicensePlate { get; set; }
        public int AssetId { get; set; }
        public string AssetLicensePlate { get; set; }
        public DateTime? Timestamp { get; set; }
        public CouplingType Type { get; set; }
        public int? PlaceId { get; set; }
        public string Address { get; set; }
        public string User { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
