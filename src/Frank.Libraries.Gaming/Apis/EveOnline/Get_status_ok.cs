using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_status_ok
{
    [JsonConstructor]
    public Get_status_ok(int players, string server_version, DateTimeOffset start_time, bool? vip)

    {
        Players = players;

        Server_version = server_version;

        Start_time = start_time;

        Vip = vip;
    }

    /// <summary>
    ///     Current online player count
    /// </summary>

    [JsonPropertyName("players")]
    public int Players { get; init; }

    /// <summary>
    ///     Running version as string
    /// </summary>

    [JsonPropertyName("server_version")]
    public string Server_version { get; init; }

    /// <summary>
    ///     Server start timestamp
    /// </summary>

    [JsonPropertyName("start_time")]
    public DateTimeOffset Start_time { get; init; }

    /// <summary>
    ///     If the server is in VIP mode
    /// </summary>

    [JsonPropertyName("vip")]
    public bool? Vip { get; init; }
}