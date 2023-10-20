using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class FuelData
    {
        public FuelData()
        { }

        public DateTime Timestamp { get; set; }
        public double? Value1 { get; set; }
        public double? Value2 { get; set; }
        public double? Value3 { get; set; }
        public double? CanbusLevel { get; set; }
        public double? Total { get; set; }

        public static FuelData[] OptimizeData(FuelData[] data)
        {
            List<FuelData> items = new List<FuelData>();

            if (data.Length > 2)
            {
                for (int i = 1; i < data.Length - 1; i++)
                {
                    if (VehicleGraphs.IsDuplicated( data[i - 1].Value1 ?? 0, data[i].Value1 ?? 0, (i < data.Length - 1) ? data[i + 1].Value1 : new Nullable<double>()) &&
                        VehicleGraphs.IsDuplicated(data[i - 1].Value2 ?? 0, data[i].Value2 ?? 0, (i < data.Length - 1) ? data[i + 1].Value2 : new Nullable<double>()) &&
                        VehicleGraphs.IsDuplicated(data[i - 1].Value3 ?? 0, data[i].Value3 ?? 0, (i < data.Length - 1) ? data[i + 1].Value3 : new Nullable<double>()) &&
                        VehicleGraphs.IsDuplicated(data[i - 1].CanbusLevel ?? 0, data[i].CanbusLevel ?? 0, (i < data.Length - 1) ? data[i + 1].CanbusLevel : new Nullable<double>()))
                    {
                        items.Add(new FuelData()
                        {
                            Timestamp = data[i].Timestamp,
                            Value1 = data[i].Value1,
                            Value2 = data[i].Value2,
                            Value3 = data[i].Value3,
                            Total = data[i].Total,
                            CanbusLevel = data[i].CanbusLevel
                        });
                    }
                }
            }
            return data.Where(n => !items.Any(x => n.Timestamp == x.Timestamp && n.Value1 == x.Value1 && n.Value2 == x.Value2 && n.Value3 == x.Value3 &&
                   n.CanbusLevel == x.CanbusLevel)).ToArray();
        }
    }
}
