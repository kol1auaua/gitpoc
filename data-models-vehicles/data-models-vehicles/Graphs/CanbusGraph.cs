using System;

namespace Frotcom.Data.Models.Vehicles
{
    public class CanbusGraph
    {
        public CanbusGraph(string key, string description)
        {
            this.Key = key;
            this.Description = description;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public CanbusData[] Data { get; set; }
        public CanbusTotals Totals { get; set; }

        public CanbusTotals GetTotals(bool considerNotAvailableAsRest)
        {
            CanbusTotals totals = new CanbusTotals();

            if (Data != null && Data.Length > 0)
            {
                short lastState = -1;
                DateTime lastDate = DateTime.UtcNow;
                DateTime lastRecord = DateTime.UtcNow;
                foreach (CanbusData d in Data)
                {
                    if (d.Value != lastState)
                    {
                        if (lastState == -1)
                        {
                            lastDate = d.Timestamp;
                            lastState = d.Value;
                        }
                        else
                        {
                            switch (lastState)
                            {
                                case 0: totals.Rest += (d.Timestamp - lastDate).TotalSeconds; break;
                                case 1: totals.Available += (d.Timestamp - lastDate).TotalSeconds; break;
                                case 2: totals.Work += (d.Timestamp - lastDate).TotalSeconds; break;
                                case 3: totals.Drive += (d.Timestamp - lastDate).TotalSeconds; break;
                                case 7:
                                    if (!considerNotAvailableAsRest)
                                        totals.NotAvailable += (d.Timestamp - lastDate).TotalSeconds;
                                    else
                                        totals.Rest += (d.Timestamp - lastDate).TotalSeconds;
                                    break;
                            }

                            lastDate = d.Timestamp;
                            lastState = d.Value;
                        }
                    }
                    else
                    {
                        lastRecord = d.Timestamp;
                    }
                }
                if (lastState != -1)
                {
                    switch (lastState)
                    {
                        case 0: totals.Rest += (lastRecord - lastDate).TotalSeconds; break;
                        case 1: totals.Available += (lastRecord - lastDate).TotalSeconds; break;
                        case 2: totals.Work += (lastRecord - lastDate).TotalSeconds; break;
                        case 3: totals.Drive += (lastRecord - lastDate).TotalSeconds; break;
                        case 7: totals.NotAvailable += (lastRecord - lastDate).TotalSeconds; break;
                    }

                }
            }

            return totals;
        }
    }
}
