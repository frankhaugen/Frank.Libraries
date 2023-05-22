using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_assets_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_assets_200_ok(bool? is_blueprint_copy, bool is_singleton, long item_id, Get_corporations_corporation_id_assets_200_okLocation_flag location_flag, long location_id, Get_corporations_corporation_id_assets_200_okLocation_type location_type, int quantity, int type_id)

    {
        Is_blueprint_copy = is_blueprint_copy;

        Is_singleton = is_singleton;

        Item_id = item_id;

        Location_flag = location_flag;

        Location_id = location_id;

        Location_type = location_type;

        Quantity = quantity;

        Type_id = type_id;
    }

    /// <summary>
    ///     is_blueprint_copy boolean
    /// </summary>

    [JsonPropertyName("is_blueprint_copy")]
    public bool? Is_blueprint_copy { get; init; }

    /// <summary>
    ///     is_singleton boolean
    /// </summary>

    [JsonPropertyName("is_singleton")]
    public bool Is_singleton { get; init; }

    /// <summary>
    ///     item_id integer
    /// </summary>

    [JsonPropertyName("item_id")]
    public long Item_id { get; init; }

    /// <summary>
    ///     location_flag string
    /// </summary>

    [JsonPropertyName("location_flag")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_assets_200_okLocation_flag Location_flag { get; init; }

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
    public Get_corporations_corporation_id_assets_200_okLocation_type Location_type { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}