using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_constellations_constellation_id_ok
{
    [JsonConstructor]
    public Get_universe_constellations_constellation_id_ok(int constellation_id, string name, Position2 position, int region_id, IList<int> systems)

    {
        Constellation_id = constellation_id;

        Name = name;

        Position = position;

        Region_id = region_id;

        Systems = systems;
    }

    /// <summary>
    ///     constellation_id integer
    /// </summary>

    [JsonPropertyName("constellation_id")]
    public int Constellation_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position2 Position { get; init; }

    /// <summary>
    ///     The region this constellation is in
    /// </summary>

    [JsonPropertyName("region_id")]
    public int Region_id { get; init; }

    /// <summary>
    ///     systems array
    /// </summary>

    [JsonPropertyName("systems")]
    public IList<int> Systems { get; init; }
}