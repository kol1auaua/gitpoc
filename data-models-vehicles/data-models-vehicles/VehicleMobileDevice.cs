using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleMobileDevice
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public bool HasMobile { get; set; }
        public string ClientData { get; set; }

        public string Version
        {
            get
            {
                if (HasMobile && !string.IsNullOrEmpty(ClientData) && ClientData.Contains("version:"))
                {
                    string v = ClientData.Split(';').FirstOrDefault(x => x.Contains("version:"));

                    if (!string.IsNullOrEmpty(v))
                    {
                        return v.Trim().Split(' ').LastOrDefault();
                    }
                }

                return string.Empty;
            }
            set
            {
            }
        }
    }
}
