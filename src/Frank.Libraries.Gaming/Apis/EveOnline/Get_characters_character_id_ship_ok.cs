using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_ship_ok
{
    [JsonConstructor]
    public Get_characters_character_id_ship_ok(long ship_item_id, string ship_name, int ship_type_id)

    {
        Ship_item_id = ship_item_id;

        Ship_name = ship_name;

        Ship_type_id = ship_type_id;
    }

    /// <summary>
    ///     Item id's are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of
    ///     a ship, or detect when a pilot changes into a different instance of the same ship type.
    /// </summary>

    [JsonPropertyName("ship_item_id")]
    public long Ship_item_id { get; init; }

    /// <summary>
    ///     ship_name string
    /// </summary>

    [JsonPropertyName("ship_name")]
    public string Ship_name { get; init; }

    /// <summary>
    ///     ship_type_id integer
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int Ship_type_id { get; init; }
}