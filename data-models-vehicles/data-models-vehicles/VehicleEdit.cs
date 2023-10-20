using Frotcom.Data.Models.Vehicles;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleEdit
    {
        public int OEMProviders { get; set; }
        public int Id { get; set; }
        public char Kind { get; set; }
        public bool HasCanbus { get; set; }
        public bool HasSensor1 { get; set; }
        public bool HasSensor2 { get; set; }
        public bool HasSensor3 { get; set; }

        public int? Icon { get; set; }

        #region Identification
        public string LicensePlate { get; set; }
        public TrackingType Tracking { get; set; }
        public string Imei { get; set; }
        public string[] ImeiArray { get; set; }
        public string Vin { get; set; }
        public string EngineNumber { get; set; }
        #endregion

        #region Association
        public int? VehicleId { get; set; }
        public int? AssetId { get; set; }
        public int? TerminalId { get; set; }
        public int? DriverId { get; set; }
        public int? CoDriverId { get; set; }
        #endregion

        #region Description
        public int? TypeId { get; set; }
        public int? ClassId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int? EngineId { get; set; }
        public int? Year { get; set; }
        public DateTime? Acquisition { get; set; }
        #endregion

        #region Organization
        public int? DepartmentId { get; set; }
        public int? SegmentId { get; set; }
        #endregion

        #region Odometer

        public bool? UseCanbusMileage { get; set; }
        public double? Odometer { get; set; }
        public double? OdometerCanbus { get; set; }
        public double? Chronometer { get; set; }

        public bool? CruiseControl { get; set; }
        #endregion

        #region Capacity
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Length { get; set; }
        public double? Pallets { get; set; }
        public double? Payload { get; set; }
        public double? GrossWeight { get; set; }
        public double? CurbWeight { get; set; }
        public bool? DoubleDeck { get; set; }
        #endregion

        #region Costs
        public double? CostKm { get; set; }
        public double? CostHour { get; set; }
        #endregion

        #region Fuel
        public double? Fuel100Km { get; set; }
        public double? FuelHour { get; set; }
        public double? FuelTank { get; set; }
        public double? CanbusFuelTank { get; set; }

        public bool? FuelManagement { get; set; }
        public int? PercMinIncrease { get; set; }
        public int? PercMinDecrease { get; set; }

        public int? FuelConsumption { get; set; }

        public string Sensor1Name { get; set; }
        public string Sensor2Name { get; set; }
        public string Sensor3Name { get; set; }

        public bool? Sensor1 { get; set; }
        public bool? Sensor2 { get; set; }
        public bool? Sensor3 { get; set; }
        public bool? SensorCanbus { get; set; }
        #endregion

        #region Equipment
        public bool? PalletCarrier { get; set; }
        public bool? MeatRail { get; set; }
        public string SecuringStraps { get; set; }
        public string OtherEquipment { get; set; }
        public bool? Refrigerated { get; set; }

        public double? RefrigeratedFrom { get; set; }
        public double? RefrigeratedTo { get; set; }
        public bool? Bitemperature { get; set; }
        public double? BitemperatureFrom { get; set; }
        public double? BitemperatureTo { get; set; }

        #endregion

        #region Free Fields
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        #endregion

        #region Interact Options

        public AuthorizationType? InteractAuthorization { get; set; }
        public string InteractCode { get; set; }
        #endregion

        public PrivacyMode PrivacyMode { get; set; }

        [JsonIgnore]
        public string DeviceType { get; set; }

        public bool IsErasable { get; set; }

        #region Immobilization

        public VehicleImmobType? ImmobEvent { get; set; }

        public bool? ImmobAutoOption { get; set; }

        public bool? HasImmobilizer { get; set; }
        #endregion

        #region Drivers Whitelist

        public bool HasDriversWL { get; set; }

        public Whitelist DriversWhiteList { get; set; }


        #endregion

        #region ELB

        public bool HasLock { get; set; }

        public bool IsLocked { get; set; }

        public string MasterPin { get; set; }

        public string DriverPin { get; set; }

        public string ELBNotes { get; set; }

        public ELBEvent[] ELBEvents { get; set; }

        #endregion

        [JsonIgnore]
        public int CompanyId { get; set; }

        public string TachographType { get; set; }
        public bool? UseOneMinRule { get; set; }
        public VehicleAssetType? VehicleAssetType { get; set; }

        #region Vehicle Status

        public string VehicleStatusName { get; set; }
        public int? VehicleStatusId { get; set; }

        #endregion

        public bool? UseDriversWLRestrictions { get; set; }

        #region TollSystem
        public TollSystemEmissionStandards? TollSystemEmissionStandard { get; set; }
        public TollSystemNationalitys? TollSystemNationality { get; set; }
        public TollSystemEngines? TollSystemEngine { get; set; }
        public int? TollSystemNumberOfAxles { get; set; }
        public int? TollSystemCoEmission { get; set; }

        public int? TollSystemGrossWeight { get; set; }
        public int? TollSystemKerbWeight { get; set; }
        public TollSystemVehicleClass? TollSystemVehicleClass { get; set; }
        public int? TollSystemFirstAxleHeight { get; set; }
        public bool? UseTollSystem { get; set; }
        #endregion
    }
}
