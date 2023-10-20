using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class ELBEvent
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public DateTime Timestamp { get; set; }

        public ELBCommand? Command { get; set; }

        public string SentBy { get; set; }

        public ELBResponse? Response { get; set; }
    }
}