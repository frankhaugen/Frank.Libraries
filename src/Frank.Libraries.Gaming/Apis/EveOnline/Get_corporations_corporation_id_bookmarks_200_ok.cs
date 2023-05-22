using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_bookmarks_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_bookmarks_200_ok(int bookmark_id, Coordinates2? coordinates, DateTimeOffset created, int creator_id, int? folder_id, Item2? item, string label, int location_id, string notes)

    {
        Bookmark_id = bookmark_id;

        Coordinates = coordinates;

        Created = created;

        Creator_id = creator_id;

        Folder_id = folder_id;

        Item = item;

        Label = label;

        Location_id = location_id;

        Notes = notes;
    }

    /// <summary>
    ///     bookmark_id integer
    /// </summary>

    [JsonPropertyName("bookmark_id")]
    public int Bookmark_id { get; init; }

    /// <summary>
    ///     Optional object that is returned if a bookmark was made on a planet or a random location in space.
    /// </summary>

    [JsonPropertyName("coordinates")]
    public Coordinates2? Coordinates { get; init; }

    /// <summary>
    ///     created string
    /// </summary>

    [JsonPropertyName("created")]
    public DateTimeOffset Created { get; init; }

    /// <summary>
    ///     creator_id integer
    /// </summary>

    [JsonPropertyName("creator_id")]
    public int Creator_id { get; init; }

    /// <summary>
    ///     folder_id integer
    /// </summary>

    [JsonPropertyName("folder_id")]
    public int? Folder_id { get; init; }

    /// <summary>
    ///     Optional object that is returned if a bookmark was made on a particular item.
    /// </summary>

    [JsonPropertyName("item")]
    public Item2? Item { get; init; }

    /// <summary>
    ///     label string
    /// </summary>

    [JsonPropertyName("label")]
    public string Label { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public int Location_id { get; init; }

    /// <summary>
    ///     notes string
    /// </summary>

    [JsonPropertyName("notes")]
    public string Notes { get; init; }
}