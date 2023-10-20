using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class WeightData
    {
        public WeightData()
        { }

        public DateTime Timestamp { get; set; }
        
        public int? Weight { get; set; }
        
        public int? FirstAxle { get; set; }
        
        public int? SecondAxle { get; set; }
        
        public int? TrailerWeight { get; set; }
        
        public static WeightData[] OptimizeData(WeightData[] data)
        {
            List<WeightData> items = new List<WeightData>();

            if (data.Length > 2)
            {
                for (int i = 1; i < data.Length - 1; i++)
                {
                    if (VehicleGraphs.IsDuplicated(data[i - 1].Weight ?? 0, data[i].Weight ?? 0, (i < data.Length - 1) ? data[i + 1].Weight : new Nullable<double>()) &&
                        VehicleGraphs.IsDuplicated(data[i - 1].FirstAxle ?? 0, data[i].FirstAxle ?? 0, (i < data.Length - 1) ? data[i + 1].FirstAxle : new Nullable<double>()) &&
                        VehicleGraphs.IsDuplicated(data[i - 1].SecondAxle ?? 0, data[i].SecondAxle ?? 0, (i < data.Length - 1) ? data[i + 1].SecondAxle : new Nullable<double>()) &&
                         VehicleGraphs.IsDuplicated(data[i - 1].TrailerWeight ?? 0, data[i].TrailerWeight ?? 0, (i < data.Length - 1) ? data[i + 1].TrailerWeight : new Nullable<double>()))
                    {
                        items.Add(new WeightData()
                        {
                            Timestamp = data[i].Timestamp,
                            Weight = data[i].Weight,
                            FirstAxle = data[i].FirstAxle,
                            SecondAxle = data[i].SecondAxle,
                            TrailerWeight = data[i].TrailerWeight,
                        });
                    }
                }
            }
            return data.Where(n => !items.Any(x => n.Timestamp == x.Timestamp && n.Weight == x.Weight && n.FirstAxle == x.FirstAxle && 
            n.SecondAxle == x.SecondAxle && n.TrailerWeight == x.TrailerWeight)).ToArray();
        }


    }
}