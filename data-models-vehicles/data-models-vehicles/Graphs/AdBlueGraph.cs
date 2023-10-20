namespace Frotcom.Data.Models.Vehicles
{
    public class AdBlueGraph
    {
        public AdBlueGraph(string key, string description)
        {
            this.Key = key;
            this.Description = description;
        }

        public string Key { get; set; }
        public string Description { get; set; }
        public AdBlueData[] Data { get; set; }
    }
}