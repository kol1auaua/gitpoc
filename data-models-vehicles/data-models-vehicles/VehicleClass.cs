using Frotcom.Data.Models.Base.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleClass
    {
        public int Id { get; set; }
        public string TranslationKey { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? MaxSpeed { get; set; }
    }
}
