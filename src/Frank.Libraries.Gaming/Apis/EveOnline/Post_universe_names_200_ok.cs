using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_universe_names_200_ok
{
    [JsonConstructor]
    public Post_universe_names_200_ok(Post_universe_names_200_okCategory category, int id, string name)

    {
        Category = category;

        Id = id;

        Name = name;
    }

    /// <summary>
    ///     category string
    /// </summary>

    [JsonPropertyName("category")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Post_universe_names_200_okCategory Category { get; init; }

    /// <summary>
    ///     id integer
    /// </summary>

    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }
}