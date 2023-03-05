using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_medals_issued_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_medals_issued_200_ok(int character_id, DateTimeOffset issued_at, int issuer_id, int medal_id, string reason, Get_corporations_corporation_id_medals_issued_200_okStatus status)

    {
        Character_id = character_id;

        Issued_at = issued_at;

        Issuer_id = issuer_id;

        Medal_id = medal_id;

        Reason = reason;

        Status = status;
    }

    /// <summary>
    ///     ID of the character who was rewarded this medal
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     issued_at string
    /// </summary>

    [JsonPropertyName("issued_at")]
    public DateTimeOffset Issued_at { get; init; }

    /// <summary>
    ///     ID of the character who issued the medal
    /// </summary>

    [JsonPropertyName("issuer_id")]
    public int Issuer_id { get; init; }

    /// <summary>
    ///     medal_id integer
    /// </summary>

    [JsonPropertyName("medal_id")]
    public int Medal_id { get; init; }

    /// <summary>
    ///     reason string
    /// </summary>

    [JsonPropertyName("reason")]
    public string Reason { get; init; }

    /// <summary>
    ///     status string
    /// </summary>

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_medals_issued_200_okStatus Status { get; init; }
}