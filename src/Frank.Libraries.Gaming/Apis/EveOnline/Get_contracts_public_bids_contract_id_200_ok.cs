using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_contracts_public_bids_contract_id_200_ok
{
    [JsonConstructor]
    public Get_contracts_public_bids_contract_id_200_ok(float amount, int bid_id, DateTimeOffset date_bid)

    {
        Amount = amount;

        Bid_id = bid_id;

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
    ///     Datetime when the bid was placed
    /// </summary>

    [JsonPropertyName("date_bid")]
    public DateTimeOffset Date_bid { get; init; }
}