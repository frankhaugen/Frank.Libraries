using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_loyalty_stores_corporation_id_offers_200_ok
{
    [JsonConstructor]
    public Get_loyalty_stores_corporation_id_offers_200_ok(int? ak_cost, long isk_cost, int lp_cost, int offer_id, int quantity, IList<Required_items> required_items, int type_id)

    {
        Ak_cost = ak_cost;

        Isk_cost = isk_cost;

        Lp_cost = lp_cost;

        Offer_id = offer_id;

        Quantity = quantity;

        Required_items = required_items;

        Type_id = type_id;
    }

    /// <summary>
    ///     Analysis kredit cost
    /// </summary>

    [JsonPropertyName("ak_cost")]
    public int? Ak_cost { get; init; }

    /// <summary>
    ///     isk_cost integer
    /// </summary>

    [JsonPropertyName("isk_cost")]
    public long Isk_cost { get; init; }

    /// <summary>
    ///     lp_cost integer
    /// </summary>

    [JsonPropertyName("lp_cost")]
    public int Lp_cost { get; init; }

    /// <summary>
    ///     offer_id integer
    /// </summary>

    [JsonPropertyName("offer_id")]
    public int Offer_id { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     required_items array
    /// </summary>

    [JsonPropertyName("required_items")]
    public IList<Required_items> Required_items { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}