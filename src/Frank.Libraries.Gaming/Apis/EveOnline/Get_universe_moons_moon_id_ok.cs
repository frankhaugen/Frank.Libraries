using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_moons_moon_id_ok
{
    [JsonConstructor]
    public Get_universe_moons_moon_id_ok(int moon_id, string name, Position3 position, int system_id)

    {
        Moon_id = moon_id;

        Name = name;

        Position = position;

        System_id = system_id;
    }

    /// <summary>
    ///     moon_id integer
    /// </summary>

    [JsonPropertyName("moon_id")]
    public int Moon_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position3 Position { get; init; }

    /// <summary>
    ///     The solar system this moon is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}