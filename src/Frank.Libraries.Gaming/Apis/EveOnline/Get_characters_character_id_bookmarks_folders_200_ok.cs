using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_bookmarks_folders_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_bookmarks_folders_200_ok(int folder_id, string name)

    {
        Folder_id = folder_id;

        Name = name;
    }

    /// <summary>
    ///     folder_id integer
    /// </summary>

    [JsonPropertyName("folder_id")]
    public int Folder_id { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }
}