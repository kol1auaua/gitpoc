using Frotcom.Data.Models.Drivers;
using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class Vehicle
    {
        #region Vehicle

        public int Id { get; set; }
        public char Kind { get; set; }
        public bool HasCanbus { get; set; }
        public bool HasObd2 { get; set; }
        public bool HasSensor1 { get; set; }
        public bool HasSensor2 { get; set; }
        public bool HasSensor3 { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public int? ClassId { get; set; }
        public string ClassName { get; set; }
        public int? AssetId { get; set; }
        public int? VehicleId { get; set; }
        public string CoupledLicensePlate { get; set; }
        public string LicensePlate { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string DriverRef { get; set; }
        public int? StopDuration { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Direction { get; set; }
        public double? Speed { get; set; }
        public bool IsOnPrivacy { get; set; }
        public int? Immobilizer { get; set; }
        public int Icon { get; set; }

        public double? OdometerGps { get; set; }
        public double? OdometerCanbus { get; set; }
        public short? TachoWorkState { get; set; }
        public string Imei { get; set; }

        public DateTime? LastCommunication { get; set; }
        public short CommunicationStatus { get; set; }

        public int DepartmentId { get; set; }
        public string Department { get; set; }
        public int SegmentId { get; set; }
        public string Segment { get; set; }
        public bool? IsOnTrip { get; set; }
        public int StopSpeedLimit { get; set; }
        public bool FuelManagement { get; set; }
        public double? Co2Emission { get; set; }

        #endregion

        #region Vehicle Details

        public string Config { get; set; }
        public bool? HasImmobilizer { get; set; }

        public bool HasBuzzer { get; set; }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int? ModelYear { get; set; }
        public double? Chronometer { get; set; }
        public double? CostKm { get; set; }

        public string DriverMsisdn { get; set; }
        public int CoDriverId { get; set; }
        public string CoDriverName { get; set; }
        public string CoDriverMsisdn { get; set; }

        public VehicleInfo Alarms { get; set; }
        public VehicleInfo Messages { get; set; }
        public VehicleInfo Trips { get; set; }
        public DrivingTimes DriverDrivingTimes { get; set; }
        public DrivingTimes CoDriverDrivingTimes { get; set; }
        public string PlaceName { get; set; }

        public VehicleSensors Sensors { get; set; }

        public int EngineId { get; set; }

        public bool IsStopped { get; set; }

        public bool? UseCanbusMileage { get; set; }

        public bool HasCruiseControl { get; set; }

        public int EcoProfileId { get; set; }
        public short? FuelConsumption { get; set; }
        public double? Fuel100Km { get; set; }
        public double? FuelHour { get; set; }

        #endregion

        #region Vehicle Status

        public int? VehicleStatusColor { get; set; }
        public string VehicleStatusName { get; set; }
        public int VehicleStatusId { get; set; }

        #endregion

        public VehicleBattery? Battery { get; set; }

        public bool CanSendMessage { get; set; }

        public bool HasDrivingTimes { get; set; }
        public string Protocols { get; set; }

        public string[] SupportedProtocols { get; set; }

        public bool? OdometerOk { get; set; }
        public bool? TotalFuelOk { get; set; }
        public bool? EngineHoursOk { get; set; }

        public bool HasSeatBelt { get; set; }
        public bool HasGrossCombinationWeight { get; set; }
        public bool HasFirstAxleWeight { get; set; }
        public bool HasSecondAxleWeight { get; set; }
        public bool HasTrailerWeight { get; set; }
        public bool HasOilLowLevelIndicator { get; set; }
        public bool HasAdBlueLevel { get; set; }
        public bool HasBrakePedal { get; set; }
        public bool HasTotalFuelUsedHighRes { get; set; }

        public double? CANBusTotalFuelUsed { get; set; }

        public VehicleAssetType VehicleAssetType { get; set; }

        public int? FuelType { get; set; }

        #region TollSystem

        public TollSystemEmissionStandards? TollSystemEmissionStandard { get; set; }
        public TollSystemNationalitys? TollSystemNationality { get; set; }
        public TollSystemEngines? TollSystemEngine { get; set; }
        public int? TollSystemNumberOfAxles { get; set; }
        public int? TollSystemCoEmission { get; set; }
        public int? TollSystemGrossWeight { get; set; }
        public int? TollSystemKerbWeight { get; set; }
        public string TollSystemVehicleClass { get; set; }

        #endregion
    }
}
