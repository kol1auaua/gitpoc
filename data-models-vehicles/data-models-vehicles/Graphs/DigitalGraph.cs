using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frotcom.Data.Models.Vehicles
{
    public class DigitalGraph
    {
        public DigitalGraph(string key, string description)
        {
            this.Key = key;
            this.Description = description;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public DigitalData[] Data { get; set; }
    }
}
