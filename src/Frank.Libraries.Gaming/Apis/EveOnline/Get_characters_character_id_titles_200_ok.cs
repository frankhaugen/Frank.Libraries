using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_titles_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_titles_200_ok(string? name, int? title_id)

    {
        Name = name;

        Title_id = title_id;
    }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    ///     title_id integer
    /// </summary>

    [JsonPropertyName("title_id")]
    public int? Title_id { get; init; }
}