using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporation_corporation_id_mining_observers_200_ok
{
    [JsonConstructor]
    public Get_corporation_corporation_id_mining_observers_200_ok(DateTimeOffset last_updated, long observer_id, Get_corporation_corporation_id_mining_observers_200_okObserver_type observer_type)

    {
        Last_updated = last_updated;

        Observer_id = observer_id;

        Observer_type = observer_type;
    }

    /// <summary>
    ///     last_updated string
    /// </summary>

    [JsonPropertyName("last_updated")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Last_updated { get; init; }

    /// <summary>
    ///     The entity that was observing the asteroid field when it was mined.
    ///     <br />
    /// </summary>

    [JsonPropertyName("observer_id")]
    public long Observer_id { get; init; }

    /// <summary>
    ///     The category of the observing entity
    /// </summary>

    [JsonPropertyName("observer_type")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporation_corporation_id_mining_observers_200_okObserver_type Observer_type { get; init; }
}