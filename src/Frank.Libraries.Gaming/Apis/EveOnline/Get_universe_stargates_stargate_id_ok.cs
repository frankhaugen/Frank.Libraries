using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_stargates_stargate_id_ok
{
    [JsonConstructor]
    public Get_universe_stargates_stargate_id_ok(Destination destination, string name, Position5 position, int stargate_id, int system_id, int type_id)

    {
        Destination = destination;

        Name = name;

        Position = position;

        Stargate_id = stargate_id;

        System_id = system_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     destination object
    /// </summary>

    [JsonPropertyName("destination")]
    public Destination Destination { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position5 Position { get; init; }

    /// <summary>
    ///     stargate_id integer
    /// </summary>

    [JsonPropertyName("stargate_id")]
    public int Stargate_id { get; init; }

    /// <summary>
    ///     The solar system this stargate is in
    /// </summary>

    [JsonPropertyName("system_id")]
    public int System_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}