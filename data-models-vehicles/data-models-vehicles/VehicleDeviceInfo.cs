using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleDeviceInfo
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string IMEI { get; set; }
        public bool HasOBD2 { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
