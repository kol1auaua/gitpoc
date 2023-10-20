using Frotcom.Data.Models.Packets.RealTimeTracking.ExtendedCANBus;
using System;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleOtherInfo
    {
        public int VehicleId { get; set; }
        public double? CanbusMileage
        {
            get
            {
                return (CanbusOdometer ?? CanbusOdometerInitial ?? 0.0) - (CanbusOdometerInitial ?? CanbusOdometer ?? 0.0);
            }

            set { }
        }
        public double? GpsMileage
        {
            get
            {
                return (GpsOdometer ?? GpsOdometerInitial ?? 0.0) - ((GpsOdometerInitial ?? GpsOdometer ?? 0.0) - (AuditEvents?.Where(x => x.OdometerDifference > 0).Sum(x => x.OdometerDifference) ?? 0.0) + (AuditEvents?.Where(x => x.OdometerDifference < 0).Sum(x => x.OdometerDifference) ?? 0.0));
            }
            set { }
        }
        public double? CanbusOdometer { get; set; }
        public double? CanbusOdometerInitial { get; set; }
        public double? GpsOdometer { get; set; }
        public double? GpsOdometerInitial { get; set; }
        public double? FuelInTank
        {
            get
            {
                double fuel = 0.0;

                if (FuelManagement)
                {
                    fuel += UseAna1 ? Ana1Fuel : 0.0;
                    fuel += UseAna2 ? Ana2Fuel : 0.0;
                    fuel += UseAna3 ? Ana3Fuel : 0.0;
                    fuel += UseCanbus ? CanbusFuelLevel * CanBusFuelTankCapacity / 100 : 0.0;
                }
                else
                {
                    fuel = HasCanbus > 0 ? CanbusFuelLevel * CanBusFuelTankCapacity / 100 : 0.0;
                }

                return fuel;
            }
            set { }
        }
        public double? FuelInTankInitial
        {
            get
            {
                double fuel = 0.0;

                if (FuelManagement)
                {
                    fuel += UseAna1 ? Ana1FuelInitial : 0.0;
                    fuel += UseAna2 ? Ana2FuelInitial : 0.0;
                    fuel += UseAna3 ? Ana3FuelInitial : 0.0;
                    fuel += UseCanbus ? CanbusFuelLevelInitial * CanBusFuelTankCapacity / 100 : 0.0;
                }
                else
                {
                    fuel = HasCanbus > 0 ? CanbusFuelLevelInitial * CanBusFuelTankCapacity / 100 : 0.0;
                }

                return fuel;
            }
            set { }
        }
        public double? FuelConsumption
        {
            get
            {
                switch (FuelConsumptionMode)
                {
                    case FuelConsumptionMode.UseCanbusTotalFuelUsed:
                        {
                            return CanbusFuel - CanbusFuelInitial;
                        }
                    case FuelConsumptionMode.CalculateFromFuelLevel:
                        {
                            double fuelInitial = 0.0;
                            fuelInitial += UseAna1 ? Ana1FuelInitial : 0.0;
                            fuelInitial += UseAna2 ? Ana2FuelInitial : 0.0;
                            fuelInitial += UseAna3 ? Ana3FuelInitial : 0.0;
                            fuelInitial += UseCanbus ? CanbusFuelLevelInitial * CanBusFuelTankCapacity / 100 : 0.0;

                            double fuelFinal = 0.0;
                            fuelFinal += UseAna1 ? Ana1Fuel : 0.0;
                            fuelFinal += UseAna2 ? Ana2Fuel : 0.0;
                            fuelFinal += UseAna3 ? Ana3Fuel : 0.0;
                            fuelFinal += UseCanbus ? CanbusFuelLevel * CanBusFuelTankCapacity / 100 : 0.0;

                            return fuelInitial - fuelFinal + (FuelEvents?.Sum(x => x.FuelDifference) ?? 0.0);
                        }
                    case FuelConsumptionMode.UseFixedFuelConsumption:
                        {
                            if (FuelConsumptionPer100Km > 0)
                            {
                                return FuelConsumptionPer100Km * (Mileage / 100);
                            }
                            else if (FuelConsumptionPerHour > 0)
                            {
                                return FuelConsumptionPerHour * (DrivingTime / 3600.0);
                            }
                            else
                            {
                                return 0.0;
                            }
                        }
                    default:
                        {
                            return 0.0;
                        }
                }
            }
            set { }
        }
        public int? DrivingState { get; set; }
        public int? WorkingState { get; set; }
        public int? AvailabilityState { get; set; }
        public int? RestState { get; set; }
        public double? EngineSpeed { get; set; }
        public double? EngineTemperature { get; set; }
        public int DrivingTime { get; set; }
        public double? Mileage
        {
            get
            {
                return UseCanbusMileage ? CanbusMileage : GpsMileage;
            }
            set { }
        }

        public double? AverageFuelConsumptionPerHour
        {
            get
            {
                if (FuelConsumption.HasValue && DrivingTime > 0)
                {
                    return FuelConsumption.Value / DrivingTime * 3600.0;
                }

                return 0.0;
            }
            set { }
        }

        public double? AverageFuelConsumptionPerMileage
        {
            get
            {
                if (FuelConsumption.HasValue && Mileage > 0)
                {
                    return FuelConsumption.Value / Mileage * 100.0;
                }

                return 0.0;
            }
            set { }
        }

        public double CostKm { get; set; }
        public double CostHour { get; set; }

        public string Tp1Name { get; set; }
        public double? Tp1 { get; set; }
        public string Tp2Name { get; set; }
        public double? Tp2 { get; set; }
        public string Tp3Name { get; set; }
        public double? Tp3 { get; set; }
        public string Tp4Name { get; set; }
        public double? Tp4 { get; set; }
        public string Tp5Name { get; set; }
        public double? Tp5 { get; set; }
        public string Tp6Name { get; set; }
        public double? Tp6 { get; set; }
        public string Tp7Name { get; set; }
        public double? Tp7 { get; set; }
        public string Tp8Name { get; set; }
        public double? Tp8 { get; set; }
        public string Tp9Name { get; set; }
        public double? Tp9 { get; set; }
        public string Tp10Name { get; set; }
        public double? Tp10 { get; set; }
        public string Door1Name { get; set; }
        public bool? Door1 { get; set; }
        public string Door2Name { get; set; }
        public bool? Door2 { get; set; }
        public string Door3Name { get; set; }
        public bool? Door3 { get; set; }
        public VehicleFuelEvent[] FuelEvents { get; set; }
        public VehicleAudit[] AuditEvents { get; set; }
        public double CanbusFuel { get; set; }
        public double CanbusFuelInitial { get; set; }
        public bool UseAna1 { get; set; }
        public double Ana1Fuel { get; set; }
        public double Ana1FuelInitial { get; set; }
        public string Ana1Name { get; set; }
        public bool UseAna2 { get; set; }
        public double Ana2Fuel { get; set; }
        public double Ana2FuelInitial { get; set; }
        public string Ana2Name { get; set; }
        public bool UseAna3 { get; set; }
        public double Ana3Fuel { get; set; }
        public double Ana3FuelInitial { get; set; }
        public string Ana3Name { get; set; }
        public bool UseCanbus { get; set; }
        public double CanbusFuelLevel { get; set; }
        public double CanbusFuelLevelInitial { get; set; }
        public int HasCanbus { get; set; }
        public double CanBusFuelTankCapacity { get; set; }
        public FuelConsumptionMode FuelConsumptionMode { get; set; }
        public bool FuelManagement { get; set; }
        public double FuelConsumptionPer100Km { get; set; }
        public double FuelConsumptionPerHour { get; set; }
        public bool UseCanbusMileage { get; set; }

        //WEB-4530
        public double? FuelConsuptionIdling { get; set; }
        public int IdleTime { get; set; }

        #region SignalRHubGraphs from VehicleDataSender

        public int CompanyId { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Ign { get; set; }
        public double Speed { get; set; }

        public short? TachoWorkState { get; set; }

        public string Din1Name { get; set; }
        public bool Din1 { get; set; }
        public string Din2Name { get; set; }
        public bool Din2 { get; set; }
        public string Din3Name { get; set; }
        public bool Din3 { get; set; }

        public bool Seal1 { get; set; }
        public bool Seal2 { get; set; }
        public bool Seal3 { get; set; }

        public int AdBlueLevel { get; set; }

        public int GrossWeight { get; set; }
        public int FirstAxleWeight { get; set; }
        public int SecondAxleWeight { get; set; }
        public int TrailerWeight { get; set; }
        public bool PTO { get; set; }

        public byte[] TwoSecondsTrackingSpeed { get; set; }
        public byte[] TwoSecondsTrackingSpeedHiRes { get; set; }
        public byte[] GPSFixData { get; set; }
        public int? EnergyLevel { get; set; }

        public double Altitude { get; set; }

        #endregion SignalRHubGraphs from VehicleDataSender

        public float? OutsideAirTemperature { get; set; }
        public int? RTEngineSpeed { get; set; }
        public int? EngineTorque { get; set; }
        public int? EngineCoolantTemperature { get; set; }
        public int? CurrentGear { get; set; }
        public SPNState? CruiseControl { get; set; }
        public int? Retarder { get; set; }
        public float? AcceleratorPedalPosition { get; set; }
        public float? BrakePedalPosition { get; set; }
        public SPNState? ASR { get; set; }
        public SPNState? ABS { get; set; }
    }
}
