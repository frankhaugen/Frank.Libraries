using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_systems_system_id_ok
{
    [JsonConstructor]
    public Get_universe_systems_system_id_ok(int constellation_id, string name, IList<Planets>? planets, Position8 position, string? security_class, float security_status, int? star_id, IList<int>? stargates, IList<int>? stations, int system_id)

    {
        Constellation_id = constellation_id;

        Name = name;

        Planets = planets;

        Position = position;

        Security_class = security_class;

        Security_status = security_status;

        Star_id = star_id;

        Stargates = stargates;

        Stations = stations;

        System_id = system_id;
    }

    /// <summary>
    ///     The constellation this solar system is in
    /// </summary>

    [JsonPropertyName("constellation_id")]
    public int Constellation_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     planets array
    /// </summary>

    [JsonPropertyName("planets")]
    public IList<Planets>? Planets { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position8 Position { get; init; }

    /// <summary>
    ///     security_class string
    /// </summary>

    [JsonPropertyName("security_class")]
    public string? Security_class { get; init; }

    /// <summary>
    ///     security_status number
    /// </summary>

    [JsonPropertyName("security_status")]
    public float Security_status { get; init; }

    /// <summary>
    ///     star_id integer
    /// </summary>

    [JsonPropertyName("star_id")]
    public int? Star_id { get; init; }

    /// <summary>
    ///     stargates array
    /// </summary>

    [JsonPropertyName("stargates")]
    public IList<int>? Stargates { get; init; }

    /// <summary>
    ///     stations array
    /// </summary>

    [JsonPropertyName("stations")]
    public IList<int>? Stations { get; init; }

    /// <summary>
    ///     system_id integer
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}