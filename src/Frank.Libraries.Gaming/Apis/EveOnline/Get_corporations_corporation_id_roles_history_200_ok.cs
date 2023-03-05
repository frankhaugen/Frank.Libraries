using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_roles_history_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_roles_history_200_ok(DateTimeOffset changed_at, int character_id, int issuer_id, IList<New_roles> new_roles, IList<Old_roles> old_roles, Get_corporations_corporation_id_roles_history_200_okRole_type role_type)

    {
        Changed_at = changed_at;

        Character_id = character_id;

        Issuer_id = issuer_id;

        New_roles = new_roles;

        Old_roles = old_roles;

        Role_type = role_type;
    }

    /// <summary>
    ///     changed_at string
    /// </summary>

    [JsonPropertyName("changed_at")]
    public DateTimeOffset Changed_at { get; init; }

    /// <summary>
    ///     The character whose roles are changed
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     ID of the character who issued this change
    /// </summary>

    [JsonPropertyName("issuer_id")]
    public int Issuer_id { get; init; }

    /// <summary>
    ///     new_roles array
    /// </summary>

    [JsonPropertyName("new_roles")]

    // (system.text.json): Add string enum item converter
    public IList<New_roles> New_roles { get; init; }

    /// <summary>
    ///     old_roles array
    /// </summary>

    [JsonPropertyName("old_roles")]

    // (system.text.json): Add string enum item converter
    public IList<Old_roles> Old_roles { get; init; }

    /// <summary>
    ///     role_type string
    /// </summary>

    [JsonPropertyName("role_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_roles_history_200_okRole_type Role_type { get; init; }
}