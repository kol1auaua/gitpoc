using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleCANBusReliability
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public bool? OdometerOk { get; set; }
        public bool? TotalFuelOk { get; set; }
        public bool? EngineHoursOk { get; set; }
    }
}
