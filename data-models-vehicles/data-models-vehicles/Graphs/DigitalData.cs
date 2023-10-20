using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class DigitalData
    {
        public DigitalData(DateTime timestamp, bool value)
        {
            this.Timestamp = timestamp;
            this.Value = value;
        }

        public DateTime Timestamp { get; set; }
        public bool Value { get; set; }

        public static DigitalData[] OptimizeData(DigitalData[] data)
        {
            List<DigitalData> items = new List<DigitalData>();

            if (data.Length > 2)
            {
                for (int i = 1; i < data.Length - 1; i++)
                {
                    if (VehicleGraphs.IsDuplicated(data[i - 1].Value, data[i].Value, (i < data.Length - 1) ? data[i + 1].Value : new Nullable<bool>()))
                    {
                        items.Add(new DigitalData(data[i].Timestamp, data[i].Value));
                    }
                }
            }
            return data.Where(n => !items.Any(x => n.Timestamp == x.Timestamp && n.Value == x.Value)).ToArray();
        }
        
    }
}
