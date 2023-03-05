using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     wallet transaction
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_wallets_division_transactions_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_wallets_division_transactions_200_ok(int client_id, DateTimeOffset date, bool is_buy, long journal_ref_id, long location_id, int quantity, long transaction_id, int type_id, double unit_price)

    {
        Client_id = client_id;

        Date = date;

        Is_buy = is_buy;

        Journal_ref_id = journal_ref_id;

        Location_id = location_id;

        Quantity = quantity;

        Transaction_id = transaction_id;

        Type_id = type_id;

        Unit_price = unit_price;
    }

    /// <summary>
    ///     client_id integer
    /// </summary>

    [JsonPropertyName("client_id")]
    public int Client_id { get; init; }

    /// <summary>
    ///     Date and time of transaction
    /// </summary>

    [JsonPropertyName("date")]
    public DateTimeOffset Date { get; init; }

    /// <summary>
    ///     is_buy boolean
    /// </summary>

    [JsonPropertyName("is_buy")]
    public bool Is_buy { get; init; }

    /// <summary>
    ///     -1 if there is no corresponding wallet journal entry
    /// </summary>

    [JsonPropertyName("journal_ref_id")]
    public long Journal_ref_id { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     Unique transaction ID
    /// </summary>

    [JsonPropertyName("transaction_id")]
    public long Transaction_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }

    /// <summary>
    ///     Amount paid per unit
    /// </summary>

    [JsonPropertyName("unit_price")]
    public double Unit_price { get; init; }
}