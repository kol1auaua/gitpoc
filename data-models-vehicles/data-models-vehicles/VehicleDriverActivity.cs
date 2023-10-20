using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleDriverActivity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int DriverId { get; set; }
        public DriverActivityType DriverActivityType { get; set; }
        public string DriverActivityName { get; set; }
    }
}
