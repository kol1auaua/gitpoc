using Frotcom.Data.Models.Base;
using Frotcom.Data.Models.Base.Helpers;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Globalization;

namespace Frotcom.Data.Models.Vehicles
{
    public partial class VehicleEventDetail
    {
        [Description("[timestamp]")]
        [TypeFormat(TypeFormat.DateTime)]
        public DateTime? Timestamp { get; set; }

        [Description("[driver]")]
        public string DriverName { get; set; }

        [Description("[location]")]
        public string Location { get; set; }

        [Description("[coordinates]")]
        public string Coordenates
        {
            get
            {
                if (Latitude.HasValue && Longitude.HasValue)
                {
                    return string.Format("{0}, {1}", Latitude.Value.ToString(CultureInfo.InvariantCulture), Longitude.Value.ToString(CultureInfo.InvariantCulture));
                }
                return null;
            }
            set { }
        }

        [Description("[speed]")]
        [TypeFormat(TypeFormat.Speed)]
        public double? Speed { get; set; }
        [Description("[valid-gps]")]
        [TypeFormat(TypeFormat.Boolean)]
        public bool? IsValidGps { get; set; }

        [JsonConverter(typeof(DoubleJsonConverter), 6)]
        public double? Latitude { get; set; }
        [JsonConverter(typeof(DoubleJsonConverter), 6)]
        public double? Longitude { get; set; }

        [Description("[external-power]")]
        [TypeFormat(TypeFormat.Boolean)]
        public bool? HasExternalPower { get; set; }
    }
}
