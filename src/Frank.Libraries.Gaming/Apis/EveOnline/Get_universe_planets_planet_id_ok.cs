using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_planets_planet_id_ok
{
    [JsonConstructor]
    public Get_universe_planets_planet_id_ok(string name, int planet_id, Position4 position, int system_id, int type_id)

    {
        Name = name;

        Planet_id = planet_id;

        Position = position;

        System_id = system_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     planet_id integer
    /// </summary>

    [JsonPropertyName("planet_id")]
    public int Planet_id { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position4 Position { get; init; }

    /// <summary>
    ///     The solar system this planet is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}