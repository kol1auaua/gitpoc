using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles.Graphs
{
    public class BatteryChargeGraphTotal
    {
        public double Distance { get; set; }
        public int DrivingTime { get; set; }
        public double EnergyConsumption { get; set; }
        public double AvgConsumptionPer100Km { get; set; }
        public double AvgConsumptionPerHour { get; set; }
    }
}
