using System.Collections.Generic;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleFuelInfo
    {
        private double totalRefuel;
        private double totalDrainage;
        private int countRefuel;

        public VehicleFuelInfo() { }

        public VehicleFuelInfo(int vehicleId, string licensePlate, bool hasCanBus, double? fuelTankCapacity, double? canBusFuelTankCapacity, bool useCanBusMileage, int fuelConsumption, double fuel100Km, double fuelHour, bool hasTotalFuelUsedHighRes, double refuelNotes, double countNotes, bool fuelManagement, string anaFuel)
        {
            VehicleId = vehicleId;
            LicensePlate = licensePlate;
            HasCanBus = hasCanBus;
            FuelTankCapacity = fuelTankCapacity;
            CanBusFuelTankCapacity = canBusFuelTankCapacity;
            UseCanBusMileage = useCanBusMileage;
            FuelConsumption = fuelConsumption;
            Fuel100Km = fuel100Km;
            FuelHour = fuelHour;
            HasTotalFuelUsedHighRes = hasTotalFuelUsedHighRes;
            RefuelNotes = refuelNotes;
            CountNotes = countNotes;
            FuelManagement = fuelManagement;
            ANAFuel = anaFuel;

            vehicleFuelEvents = new List<VehicleFuelEvents>();
        }

        public VehicleFuelInfo(int vehicleId, string licensePlate, bool hasCanBus, double? fuelTankCapacity, double? canBusFuelTankCapacity, bool useCanBusMileage, int fuelConsumption, double fuel100Km, double fuelHour, bool hasTotalFuelUsedHighRes, double refuelNotes, double countNotes, bool fuelManagement, string anaFuel, string totalCalcFuelLevelSensors) : this(vehicleId, licensePlate, hasCanBus, fuelTankCapacity, canBusFuelTankCapacity, useCanBusMileage, fuelConsumption, fuel100Km, fuelHour, hasTotalFuelUsedHighRes, refuelNotes, countNotes, fuelManagement, anaFuel)
        {
            TotalCalcFuelLevelSensors = totalCalcFuelLevelSensors;
        }

        public string ANAFuel { get; private set; }
        public int VehicleId { get; private set; }
        public string LicensePlate { get; private set; }
        public bool HasCanBus { get; private set; }
        public double? FuelTankCapacity { get; private set; }
        public double? CanBusFuelTankCapacity { get; private set; }
        public bool UseCanBusMileage { get; private set; }
        public int FuelConsumption { get; private set; }
        public double Fuel100Km { get; private set; }
        public double FuelHour { get; private set; }
        public bool HasTotalFuelUsedHighRes { get; private set; }
        public string TotalCalcFuelLevelSensors { get; private set; }
        public double RefuelNotes { get; private set; }
        public double CountNotes { get; private set; }
        public bool FuelManagement { get; set; }


        private ICollection<VehicleFuelEvents> vehicleFuelEvents;
        public IReadOnlyCollection<VehicleFuelEvents> VehicleFuelEvents => vehicleFuelEvents as IReadOnlyCollection<VehicleFuelEvents>;

        public void AddVehicleFuelEvent(VehicleFuelEvents vehicleFuelEvent)
        {
            totalRefuel += vehicleFuelEvent.Refuel;
            totalDrainage += vehicleFuelEvent.Drainage;
            countRefuel += vehicleFuelEvent.Refuel != 0 ? 1 : 0;
            vehicleFuelEvents.Add(vehicleFuelEvent);
        }

        public void AddRangeVehicleFuelEvent(List<VehicleFuelEvents> vehicleFuelEvent) => vehicleFuelEvent.ForEach(fuelEvent => AddVehicleFuelEvent(fuelEvent));

        public double TotalRefuel => totalRefuel;
        public double TotalDrainage => totalDrainage;
        public int CountRefuel => countRefuel;
    }
}
