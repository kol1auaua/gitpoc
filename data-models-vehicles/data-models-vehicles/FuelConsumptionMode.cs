using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public enum FuelConsumptionMode
    {
        UseCanbusTotalFuelUsed = 1,
        CalculateFromFuelLevel = 2,
        UseFixedFuelConsumption = 3
    }
}
