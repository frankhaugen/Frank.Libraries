using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     jump_clone object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Jump_clones
{
    [JsonConstructor]
    public Jump_clones(IList<int> implants, int jump_clone_id, long location_id, Jump_clonesLocation_type location_type, string? name)

    {
        Implants = implants;

        Jump_clone_id = jump_clone_id;

        Location_id = location_id;

        Location_type = location_type;

        Name = name;
    }

    /// <summary>
    ///     implants array
    /// </summary>

    [JsonPropertyName("implants")]
    public IList<int> Implants { get; init; }

    /// <summary>
    ///     jump_clone_id integer
    /// </summary>

    [JsonPropertyName("jump_clone_id")]
    public int Jump_clone_id { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     location_type string
    /// </summary>

    [JsonPropertyName("location_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Jump_clonesLocation_type Location_type { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}