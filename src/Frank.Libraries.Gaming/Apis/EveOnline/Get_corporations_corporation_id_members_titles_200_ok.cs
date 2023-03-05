using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_members_titles_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_members_titles_200_ok(int character_id, IList<int> titles)

    {
        Character_id = character_id;

        Titles = titles;
    }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     A list of title_id
    /// </summary>

    [JsonPropertyName("titles")]
    public IList<int> Titles { get; init; }
}