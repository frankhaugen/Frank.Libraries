using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_ok
{
    [JsonConstructor]
    public Get_characters_character_id_ok(int? alliance_id, DateTimeOffset birthday, int bloodline_id, int corporation_id, string? description, int? faction_id, Get_characters_character_id_okGender gender, string name, int race_id, float? security_status, string? title)

    {
        Alliance_id = alliance_id;

        Birthday = birthday;

        Bloodline_id = bloodline_id;

        Corporation_id = corporation_id;

        Description = description;

        Faction_id = faction_id;

        Gender = gender;

        Name = name;

        Race_id = race_id;

        Security_status = security_status;

        Title = title;
    }

    /// <summary>
    ///     The character's alliance ID
    /// </summary>

    [JsonPropertyName("alliance_id")]
    public int? Alliance_id { get; init; }

    /// <summary>
    ///     Creation date of the character
    /// </summary>

    [JsonPropertyName("birthday")]
    public DateTimeOffset Birthday { get; init; }

    /// <summary>
    ///     bloodline_id integer
    /// </summary>

    [JsonPropertyName("bloodline_id")]
    public int Bloodline_id { get; init; }

    /// <summary>
    ///     The character's corporation ID
    /// </summary>

    [JsonPropertyName("corporation_id")]
    public int Corporation_id { get; init; }

    /// <summary>
    ///     description string
    /// </summary>

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    ///     ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
    /// </summary>

    [JsonPropertyName("faction_id")]
    public int? Faction_id { get; init; }

    /// <summary>
    ///     gender string
    /// </summary>

    [JsonPropertyName("gender")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_okGender Gender { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    ///     race_id integer
    /// </summary>

    [JsonPropertyName("race_id")]
    public int Race_id { get; init; }

    /// <summary>
    ///     security_status number
    /// </summary>

    [JsonPropertyName("security_status")]
    public float? Security_status { get; init; }

    /// <summary>
    ///     The individual title of the character
    /// </summary>

    [JsonPropertyName("title")]
    public string? Title { get; init; }
}