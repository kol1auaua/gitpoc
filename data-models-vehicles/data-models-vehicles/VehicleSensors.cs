using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleSensors
    {
        public int VehicleId { get; set; }
        public int CompanyId { get; set; }
        public string[] Sensors { get; set; }

        public string FuelLevel { get; set; }

        public string Wireless { get; set; }

        public string Inputs { get; set; }

        public string ANA1Name { get; set; }

        public string ANA2Name { get; set; }

        public string ANA3Name { get; set; }

        public string DIN1Name { get; set; }

        public string DIN2Name { get; set; }

        public string DIN3Name { get; set; }

        public string TP1Name { get; set; }

        public string TP2Name { get; set; }

        public string TP3Name { get; set; }
       
        public string TP4Name { get; set; }
        
        public string TP5Name { get; set; }
        
        public string TP6Name { get; set; }
       
        public string TP7Name { get; set; }
        
        public string TP8Name { get; set; }
        
        public string TP9Name { get; set; }
        
        public string TP10Name { get; set; }

        public string DOOR1Name { get; set; }

        public string DOOR2Name { get; set; }

        public string DOOR3Name { get; set; }

        public string SEAL1Name { get; set; }

        public string SEAL2Name { get; set; }

        public string SEAL3Name { get; set; }

        public string AnalogFuel { get; set; }

        public bool HasCanBus { get; set; }

        public bool HasAdBlueLevelSensor { get; set; }

        public bool HasWeightSensor
        {
            get
            {
                return HasGrossCombinationWeightSensor | HasFirstAxleWeightSensor | HasSecondAxleWeightSensor | HasTrailerWeightSensor;
            }

            private set { }
        }

        public bool HasGrossCombinationWeightSensor { get; set; }

        public bool HasFirstAxleWeightSensor { get; set; }

        public bool HasSecondAxleWeightSensor { get; set; }

        public bool HasTrailerWeightSensor { get; set; }

        public int? BatteryFullCapacity { get; set; }

        public int? EnergyType { get; set; }

        public bool HasExtendedCANBusCollection { get; set; }

        public bool HasAltitudeSensor { get; set; }
    }
}
