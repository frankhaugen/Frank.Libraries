using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_attributes_ok
{
    [JsonConstructor]
    public Get_characters_character_id_attributes_ok(DateTimeOffset? accrued_remap_cooldown_date, int? bonus_remaps, int charisma, int intelligence, DateTimeOffset? last_remap_date, int memory, int perception, int willpower)

    {
        Accrued_remap_cooldown_date = accrued_remap_cooldown_date;

        Bonus_remaps = bonus_remaps;

        Charisma = charisma;

        Intelligence = intelligence;

        Last_remap_date = last_remap_date;

        Memory = memory;

        Perception = perception;

        Willpower = willpower;
    }

    /// <summary>
    ///     Neural remapping cooldown after a character uses remap accrued over time
    /// </summary>

    [JsonPropertyName("accrued_remap_cooldown_date")]
    public DateTimeOffset? Accrued_remap_cooldown_date { get; init; }

    /// <summary>
    ///     Number of available bonus character neural remaps
    /// </summary>

    [JsonPropertyName("bonus_remaps")]
    public int? Bonus_remaps { get; init; }

    /// <summary>
    ///     charisma integer
    /// </summary>

    [JsonPropertyName("charisma")]
    public int Charisma { get; init; }

    /// <summary>
    ///     intelligence integer
    /// </summary>

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; init; }

    /// <summary>
    ///     Datetime of last neural remap, including usage of bonus remaps
    /// </summary>

    [JsonPropertyName("last_remap_date")]
    public DateTimeOffset? Last_remap_date { get; init; }

    /// <summary>
    ///     memory integer
    /// </summary>

    [JsonPropertyName("memory")]
    public int Memory { get; init; }

    /// <summary>
    ///     perception integer
    /// </summary>

    [JsonPropertyName("perception")]
    public int Perception { get; init; }

    /// <summary>
    ///     willpower integer
    /// </summary>

    [JsonPropertyName("willpower")]
    public int Willpower { get; init; }
}