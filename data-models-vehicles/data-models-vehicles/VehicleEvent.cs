using Frotcom.Data.Models.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Frotcom.Data.Models.Vehicles
{
    public class VehicleEvent
    {
        public long Id { get; set; }
        public int VehicleId { get; set; }
        public long LocationId { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public DateTime Timestamp { get; set; }
        public EventType Type { get; set; }
        public string Place { get; set; }
        public string AdditionalEventName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public string Name
        {
            get
            {
                FieldInfo fi = Type.GetType().GetField(Type.ToString());

                var properties = Type.GetType().GetProperties();

                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                var value = string.Empty;

                if (attributes.Any())
                {
                    value = attributes[0].Description;

                    if (!string.IsNullOrEmpty(AdditionalEventName))
                    {
                        value = string.Format("{0}: {1}", value, AdditionalEventName);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(AdditionalEventName))
                    {
                        value = ExternalData(AdditionalEventName);
                    }
                }
                return value;
            }
            set
            {
            }
        }

        public int Order
        {
            get
            {
                return (int)Type;
            }
            set { }
        }

        public Detail[] Details { get; set; }

        [TypeFormat(TypeFormat.Boolean)]
        public bool? IsIgnitionOn { get; set; }
        [JsonIgnore]
        public bool? Door1 { get; set; }
        [JsonIgnore]
        public bool? Door2 { get; set; }
        [JsonIgnore]
        public bool? Door3 { get; set; }
        [JsonIgnore]
        public bool? Seal1 { get; set; }
        [JsonIgnore]
        public bool? Seal2 { get; set; }
        [JsonIgnore]
        public bool? Seal3 { get; set; }
        [JsonIgnore]
        public bool? Din1 { get; set; }
        [JsonIgnore]
        public bool? Din2 { get; set; }
        [JsonIgnore]
        public bool? Din3 { get; set; }
        [JsonIgnore]
        public double? Ana1 { get; set; }
        [JsonIgnore]
        public double? Ana2 { get; set; }
        [JsonIgnore]
        public double? Ana3 { get; set; }
        [JsonIgnore]
        public double? Tp1 { get; set; }
        [JsonIgnore]
        public double? Tp2 { get; set; }
        [JsonIgnore]
        public double? Tp3 { get; set; }
        [JsonIgnore]
        public double? Tp4 { get; set; }
        [JsonIgnore]
        public double? Tp5 { get; set; }
        [JsonIgnore]
        public double? Tp6 { get; set; }
        [JsonIgnore]
        public double? Tp7 { get; set; }
        [JsonIgnore]
        public double? Tp8 { get; set; }
        [JsonIgnore]
        public double? Tp9 { get; set; }
        [JsonIgnore]
        public double? Tp10 { get; set; }

        public string ExternalData(string additionalEventName)
        {
            /*
               * 0. empty
               * 1. full
               * 2. sealed
               * 3. unsealed
               * 4. purge
               * 5. loading
               * 6. unloading
               * 7. empty unsealed
               * 11. empty sealed
               * 22108. cabinet door opened
               * 22110. cabinet door opened
               * 22100. tamper opened
              */
            string eventData = string.Empty;
            string[] auxEventData = additionalEventName.Split(':').ToArray();

            if (auxEventData.Count() >= 2)
            {
                eventData = auxEventData[1].Replace(" ", "");
            }
            else
            {
                return additionalEventName;
            }

            if (!string.IsNullOrEmpty(eventData))
            {
                int number;
                bool result = Int32.TryParse(string.Format("{0}{1}", eventData[1], eventData[2]), out number);
                if (result)
                {
                    if (number == 21)
                    {
                        result = Int32.TryParse(string.Format("{0}{1}", eventData[3], eventData[4]), out number);
                        if (result)
                        {
                            if (number == 08 || number == 10)
                            {
                                return auxEventData[0] + ": [cabinet-door-open]";
                            }

                            if (number == 00)
                            {
                                return auxEventData[0] + ":[tamper-opened]";
                            }

                            return auxEventData[0] + ":[unknown]";
                        }
                    }
                    else
                    {
                        result = Int32.TryParse(string.Format("{0}{1}", eventData[3], eventData[4]), out number);
                        string tagTrans = string.Empty;

                        switch (number)
                        {
                            case 00:
                                tagTrans = "[empty]";
                                break;
                            case 01:
                                tagTrans = "[full]";
                                break;
                            case 02:
                                tagTrans = "[sealed]";
                                break;
                            case 03:
                                tagTrans = "[unsealed]";
                                break;
                            case 04:
                                tagTrans = "[purge]";
                                break;
                            case 05:
                                tagTrans = "[filling]";
                                break;
                            case 06:
                                tagTrans = "[unloading]";
                                break;
                            case 07:
                                tagTrans = "[empty-unsealed]";
                                break;
                            case 11:
                                tagTrans = "[empty-sealed]";
                                break;
                        }
                        return string.Format("{0}: C{1} - {2}", auxEventData[0], number, tagTrans);
                    }
                }
            }

            return additionalEventName;
        }

        public bool HasNoPower { get; set; }
        public bool HasInvalidGps { get; set; }
        public bool HasInvalidMovement { get; set; }
        public double? Odometer { get; set; }
    }
}
