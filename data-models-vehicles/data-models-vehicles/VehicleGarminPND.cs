using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleGarminPND
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public string Protocols { get; set; }
        public string[] SupportedProtocols
        {
            get
            {
                return GetMatchingGarminProtocols(Protocols);
            }
            set
            {

            }
        }

        private string[] GetMatchingGarminProtocols(string protocols)
        {
            if (!string.IsNullOrWhiteSpace(protocols))
            {
                List<string> supportedProtocols = new List<string>()
                {
                    "A603", //– Stops Management
                    "A604", //– Text Messages
                    "A608", // – Speed Limit Alerts
                    "A611", // – Long Text Messages
                    "A614", // – Path Specific Stops (Routes)
                    "A618", // – Support stops with long text (up to 2000 bytes)
                    "A622", // – Dash Camera protocol""
                };

                return supportedProtocols.Where(sp => protocols.Split(';').Contains(sp)).ToArray();
            }

            return new string[0];
        }
    }
}
