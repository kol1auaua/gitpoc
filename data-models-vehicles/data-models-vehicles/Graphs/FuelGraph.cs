using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frotcom.Data.Models.Vehicles
{
    public class FuelGraph
    {
        public FuelGraph(string key, string description, string value1, string value2, string value3, double fuelTankCapacity)
        {
            this.Key = key;
            this.Description = description;
            this.Value1Description = value1;
            this.Value2Description = value2;
            this.Value3Description = value3;
            this.FuelTankCapacity = fuelTankCapacity;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public FuelData[] Data { get; set; }
        public string Value1Description { get; set; }
        public string Value2Description { get; set; }
        public string Value3Description { get; set; }
        public double FuelTankCapacity { get; set; }

        public FuelGraphTotal Totals { get; set; }
    }
}
