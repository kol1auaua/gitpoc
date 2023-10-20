namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleReduced
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int CompanyId { get; set; }
        public string LicensePlate { get; set; }
        public bool UseCanBusMileage { get; set; }
        public bool OnTripNow { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string VehicleType { get; set; }
    }
}
