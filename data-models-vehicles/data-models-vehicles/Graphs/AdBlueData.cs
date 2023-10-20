using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class AdBlueData
    {
        public AdBlueData(DateTime timestamp, int value)
        {
            this.Timestamp = timestamp;
            this.Value = value;
        }

        public DateTime Timestamp { get; set; }

        public int Value { get; set; }

        public static AdBlueData[] OptimizeData(AdBlueData[] data)
        {
            List<AdBlueData> items = new List<AdBlueData>();

            if (data.Length > 2)
            {
                for (int i = 1; i < data.Length - 1; i++)
                {
                    if (VehicleGraphs.IsDuplicated(data[i - 1].Value, data[i].Value, (i < data.Length - 1) ? data[i + 1].Value : new Nullable<double>()))
                    {
                        items.Add(new AdBlueData(data[i].Timestamp, data[i].Value));
                    }
                }
            }
            return data.Where(n => !items.Any(x => n.Timestamp == x.Timestamp && n.Value == x.Value)).ToArray();
        }

    }
}