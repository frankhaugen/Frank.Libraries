using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated
{
    public class WeaponMounts
    {
        [JsonPropertyName("forward")] public List<Forward> Forward { get; } = new List<Forward>();

        [JsonPropertyName("aft")] public List<object> Aft { get; } = new List<object>();

        [JsonPropertyName("port")] public List<Port> Port { get; } = new List<Port>();

        [JsonPropertyName("starboard")] public List<Starboard> Starboard { get; } = new List<Starboard>();

        [JsonPropertyName("turret")] public List<object> Turret { get; } = new List<object>();
    }
}