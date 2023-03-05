using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_dogma_dynamic_items_type_id_item_id_ok
{
    [JsonConstructor]
    public Get_dogma_dynamic_items_type_id_item_id_ok(int created_by, IList<Dogma_attributes> dogma_attributes, IList<Dogma_effects> dogma_effects, int mutator_type_id, int source_type_id)

    {
        Created_by = created_by;

        Dogma_attributes = dogma_attributes;

        Dogma_effects = dogma_effects;

        Mutator_type_id = mutator_type_id;

        Source_type_id = source_type_id;
    }

    /// <summary>
    ///     The ID of the character who created the item
    /// </summary>

    [JsonPropertyName("created_by")]
    public int Created_by { get; init; }

    /// <summary>
    ///     dogma_attributes array
    /// </summary>

    [JsonPropertyName("dogma_attributes")]
    public IList<Dogma_attributes> Dogma_attributes { get; init; }

    /// <summary>
    ///     dogma_effects array
    /// </summary>

    [JsonPropertyName("dogma_effects")]
    public IList<Dogma_effects> Dogma_effects { get; init; }

    /// <summary>
    ///     The type ID of the mutator used to generate the dynamic item.
    /// </summary>

    [JsonPropertyName("mutator_type_id")]
    public int Mutator_type_id { get; init; }

    /// <summary>
    ///     The type ID of the source item the mutator was applied to create the dynamic item.
    /// </summary>

    [JsonPropertyName("source_type_id")]
    public int Source_type_id { get; init; }
}