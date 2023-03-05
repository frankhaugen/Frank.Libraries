using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_containers_logs_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_containers_logs_200_ok(Get_corporations_corporation_id_containers_logs_200_okAction action, int character_id, long container_id, int container_type_id, Get_corporations_corporation_id_containers_logs_200_okLocation_flag location_flag, long location_id, DateTimeOffset logged_at, int? new_config_bitmask, int? old_config_bitmask, Get_corporations_corporation_id_containers_logs_200_okPassword_type? password_type, int? quantity, int? type_id)

    {
        Action = action;

        Character_id = character_id;

        Container_id = container_id;

        Container_type_id = container_type_id;

        Location_flag = location_flag;

        Location_id = location_id;

        Logged_at = logged_at;

        New_config_bitmask = new_config_bitmask;

        Old_config_bitmask = old_config_bitmask;

        Password_type = password_type;

        Quantity = quantity;

        Type_id = type_id;
    }

    /// <summary>
    ///     action string
    /// </summary>

    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_containers_logs_200_okAction Action { get; init; }

    /// <summary>
    ///     ID of the character who performed the action.
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     ID of the container
    /// </summary>

    [JsonPropertyName("container_id")]
    public long Container_id { get; init; }

    /// <summary>
    ///     Type ID of the container
    /// </summary>

    [JsonPropertyName("container_type_id")]
    public int Container_type_id { get; init; }

    /// <summary>
    ///     location_flag string
    /// </summary>

    [JsonPropertyName("location_flag")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_containers_logs_200_okLocation_flag Location_flag { get; init; }

    /// <summary>
    ///     location_id integer
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     Timestamp when this log was created
    /// </summary>

    [JsonPropertyName("logged_at")]
    public DateTimeOffset Logged_at { get; init; }

    /// <summary>
    ///     new_config_bitmask integer
    /// </summary>

    [JsonPropertyName("new_config_bitmask")]
    public int? New_config_bitmask { get; init; }

    /// <summary>
    ///     old_config_bitmask integer
    /// </summary>

    [JsonPropertyName("old_config_bitmask")]
    public int? Old_config_bitmask { get; init; }

    /// <summary>
    ///     Type of password set if action is of type SetPassword or EnterPassword
    /// </summary>

    [JsonPropertyName("password_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_containers_logs_200_okPassword_type? Password_type { get; init; }

    /// <summary>
    ///     Quantity of the item being acted upon
    /// </summary>

    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    ///     Type ID of the item being acted upon
    /// </summary>

    [JsonPropertyName("type_id")]
    public int? Type_id { get; init; }
}