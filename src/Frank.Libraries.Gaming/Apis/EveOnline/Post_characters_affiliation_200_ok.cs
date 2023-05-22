using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Post_characters_affiliation_200_ok
{
    [JsonConstructor]
    public Post_characters_affiliation_200_ok(int? alliance_id, int character_id, int corporation_id, int? faction_id)

    {
        Alliance_id = alliance_id;

        Character_id = character_id;

        Corporation_id = corporation_id;

        Faction_id = faction_id;
    }

    /// <summary>
    ///     The character's alliance ID, if their corporation is in an alliance
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     The character's ID
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     The character's corporation ID
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int Corporation_id { get; init; }

    /// <summary>
    ///     The character's faction ID, if their corporation is in a faction
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }
}