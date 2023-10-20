using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehiclePosition
    {
        public int VehicleId { get; set; }

        public DateTime Timestamp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public char StatusGps { get; set; }
        public bool? Ignition { get; set; }
        public string Country { get; set; }

        public int? DriverId { get; set; }
        public short Driver1State { get; set; }
        public int? CoDriverId { get; set; }
        public short? Driver2State { get; set; }

        public string GPSTrackerSWVersion { get; set; }
        public int? HasCanBus { get; set; }
        public bool? HasTacho { get; set; }
        public bool? Has1MR { get; set; }
        public int? PlaceId { get; set; }
        public string PlaceName { get; set; }
    }
}
