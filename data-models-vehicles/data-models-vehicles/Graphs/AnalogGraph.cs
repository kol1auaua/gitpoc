namespace Frotcom.Data.Models.Vehicles
{
    public class AnalogGraph
    {
        public AnalogGraph(string key, string description)
        {
            this.Key = key;
            this.Description = description;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public AnalogData[] Data { get; set; }
        public AnalogRange[] Ranges { get; set; }
    }
}
