using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Victim
{
    [JsonConstructor]
    public Victim(int? alliance_id, int? character_id, int? corporation_id, int damage_taken, int? faction_id, IList<Items3>? items, Position11? position, int ship_type_id)

    {
        Alliance_id = alliance_id;

        Character_id = character_id;

        Corporation_id = corporation_id;

        Damage_taken = damage_taken;

        Faction_id = faction_id;

        Items = items;

        Position = position;

        Ship_type_id = ship_type_id;
    }

    /// <summary>
    ///     alliance_id integer
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     character_id integer
    /// </summary>

    [JsonPropertyName("character_id")]
    public int? Character_id { get; init; }

    /// <summary>
    ///     corporation_id integer
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int? Corporation_id { get; init; }

    /// <summary>
    ///     How much total damage was taken by the victim
    ///     <br />
    /// </summary>

    [JsonPropertyName("damage_taken")]
    public int Damage_taken { get; init; }

    /// <summary>
    ///     faction_id integer
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     items array
    /// </summary>

    [JsonPropertyName("items")]
    public IList<Items3>? Items { get; init; }

    /// <summary>
    ///     Coordinates of the victim in Cartesian space relative to the Sun
    ///     <br />
    /// </summary>

    [JsonPropertyName("position")]
    public Position11? Position { get; init; }

    /// <summary>
    ///     The ship that the victim was piloting and was destroyed
    ///     <br />
    /// </summary>

    [JsonPropertyName("ship_type_id")]
    public int Ship_type_id { get; init; }
}