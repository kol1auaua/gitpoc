using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleFuelEvents
    {
        private DateTime from { get; set; }
        private DateTime to { get; set; }

        public VehicleFuelEvents(int vehicleId, DateTime dTIni, DateTime dTEnd, double fuelIni, double fuelEnd, DateTime from, DateTime to)
        {
            this.from = from;
            this.to = to;
            VehicleId = vehicleId;
            DTIni = dTIni;
            DTEnd = dTEnd;
            FuelIni = fuelIni;
            FuelEnd = fuelEnd;
        }

        public VehicleFuelEvents(int id, int vehicleId, DateTime dTIni, DateTime dTEnd, double fuelIni, double fuelEnd, DateTime from, DateTime to) : this(vehicleId, dTIni, dTEnd, fuelIni, fuelEnd, from, to)
        {
            Id = id;
        }

        public int Id { get; private set; }
        public int VehicleId { get; private set; }
        public DateTime DTIni { get; private set; }
        public DateTime DTEnd { get; private set; }
        public double FuelIni { get; private set; }
        public double FuelEnd { get; private set; }

        public double Refuel => (FuelEnd > FuelIni) && (DTIni >= from && DTIni <= to) ? (FuelEnd - FuelIni) : 0;
        public double Drainage => (FuelIni > FuelEnd) ? (FuelIni - FuelEnd) : 0;

    }
}
