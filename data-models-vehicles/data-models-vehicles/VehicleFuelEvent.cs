using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleFuelEvent
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public double FuelDifference { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
