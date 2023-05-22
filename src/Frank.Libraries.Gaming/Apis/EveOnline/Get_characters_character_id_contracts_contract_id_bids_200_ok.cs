using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_contracts_contract_id_bids_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_contracts_contract_id_bids_200_ok(float amount, int bid_id, int bidder_id, DateTimeOffset date_bid)

    {
        Amount = amount;

        Bid_id = bid_id;

        Bidder_id = bidder_id;

        Date_bid = date_bid;
    }

    /// <summary>
    ///     The amount bid, in ISK
    /// </summary>

    [JsonPropertyName("amount")]
    public float Amount { get; init; }

    /// <summary>
    ///     Unique ID for the bid
    /// </summary>

    [JsonPropertyName("bid_id")]
    public int Bid_id { get; init; }

    /// <summary>
    ///     Character ID of the bidder
    /// </summary>

    [JsonPropertyName("bidder_id")]
    public int Bidder_id { get; init; }

    /// <summary>
    ///     Datetime when the bid was placed
    /// </summary>

    [JsonPropertyName("date_bid")]
    public DateTimeOffset Date_bid { get; init; }
}