using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_asteroid_belts_asteroid_belt_id_ok
{
    [JsonConstructor]
    public Get_universe_asteroid_belts_asteroid_belt_id_ok(string name, Position position, int system_id)

    {
        Name = name;

        Position = position;

        System_id = system_id;
    }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position Position { get; init; }

    /// <summary>
    ///     The solar system this asteroid belt is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }
}