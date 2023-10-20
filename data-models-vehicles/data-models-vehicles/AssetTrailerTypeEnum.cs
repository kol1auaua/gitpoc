using System.ComponentModel;

namespace Frotcom.Data.Models.Vehicles
{
    public enum AssetTrailerTypeEnum
    {
        [Description("None")]
        None = 0,
        [Description("Bluetooth Low Energy")]
        BLE = 1,
        [Description("Teltonika Bluetooth Low Energy")]
        TBLE = 2
    }
}
