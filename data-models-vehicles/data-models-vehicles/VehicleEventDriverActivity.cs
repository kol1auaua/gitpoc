using Frotcom.Data.Models.Base;
using System.ComponentModel;

namespace Frotcom.Data.Models.Vehicles
{
    public partial class VehicleEventDetail
    {
        [Description("[duration]")]
        [TypeFormat(TypeFormat.Duration)]
        public int? Duration { get; set; }
        public int? FormId { get; set; }

        public int? JobId { get; set; }

        [Description("[form]")]
        public string FormName { get; set; }

        public int? TaskOrder { get; set; }

        public string JobCode { get; set; }

        [Description("[task]")]
        public string JobTaskOrder
        {
            get
            {
                if (JobId.HasValue && TaskOrder.HasValue)
                {
                    return string.Format("{0} - {1}", JobId.Value, TaskOrder.Value);
                }
                return null;
            }
            set
            {
            }
        }
    }
}
