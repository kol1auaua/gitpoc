using Frotcom.Data.Models.Base;
using System;
using System.ComponentModel;

namespace Frotcom.Data.Models.Vehicles
{
    public partial class VehicleEventDetail
    {
        public int? VehicleId { get; set; }

        [Description("[vehicle]")]
        //[Attributes.TypeFormat(Attributes.TypeFormat.Volume)]
        public string LicensePlate { get; set; }
        public int? AssetId { get; set; }
        [Description("[asset]")]
        public string AssetLicensePlate { get; set; }
        [Description("[coupled-on]")]
        [TypeFormat(TypeFormat.DateTime)]
        public DateTime? CoupledOn { get; set; }
        [Description("[coupling-location]")]
        public string CoupledLocation { get; set; }
        [Description("[coupling-detection]")]
        [TypeFormat(TypeFormat.Translate)]
        public string CoupledDetection { get; set; }
        public string CoupledUserMethod { get; set; }
        [Description("[uncoupled-on]")]
        [TypeFormat(TypeFormat.DateTime)]
        public DateTime? UncoupledOn { get; set; }
        [Description("[uncoupling-location]")]
        public string UncoupledLocation { get; set; }
        [Description("[uncoupling-detection]")]
        [TypeFormat(TypeFormat.Translate)]
        public string UncoupledDetection { get; set; }
        public string UncoupledUserMethod { get; set; }

    }
}
