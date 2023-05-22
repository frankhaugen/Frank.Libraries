using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_markets_structures_structure_id_200_ok
{
    [JsonConstructor]
    public Get_markets_structures_structure_id_200_ok(int duration, bool is_buy_order, DateTimeOffset issued, long location_id, int min_volume, long order_id, double price, Get_markets_structures_structure_id_200_okRange range, int type_id, int volume_remain, int volume_total)

    {
        Duration = duration;

        Is_buy_order = is_buy_order;

        Issued = issued;

        Location_id = location_id;

        Min_volume = min_volume;

        Order_id = order_id;

        Price = price;

        Range = range;

        Type_id = type_id;

        Volume_remain = volume_remain;

        Volume_total = volume_total;
    }

    /// <summary>
    ///     duration integer
    /// </summary>

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    /// <summary>
    ///     is_buy_order boolean
    /// </summary>

    [JsonPropertyName("is_buy_order")]
    public bool Is_buy_order { get; init; }

    /// <summary>
    ///     issued string
    /// </summary>

    [JsonPropertyName("issued")]
    public DateTimeOffset Issued { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     min_volume integer
    /// </summary>

    [JsonPropertyName("min_volume")]
    public int Min_volume { get; init; }

    /// <summary>
    ///     order_id integer
    /// </summary>

    [JsonPropertyName("order_id")]
    public long Order_id { get; init; }

    /// <summary>
    ///     price number
    /// </summary>

    [JsonPropertyName("price")]
    public double Price { get; init; }

    /// <summary>
    ///     range string
    /// </summary>

    [JsonPropertyName("range")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_markets_structures_structure_id_200_okRange Range { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     volume_remain integer
    /// </summary>

    [JsonPropertyName("volume_remain")]
    public int Volume_remain { get; init; }

    /// <summary>
    ///     volume_total integer
    /// </summary>

    [JsonPropertyName("volume_total")]
    public int Volume_total { get; init; }
}