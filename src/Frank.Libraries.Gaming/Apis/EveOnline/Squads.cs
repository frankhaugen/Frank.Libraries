using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     squad object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Squads
{
    [JsonConstructor]
    public Squads(long id, string name)

    {
        Id = id;

        Name = name;
    }

    /// <summary>
    ///     id integer
    /// </summary>

    [JsonPropertyName("id")]
    public long Id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }
}