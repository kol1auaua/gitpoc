namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleElectricInfo
    {
        public VehicleElectricInfo
        (
            int loadUnitId, string licensePlate, bool hasCanBUS, bool useCanBusMileage,
            double? batteryFullCapacity, double? electricity100Km, double? electricityHour
        )
        {
            VehicleId = loadUnitId;
            LicensePlate = licensePlate;
            HasCanBus = hasCanBUS;
            UseCanBusMileage = useCanBusMileage;
            BatteryFullCapacity = batteryFullCapacity;
            Electricity100Km = electricity100Km;
            ElectricityHour = electricityHour;
        }

        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public bool HasCanBus { get; set; }
        public bool UseCanBusMileage { get; set; }
        public double? BatteryFullCapacity { get; set; }
        public double? Electricity100Km { get; set; }
        public double? ElectricityHour { get; set; }
    }
}
