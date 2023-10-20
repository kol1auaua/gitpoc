using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class CouplingOperation
    {
        public CouplingType Type { get; set; }

        public int VehicleId { get; set; }

        public string VehicleLicensePlate { get; set; }

        public int AssetId { get; set; }

        public string AssetLicensePlate { get; set; }

        public DateTime? Event { get; set; }

        public double? Distance { get; set; }

        public bool Success { get; set; }
    }
}
