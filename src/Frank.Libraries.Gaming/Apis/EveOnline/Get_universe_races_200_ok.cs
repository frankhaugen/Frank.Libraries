using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_universe_races_200_ok
{
    [JsonConstructor]
    public Get_universe_races_200_ok(int alliance_id, string description, string name, int race_id)

    {
        Alliance_id = alliance_id;

        Description = description;

        Name = name;

        Race_id = race_id;
    }

    /// <summary>
    ///     The alliance generally associated with this race
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int Alliance_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string Description { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     race_id integer
    /// </summary>

    [JsonPropertyName("race_id")]
    public int Race_id { get; init; }
}