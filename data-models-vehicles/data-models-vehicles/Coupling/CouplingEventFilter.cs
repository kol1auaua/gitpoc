using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class CouplingEventFilter
    {
        public int VehicleId { get; set; }

        public CouplingOption Option { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public VehicleAssetType VehicleOrAsset { get; set; }
    }
}
