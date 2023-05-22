using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_corporations_corporation_id_assets_locations_200_ok
{
    [JsonConstructor]
    public Post_corporations_corporation_id_assets_locations_200_ok(long item_id, Position10 position)

    {
        Item_id = item_id;

        Position = position;
    }

    /// <summary>
    ///     item_id integer
    /// </summary>

    [JsonPropertyName("item_id")]
    public long Item_id { get; init; }

    /// <summary>
    ///     position object
    /// </summary>

    [JsonPropertyName("position")]
    public Position10 Position { get; init; }
}