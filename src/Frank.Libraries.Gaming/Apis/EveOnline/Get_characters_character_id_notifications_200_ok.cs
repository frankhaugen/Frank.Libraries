using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_notifications_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_notifications_200_ok(bool? is_read, long notification_id, int sender_id, Get_characters_character_id_notifications_200_okSender_type sender_type, string? text, DateTimeOffset timestamp, Get_characters_character_id_notifications_200_okType type)

    {
        Is_read = is_read;

        Notification_id = notification_id;

        Sender_id = sender_id;

        Sender_type = sender_type;

        Text = text;

        Timestamp = timestamp;

        Type = type;
    }

    /// <summary>
    ///     is_read boolean
    /// </summary>

    [JsonPropertyName("is_read")]
    public bool? Is_read { get; init; }

    /// <summary>
    ///     notification_id integer
    /// </summary>

    [JsonPropertyName("notification_id")]
    public long Notification_id { get; init; }

    /// <summary>
    ///     sender_id integer
    /// </summary>

    [JsonPropertyName("sender_id")]
    public int Sender_id { get; init; }

    /// <summary>
    ///     sender_type string
    /// </summary>

    [JsonPropertyName("sender_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_notifications_200_okSender_type Sender_type { get; init; }

    /// <summary>
    ///     text string
    /// </summary>

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    /// <summary>
    ///     timestamp string
    /// </summary>

    [JsonPropertyName("timestamp")]
    public DateTimeOffset Timestamp { get; init; }

    /// <summary>
    ///     type string
    /// </summary>

    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_characters_character_id_notifications_200_okType Type { get; init; }
}