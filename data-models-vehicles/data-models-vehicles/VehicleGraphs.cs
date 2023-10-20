using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleGraphs
    {
        public VehicleGraphs()
        {
            Analog = new List<AnalogGraph>();
            Digital = new List<DigitalGraph>();
            Canbus = new List<CanbusGraph>();
            Fuel = new List<FuelGraph>();
            AdBlue = new List<AdBlueGraph>();
            Weight = new List<WeightGraph>();
            TemperatureParameters = new List<TemperatureParameter>();
            TemperatureValues = new List<TemperatureValue>();
        }

        public int VehicleId { get; set; }

        public List<AnalogGraph> Analog { get; set; }
        public List<DigitalGraph> Digital { get; set; }
        public List<CanbusGraph> Canbus { get; set; }
        public List<FuelGraph> Fuel { get; set; }
        public List<AdBlueGraph> AdBlue { get; set; }

        public List<WeightGraph> Weight { get; set; }
        public List<TemperatureParameter> TemperatureParameters { get; set; }
        public List<TemperatureValue> TemperatureValues { get; set; }
        public VehicleGraphs OptimizeGraphData()
        {
            if (Analog.Any())
            {
                foreach (AnalogGraph graph in Analog)
                {
                    if (graph.Data.Any())
                    {
                        graph.Data = AnalogData.OptimizeData(graph.Data);
                    }
                    else
                    {
                        Analog = null;
                    }
                }
            }
            else
            {
                Analog = null;
            }

            if (Digital.Any())
            {
                foreach (DigitalGraph graph in Digital)
                {
                    if (graph.Data.Any())
                    {
                        graph.Data = DigitalData.OptimizeData(graph.Data);
                    }
                    else
                    {
                        Digital = null;
                    }
                }
            }
            else
            {
                Digital = null;
            }

            if (Canbus.Any())
            {
                foreach (CanbusGraph graph in Canbus)
                {
                    if (graph.Data.Any())
                    {
                        graph.Data = CanbusData.OptimizeData(graph.Data);
                    }
                    else
                    {
                        Canbus = null;
                    }
                }
            }
            else
            {
                Canbus = null;
            }

            if (Fuel.Any())
            {
                foreach (FuelGraph graph in Fuel)
                {
                    if (graph.Data == null || !graph.Data.Any())
                    {
                        Fuel = null;
                    }
                    else
                    {
                        graph.Data = FuelData.OptimizeData(graph.Data);
                    }
                }
            }
            else
            {
                Fuel = null;
            }

            if (AdBlue.Any())
            {
                foreach (AdBlueGraph graph in AdBlue)
                {
                    if (graph.Data == null || !graph.Data.Any())
                    {
                        AdBlue = null;
                    }
                    else
                    {
                        graph.Data = AdBlueData.OptimizeData(graph.Data);
                    }
                }
            }
            else
            {
                AdBlue = null;
            }

            if (Weight.Any())
            {
                foreach (WeightGraph graph in Weight)
                {
                    if (graph.Data == null || !graph.Data.Any())
                    {
                        Weight = null;
                    }
                    else
                    {
                        graph.Data = WeightData.OptimizeData(graph.Data);
                    }
                }
            }
            else
            {
                Weight = null;
            }

            return this;
        }

        public static bool IsDuplicated(double before, double current, double? next)
        {
            return before == current && next.HasValue && next == current;
        }

        public static bool IsDuplicated(bool before, bool current, bool? next)
        {
            return before == current && next.HasValue && next == current;
        }
    }
}
