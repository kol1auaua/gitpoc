using System;
using System.Collections.Generic;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleConfiguration
    { 
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string LicensePlate { get; set; }
        public char Kind { get; set; }
        public bool HasCanbus { get; set; }
        public bool HasSensor1 { get; set; }
        public bool HasSensor2 { get; set; }
        public bool HasSensor3 { get; set; }
        public bool? HasImmobilizer { get; set; }
        public int Icon { get; set; }
        public string Imei { get; set; }
        public int? TypeId { get; set; }
        public int? ClassId { get; set; }
        public string TypeName { get; set; }
        public string ClassName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int SegmentId { get; set; }
        public string SegmentName { get; set; }
        public double? CostKm { get; set; }
        public bool HasPhone { get; set; }
        public bool HasMdt { get; set; }
        public bool HasNav { get; set; }
        public bool HasMobile { get; set; }
        public bool CanSendMessage { get; set; }
        public bool ELDHasLock { get; set; }

        public bool FuelManagement { get; set; }
        public bool UseAna1 { get; set; }
        public bool UseAna2 { get; set; }
        public bool UseAna3 { get; set; }
        public bool UseCanbus { get; set; }
        public bool UseCanbusMileage { get; set; }

        public string ConfigString { get; set; }
        public string VersionSW { get; set; }
        public VehicleBuzzerType? VehicleBuzzerType { get; set; }

        public void SetCanSendMessage(bool hasMobilePerm, bool hasPhonePerm, bool hasNavPerm, bool hasMdtPerm)
        {
            CanSendMessage = (hasMobilePerm && HasMobile) || (hasPhonePerm && HasPhone) || (hasNavPerm && HasNav) || (hasMdtPerm && HasMdt);
        }
    }
}
