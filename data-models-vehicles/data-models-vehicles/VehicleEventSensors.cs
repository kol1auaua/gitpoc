using Frotcom.Data.Models.Base;
using Frotcom.Data.Models.Base.Helpers;
using Newtonsoft.Json;

namespace Frotcom.Data.Models.Vehicles
{
    public partial class VehicleEventDetail
    {
        [TypeFormat(TypeFormat.Boolean)]
        public bool? IsIgnitionOn { get; set; }

        public bool? Door1 { get; set; }
        public bool? Door2 { get; set; }
        public bool? Door3 { get; set; }

        public bool? Seal1 { get; set; }
        public bool? Seal2 { get; set; }
        public bool? Seal3 { get; set; }

        public bool? Din1 { get; set; }
        public bool? Din2 { get; set; }
        public bool? Din3 { get; set; }

        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Ana1 { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Ana2 { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Ana3 { get; set; }

        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Tp1 { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Tp2 { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter))]
        public double? Tp3 { get; set; }



    }
}
