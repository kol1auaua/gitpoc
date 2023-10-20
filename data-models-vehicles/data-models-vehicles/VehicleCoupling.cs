using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleCoupling
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int CoupledId { get; set; }
        public string CoupledLicensePlate { get; set; }

    }
}
