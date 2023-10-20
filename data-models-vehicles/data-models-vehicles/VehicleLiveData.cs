using Frotcom.Data.Models.Packets.TrackingPacketFrames;
using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleLiveData
    {
        public long ReceivedDataId { get; set; }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? Immobilizer { get; set; }
        public bool? IsOnTrip { get; set; }
        public bool IsOnPrivacy { get; set; }
        public bool IsStopped { get; set; }
        public int? StopDuration { get; set; }
        public double? Speed { get; set; }
        public double? Direction { get; set; }
        public DateTime? LastCommunication { get; set; }
        public short CommunicationStatus { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public VehicleBattery? Battery { get; set; }
        public VehicleBattery? BatteryPercentage { get; set; }
        public double? Odometer { get; set; }
        public double? OdometerGps { get; set; }
        public double? OdometerCanbus { get; set; }
        public short? TachoWorkState { get; set; }
        public double? Chronometer { get; set; }
        public bool ELDIsLocked { get; set; }
        public byte[] TrackingData { get; set; }

        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string DriverMsisdn { get; set; }
        public string DriverRef { get; set; }
        public int? DriverStatusCustomId { get; set; }
        public string DriverStatusCustomName { get; set; }
        public int? DriverStatusCustomColor { get; set; }

        public int CoDriverId { get; set; }
        public string CoDriverName { get; set; }
        public string CoDriverMsisdn { get; set; }
        public string CoDriverRef { get; set; }
        public int? CoDriverStatusCustomId { get; set; }
        public string CoDriverStatusCustomName { get; set; }
        public int? CoDriverStatusCustomColor { get; set; }
        public int? EnergyLevel { get; set; }
        public bool? IsCharging { get; set; }
        public ChargingType? ChargingType { get; set; }
        public int? Range { get; set; }
    }
}
