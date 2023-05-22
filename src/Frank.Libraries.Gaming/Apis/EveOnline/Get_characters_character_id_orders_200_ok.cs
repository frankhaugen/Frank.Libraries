using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_orders_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_orders_200_ok(int duration, double? escrow, bool? is_buy_order, bool is_corporation, DateTimeOffset issued, long location_id, int? min_volume, long order_id, double price, Get_characters_character_id_orders_200_okRange range, int region_id, int type_id, int volume_remain, int volume_total)

    {
        Duration = duration;

        Escrow = escrow;

        Is_buy_order = is_buy_order;

        Is_corporation = is_corporation;

        Issued = issued;

        Location_id = location_id;

        Min_volume = min_volume;

        Order_id = order_id;

        Price = price;

        Range = range;

        Region_id = region_id;

        Type_id = type_id;

        Volume_remain = volume_remain;

        Volume_total = volume_total;
    }

    /// <summary>
    ///     Number of days for which order is valid (starting from the issued date). An order expires at time issued + duration
    /// </summary>

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    /// <summary>
    ///     For buy orders, the amount of ISK in escrow
    /// </summary>

    [JsonPropertyName("escrow")]
    public double? Escrow { get; init; }

    /// <summary>
    ///     True if the order is a bid (buy) order
    /// </summary>

    [JsonPropertyName("is_buy_order")]
    public bool? Is_buy_order { get; init; }

    /// <summary>
    ///     Signifies whether the buy/sell order was placed on behalf of a corporation.
    /// </summary>

    [JsonPropertyName("is_corporation")]
    public bool Is_corporation { get; init; }

    /// <summary>
    ///     Date and time when this order was issued
    /// </summary>

    [JsonPropertyName("issued")]
    public DateTimeOffset Issued { get; init; }

    /// <summary>
    ///     ID of the location where order was placed
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     For buy orders, the minimum quantity that will be accepted in a matching sell order
    /// </summary>

    [JsonPropertyName("min_volume")]
    public int? Min_volume { get; init; }

    /// <summary>
    ///     Unique order ID
    /// </summary>

    [JsonPropertyName("order_id")]
    public long Order_id { get; init; }

    /// <summary>
    ///     Cost per unit for this order
    /// </summary>

    [JsonPropertyName("price")]
    public double Price { get; init; }

    /// <summary>
    ///     Valid order range, numbers are ranges in jumps
    /// </summary>

    [JsonPropertyName("range")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_orders_200_okRange Range { get; init; }

    /// <summary>
    ///     ID of the region where order was placed
    /// </summary>

    [JsonPropertyName("region_id")]
    public int Region_id { get; init; }

    /// <summary>
    ///     The type ID of the item transacted in this order
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     Quantity of items still required or offered
    /// </summary>

    [JsonPropertyName("volume_remain")]
    public int Volume_remain { get; init; }

    /// <summary>
    ///     Quantity of items required or offered at time order was placed
    /// </summary>

    [JsonPropertyName("volume_total")]
    public int Volume_total { get; init; }
}