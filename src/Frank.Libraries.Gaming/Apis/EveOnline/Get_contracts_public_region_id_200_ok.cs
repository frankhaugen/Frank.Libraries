using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_contracts_public_region_id_200_ok
{
    [JsonConstructor]
    public Get_contracts_public_region_id_200_ok(double? buyout, double? collateral, int contract_id, DateTimeOffset date_expired, DateTimeOffset date_issued, int? days_to_complete, long? end_location_id, bool? for_corporation, int issuer_corporation_id, int issuer_id, double? price, double? reward, long? start_location_id, string? title, Get_contracts_public_region_id_200_okType type, double? volume)

    {
        Buyout = buyout;

        Collateral = collateral;

        Contract_id = contract_id;

        Date_expired = date_expired;

        Date_issued = date_issued;

        Days_to_complete = days_to_complete;

        End_location_id = end_location_id;

        For_corporation = for_corporation;

        Issuer_corporation_id = issuer_corporation_id;

        Issuer_id = issuer_id;

        Price = price;

        Reward = reward;

        Start_location_id = start_location_id;

        Title = title;

        Type = type;

        Volume = volume;
    }

    /// <summary>
    ///     Buyout price (for Auctions only)
    /// </summary>

    [JsonPropertyName("buyout")]
    public double? Buyout { get; init; }

    /// <summary>
    ///     Collateral price (for Couriers only)
    /// </summary>

    [JsonPropertyName("collateral")]
    public double? Collateral { get; init; }

    /// <summary>
    ///     contract_id integer
    /// </summary>

    [JsonPropertyName("contract_id")]
    public int Contract_id { get; init; }

    /// <summary>
    ///     Expiration date of the contract
    /// </summary>

    [JsonPropertyName("date_expired")]
    public DateTimeOffset Date_expired { get; init; }

    /// <summary>
    ///     Сreation date of the contract
    /// </summary>

    [JsonPropertyName("date_issued")]
    public DateTimeOffset Date_issued { get; init; }

    /// <summary>
    ///     Number of days to perform the contract
    /// </summary>

    [JsonPropertyName("days_to_complete")]
    public int? Days_to_complete { get; init; }

    /// <summary>
    ///     End location ID (for Couriers contract)
    /// </summary>

    [JsonPropertyName("end_location_id")]
    public long? End_location_id { get; init; }

    /// <summary>
    ///     true if the contract was issued on behalf of the issuer's corporation
    /// </summary>

    [JsonPropertyName("for_corporation")]
    public bool? For_corporation { get; init; }

    /// <summary>
    ///     Character's corporation ID for the issuer
    /// </summary>

    [JsonPropertyName("issuer_corporation_id")]
    public int Issuer_corporation_id { get; init; }

    /// <summary>
    ///     Character ID for the issuer
    /// </summary>

    [JsonPropertyName("issuer_id")]
    public int Issuer_id { get; init; }

    /// <summary>
    ///     Price of contract (for ItemsExchange and Auctions)
    /// </summary>

    [JsonPropertyName("price")]
    public double? Price { get; init; }

    /// <summary>
    ///     Remuneration for contract (for Couriers only)
    /// </summary>

    [JsonPropertyName("reward")]
    public double? Reward { get; init; }

    /// <summary>
    ///     Start location ID (for Couriers contract)
    /// </summary>

    [JsonPropertyName("start_location_id")]
    public long? Start_location_id { get; init; }

    /// <summary>
    ///     Title of the contract
    /// </summary>

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    ///     Type of the contract
    /// </summary>

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_contracts_public_region_id_200_okType Type { get; init; }

    /// <summary>
    ///     Volume of items in the contract
    /// </summary>

    [JsonPropertyName("volume")]
    public double? Volume { get; init; }
}