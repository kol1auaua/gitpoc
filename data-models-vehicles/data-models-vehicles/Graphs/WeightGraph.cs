using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frotcom.Data.Models.Vehicles
{
    public class WeightGraph
    {
        public WeightGraph(string key, string description, string WeightDescription, string FirstAxleDescription, string SecondAxleDescription, string TrailerWeightDescription)
        {
            this.Key = key;
            this.Description = description;
            this.WeightDescription = WeightDescription;
            this.FirstAxleDescription = FirstAxleDescription;
            this.SecondAxleDescription = SecondAxleDescription;
            this.TrailerWeightDescription = TrailerWeightDescription;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public WeightData[] Data { get; set; }
        public string WeightDescription { get; set; }
        public string FirstAxleDescription { get; set; }
        public string SecondAxleDescription { get; set; }
        public string TrailerWeightDescription { get; set; }
    }
}