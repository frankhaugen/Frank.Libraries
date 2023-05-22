using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_search_ok
{
    [JsonConstructor]
    public Get_search_ok(IList<int>? agent, IList<int>? alliance, IList<int>? character, IList<int>? constellation, IList<int>? corporation, IList<int>? faction, IList<int>? inventory_type, IList<int>? region, IList<int>? solar_system, IList<int>? station)

    {
        Agent = agent;

        Alliance = alliance;

        Character = character;

        Constellation = constellation;

        Corporation = corporation;

        Faction = faction;

        Inventory_type = inventory_type;

        Region = region;

        Solar_system = solar_system;

        Station = station;
    }

    /// <summary>
    ///     agent array
    /// </summary>

    [JsonPropertyName("agent")]
    public IList<int>? Agent { get; init; }

    /// <summary>
    ///     alliance array
    /// </summary>

    [JsonPropertyName("alliance")]
    public IList<int>? Alliance { get; init; }

    /// <summary>
    ///     character array
    /// </summary>

    [JsonPropertyName("character")]
    public IList<int>? Character { get; init; }

    /// <summary>
    ///     constellation array
    /// </summary>

    [JsonPropertyName("constellation")]
    public IList<int>? Constellation { get; init; }

    /// <summary>
    ///     corporation array
    /// </summary>

    [JsonPropertyName("corporation")]
    public IList<int>? Corporation { get; init; }

    /// <summary>
    ///     faction array
    /// </summary>

    [JsonPropertyName("faction")]
    public IList<int>? Faction { get; init; }

    /// <summary>
    ///     inventory_type array
    /// </summary>

    [JsonPropertyName("inventory_type")]
    public IList<int>? Inventory_type { get; init; }

    /// <summary>
    ///     region array
    /// </summary>

    [JsonPropertyName("region")]
    public IList<int>? Region { get; init; }

    /// <summary>
    ///     solar_system array
    /// </summary>

    [JsonPropertyName("solar_system")]
    public IList<int>? Solar_system { get; init; }

    /// <summary>
    ///     station array
    /// </summary>

    [JsonPropertyName("station")]
    public IList<int>? Station { get; init; }
}