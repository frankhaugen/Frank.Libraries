using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_bookmarks_folders_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_bookmarks_folders_200_ok(int? creator_id, int folder_id, string name)

    {
        Creator_id = creator_id;

        Folder_id = folder_id;

        Name = name;
    }

    /// <summary>
    ///     creator_id integer
    /// </summary>

    [JsonPropertyName("creator_id")]
    public int? Creator_id { get; init; }

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