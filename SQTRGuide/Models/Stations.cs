using SQTRGuide.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SQTRGuide.Models
{
    public class Station
    {
        public string ShortCode { get; init; }

        public string Name { get; init; }

        public Platform[] Platforms { get; init; }


        public static Station[] AllStations { get; private set; }
        static Station()
        {
            AllStations = JsonUtils.Read<Station[]>("Assets/data.json");
        }

        public static Station GetStationFromShortCode(string shortCode) => AllStations.Where(x => x.ShortCode == shortCode).First();
    }

    public class Platform
    {
        public string Name { get; init; }

        public string LeftName { get; init; }
        public int LeftDistance { get; init; }

        public string RightName { get; init; }
        public int RightDistance { get; init; }

        public string[] Flags { get; init; }

        [JsonIgnore]
        public bool IsAirCS => Flags.Contains("AirCS");

        [JsonIgnore]
        public bool IsSkyrail => Flags.Contains("Skyrail");

        [JsonIgnore]
        public bool IsUnidirectional => IsAirCS;
    }
}
