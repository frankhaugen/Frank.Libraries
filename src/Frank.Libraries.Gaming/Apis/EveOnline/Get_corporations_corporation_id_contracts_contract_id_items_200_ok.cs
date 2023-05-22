using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_contracts_contract_id_items_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_contracts_contract_id_items_200_ok(bool is_included, bool is_singleton, int quantity, int? raw_quantity, long record_id, int type_id)

    {
        Is_included = is_included;

        Is_singleton = is_singleton;

        Quantity = quantity;

        Raw_quantity = raw_quantity;

        Record_id = record_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item
    ///     in the contract
    /// </summary>

    [JsonPropertyName("is_included")]
    public bool Is_included { get; init; }

    /// <summary>
    ///     is_singleton boolean
    /// </summary>

    [JsonPropertyName("is_singleton")]
    public bool Is_singleton { get; init; }

    /// <summary>
    ///     Number of items in the stack
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original
    ///     and -2 is a Blueprint Copy
    /// </summary>

    [JsonPropertyName("raw_quantity")]
    public int? Raw_quantity { get; init; }

    /// <summary>
    ///     Unique ID for the item
    /// </summary>

    [JsonPropertyName("record_id")]
    public long Record_id { get; init; }

    /// <summary>
    ///     Type ID for item
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}