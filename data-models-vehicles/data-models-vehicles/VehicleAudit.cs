using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleAudit
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public double OdometerDifference { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
