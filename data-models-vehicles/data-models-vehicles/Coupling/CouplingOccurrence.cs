using Frotcom.Data.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Frotcom.Data.Models.Vehicles
{
    public class CouplingOccurrence
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public DateTime? CoupledOn { get; set; }
        public string CoupledAddress { get; set; }
        public LatLng CoupledCoordinates { get; set; }
        public int? CoupledPlaceId { get; set; }
        public DateTime? UnCoupledOn { get; set; }
        public string UnCoupledAddress { get; set; }
        public LatLng UnCoupledCoordinates { get; set; }
        public int? UnCoupledPlaceId { get; set; }
        public string UserName { get; set; }

        public static CouplingOccurrence[] BuildCouplingOccurrences(CouplingEvent[] events)
        {
            events = events.OrderBy(x => x.Timestamp).ToArray();

            List<CouplingOccurrence> occurrences = new List<CouplingOccurrence>();

            foreach (CouplingEvent evt in events)
            {
                if (evt.Type == CouplingType.Coupling)
                {
                    occurrences.AddRange(CreateCouplingOccurences(evt));
                }
                else
                {
                    occurrences.AddRange(CreateUncouplingOccurences(evt));
                }
            }

            return occurrences.ToArray();
        }

        private static CouplingOccurrence[] CreateCouplingOccurences(CouplingEvent couplingEvent)
        {
            bool hasCoordinates = couplingEvent.Latitude.HasValue && couplingEvent.Longitude.HasValue;
            LatLng coordinates = hasCoordinates ? new LatLng() { Latitude = couplingEvent.Latitude.Value, Longitude = couplingEvent.Longitude.Value } : null;

            List<CouplingOccurrence> occurrences = new List<CouplingOccurrence>
            {
                new CouplingOccurrence
                {
                    VehicleId = couplingEvent.AssetId,
                    LicensePlate = couplingEvent.AssetLicensePlate,
                    UserName = couplingEvent.User,
                    CoupledOn = couplingEvent.Timestamp.Value,
                    CoupledAddress = couplingEvent.Address,
                    CoupledPlaceId = couplingEvent.PlaceId,
                    CoupledCoordinates = coordinates
                }
            };

            return occurrences.ToArray();
        }

        private static CouplingOccurrence[] CreateUncouplingOccurences(CouplingEvent uncouplingEvent)
        {
            bool hasUncouplingCoordinates = uncouplingEvent.Latitude.HasValue && uncouplingEvent.Longitude.HasValue;
            LatLng uncouplingCoordinates = hasUncouplingCoordinates ? new LatLng() { Latitude = uncouplingEvent.Latitude.Value, Longitude = uncouplingEvent.Longitude.Value } : null;

            List<CouplingOccurrence> occurrences = new List<CouplingOccurrence>
            {
                new CouplingOccurrence
                {
                    VehicleId = uncouplingEvent.AssetId,
                    LicensePlate = uncouplingEvent.AssetLicensePlate,
                    UserName = uncouplingEvent.User,

                    UnCoupledOn = uncouplingEvent.Timestamp.Value,
                    UnCoupledAddress = uncouplingEvent.Address,
                    UnCoupledPlaceId = uncouplingEvent.PlaceId,
                    UnCoupledCoordinates = uncouplingCoordinates
                }
            };

            return occurrences.ToArray();
        }
    }
}
