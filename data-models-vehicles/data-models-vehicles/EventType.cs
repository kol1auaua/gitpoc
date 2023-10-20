using System.ComponentModel;

namespace Frotcom.Data.Models.Vehicles
{
    public enum EventType
    {
        [Description("[position-recorded]")]
        Position = -1,
        [Description("none")]
        None = 0,
        [Description("[ignition-on]")]
        IgnitionOn = 1,
        [Description("[ignition-off]")]
        IgnitionOff = 2,
        [Description("[door-opened] 1")]
        DoorOpened = 3,
        [Description("[door-closed] 1")]
        DoorClosed = 4,
        [Description("[driver-changed]")]
        DriverChanged = 5,
        [Description("[tractor-changed]")]
        TractorChanged = 6,
        [Description("[digital-input-1-on]")]
        Din1On = 7,
        [Description("[digital-input-1-off]")]
        Din1Off = 8,
        [Description("[door-seal-1-opened]")]
        DoorSeal1Opened = 9,
        [Description("[door-seal-1-closed]")]
        DoorSeal1Closed = 10,
        [Description("[door-seal-2-opened]")]
        DoorSeal2Opened = 11,
        [Description("[door-seal-2-closed]")]
        DoorSeal2Closed = 12,
        [Description("[door-seal-3-opened]")]
        DoorSeal3Opened = 13,
        [Description("[door-seal-3-closed]")]
        DoorSeal3Closed = 14,
        [Description("[door-opened] 2")]
        DoorOpened2 = 15,
        [Description("[door-closed] 2")]
        DoorClosed2 = 16,
        [Description("[door-opened] 3")]
        DoorOpened3 = 17,
        [Description("[door-closed] 3")]
        DoorClosed3 = 18,
        [Description("[digital-input-2-on]")]
        Din2On = 19,
        [Description("[digital-input-2-off]")]
        Din2Off = 20,
        [Description("[digital-input-3-on]")]
        Din3On = 21,
        [Description("[digital-input-3-off]")]
        Din3Off = 22,
        [Description("[device-power-up]")]
        DevicePowerUp = 23,
        [Description("[ecodriving-automatic-calibration]")]
        EcoDrivingCalibration = 24,
        [Description("[obd-dongle-installed]")]
        OBDDongleInstalled = 25,
        [Description("[privacy-mode-activated-by-driver]")]
        PMActivatedByDriver = 26,
        [Description("[privacy-mode-deactivated-by-driver]")]
        PMDeactivatedByDriver = 27,
        [Description("[elb-locker-on]")]
        ELBLock = 28,
        [Description("[elb-locker-off]")]
        ELBUnlock = 29,
        [Description("[beginning-trip]")]
        StartTrip = 101,
        [Description("[end-trip]")]
        EndTrip = 102,
        [Description("[beginning-privacy-mode]")]
        StartPrivacyTrip = 103,
        [Description("[end-privacy-mode]")]
        EndPrivacyTrip = 104,
        [Description("[coupling]")]
        Coupling = 105,
        [Description("[uncoupling]")]
        Uncoupling = 106,
        ExternalData = 107,
        [Description("[driver-activity]")]
        JobActivity = 108
    }
}
