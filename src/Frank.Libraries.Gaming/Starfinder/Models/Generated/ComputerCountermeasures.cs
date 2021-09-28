using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class ComputerCountermeasures
    {
        [JsonPropertyName("alarm")]
        public bool Alarm { get; set; }

        [JsonPropertyName("fakeShell")]
        public bool FakeShell { get; set; }

        [JsonPropertyName("feedback")]
        public bool Feedback { get; set; }

        [JsonPropertyName("firewall")]
        public bool Firewall { get; set; }

        [JsonPropertyName("lockout")]
        public bool Lockout { get; set; }

        [JsonPropertyName("shockGridId")]
        public string ShockGridId { get; set; }

        [JsonPropertyName("wipe")]
        public bool Wipe { get; set; }
    }

}