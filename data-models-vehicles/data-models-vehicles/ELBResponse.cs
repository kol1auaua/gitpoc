namespace Frotcom.Data.Models.Vehicles
{
    public enum ELBResponse
    {
        MasterPinUpdated = 1,
        ProblemsSettingMasterPin = 2,
        DriverPinUpdated = 3,
        ProblemsSettingDriverPin = 4,
        SystemLocked = 5,
        UnlockedByMasterPin = 6,
        UnlockedByDriverPin = 7,
        UnlockedRemotely = 8,
        Unlocked = 9
    }
}