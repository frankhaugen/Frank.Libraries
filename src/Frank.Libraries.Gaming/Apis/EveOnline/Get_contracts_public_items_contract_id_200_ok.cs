using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_contracts_public_items_contract_id_200_ok
{
    [JsonConstructor]
    public Get_contracts_public_items_contract_id_200_ok(bool? is_blueprint_copy, bool is_included, long? item_id, int? material_efficiency, int quantity, long record_id, int? runs, int? time_efficiency, int type_id)

    {
        Is_blueprint_copy = is_blueprint_copy;

        Is_included = is_included;

        Item_id = item_id;

        Material_efficiency = material_efficiency;

        Quantity = quantity;

        Record_id = record_id;

        Runs = runs;

        Time_efficiency = time_efficiency;

        Type_id = type_id;
    }

    /// <summary>
    ///     is_blueprint_copy boolean
    /// </summary>

    [JsonPropertyName("is_blueprint_copy")]
    public bool? Is_blueprint_copy { get; init; }

    /// <summary>
    ///     true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item
    ///     in the contract
    /// </summary>

    [JsonPropertyName("is_included")]
    public bool Is_included { get; init; }

    /// <summary>
    ///     Unique ID for the item being sold. Not present if item is being requested by contract rather than sold with
    ///     contract
    /// </summary>

    [JsonPropertyName("item_id")]
    public long? Item_id { get; init; }

    /// <summary>
    ///     Material Efficiency Level of the blueprint
    /// </summary>

    [JsonPropertyName("material_efficiency")]
    public int? Material_efficiency { get; init; }

    /// <summary>
    ///     Number of items in the stack
    /// </summary>

    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }

    /// <summary>
    ///     Unique ID for the item, used by the contract system
    /// </summary>

    [JsonPropertyName("record_id")]
    public long Record_id { get; init; }

    /// <summary>
    ///     Number of runs remaining if the blueprint is a copy, -1 if it is an original
    /// </summary>

    [JsonPropertyName("runs")]
    public int? Runs { get; init; }

    /// <summary>
    ///     Time Efficiency Level of the blueprint
    /// </summary>

    [JsonPropertyName("time_efficiency")]
    public int? Time_efficiency { get; init; }

    /// <summary>
    ///     Type ID for item
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}