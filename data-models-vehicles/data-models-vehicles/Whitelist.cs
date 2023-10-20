using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frotcom.Data.Models.Vehicles
{
    public class Whitelist
    {
        public DateTime? LastChanged { get; set; }

        public DateTime? LastConfigured { get; set; }

        public int[] Drivers { get; set; }
    }
}
