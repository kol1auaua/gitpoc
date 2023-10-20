using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class CompanyVehicleStatus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? StatusColor { get; set; }

        public DateTime DTChanged { get; set; }

        public string Username { get; set; }

        public bool IsDeleted { get; set; }

        public int CompanyId { get; set; }

    }
}
