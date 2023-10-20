using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class AnalogRange
    {
        public double? Max { get; set; }
        public double? Min { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public AnalogRange(double? max, double? min, DateTime? startDate = null, DateTime? endDate = null)
        {
            Max = max;
            Min = min;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}