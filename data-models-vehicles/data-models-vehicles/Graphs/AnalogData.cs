using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class AnalogData
    {
        public AnalogData(DateTime timestamp, double value, bool ignition)
        {
            this.Timestamp = timestamp;
            this.Value = value;
            this.Ignition = ignition;
        }

        public DateTime Timestamp { get; set; }

        public double Value { get; set; }

        public bool Ignition { get; set; }

        public static AnalogData[] OptimizeData(AnalogData[] data)
        {
            List<AnalogData> items = new List<AnalogData>();

            if (data.Length > 2)
            {
                for (int i = 1; i < data.Length - 1; i++)
                {
                    if(
                        VehicleGraphs.IsDuplicated(data[i - 1].Value, data[i].Value, (i < data.Length - 1) ? data[i + 1].Value : new Nullable<double>())
                        &&
                        VehicleGraphs.IsDuplicated(data[i - 1].Ignition, data[i].Ignition, (i < data.Length - 1) ? data[i + 1].Ignition : new Nullable<bool>())
                      )
                    {
                        //for analog graphs we need to check ignition to optimize to send all important points
                        items.Add(new AnalogData(data[i].Timestamp, data[i].Value, data[i].Ignition));
                    }
                }
            }
            return data.Where(n => !items.Any(x => n.Timestamp == x.Timestamp && n.Value == x.Value)).ToArray();
        }
        
    }
}
