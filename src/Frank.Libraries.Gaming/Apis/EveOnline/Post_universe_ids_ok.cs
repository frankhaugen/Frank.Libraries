using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_universe_ids_ok
{
    [JsonConstructor]
    public Post_universe_ids_ok(IList<Agents>? agents, IList<Alliances>? alliances, IList<Characters>? characters, IList<Constellations>? constellations, IList<Corporations>? corporations, IList<Factions>? factions, IList<Inventory_types>? inventory_types, IList<Regions>? regions, IList<Stations>? stations, IList<Systems>? systems)

    {
        Agents = agents;

        Alliances = alliances;

        Characters = characters;

        Constellations = constellations;

        Corporations = corporations;

        Factions = factions;

        Inventory_types = inventory_types;

        Regions = regions;

        Stations = stations;

        Systems = systems;
    }

    /// <summary>
    ///     agents array
    /// </summary>

    [JsonPropertyName("agents")]
    public IList<Agents>? Agents { get; init; }

    /// <summary>
    ///     alliances array
    /// </summary>

    [JsonPropertyName("alliances")]
    public IList<Alliances>? Alliances { get; init; }

    /// <summary>
    ///     characters array
    /// </summary>

    [JsonPropertyName("characters")]
    public IList<Characters>? Characters { get; init; }

    /// <summary>
    ///     constellations array
    /// </summary>

    [JsonPropertyName("constellations")]
    public IList<Constellations>? Constellations { get; init; }

    /// <summary>
    ///     corporations array
    /// </summary>

    [JsonPropertyName("corporations")]
    public IList<Corporations>? Corporations { get; init; }

    /// <summary>
    ///     factions array
    /// </summary>

    [JsonPropertyName("factions")]
    public IList<Factions>? Factions { get; init; }

    /// <summary>
    ///     inventory_types array
    /// </summary>

    [JsonPropertyName("inventory_types")]
    public IList<Inventory_types>? Inventory_types { get; init; }

    /// <summary>
    ///     regions array
    /// </summary>

    [JsonPropertyName("regions")]
    public IList<Regions>? Regions { get; init; }

    /// <summary>
    ///     stations array
    /// </summary>

    [JsonPropertyName("stations")]
    public IList<Stations>? Stations { get; init; }

    /// <summary>
    ///     systems array
    /// </summary>

    [JsonPropertyName("systems")]
    public IList<Systems>? Systems { get; init; }
}