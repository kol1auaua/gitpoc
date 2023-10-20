using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleInfo
    {
        public int Total { get; set; }
        public double MileageGps { get; set; }
        public double MileageCanbus { get; set; }
        public string Name { get; set; }
    }
}
