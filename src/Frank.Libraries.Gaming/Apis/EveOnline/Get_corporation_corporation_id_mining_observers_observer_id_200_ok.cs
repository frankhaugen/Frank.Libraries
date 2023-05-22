using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporation_corporation_id_mining_observers_observer_id_200_ok
{
    [JsonConstructor]
    public Get_corporation_corporation_id_mining_observers_observer_id_200_ok(int character_id, DateTimeOffset last_updated, long quantity, int recorded_corporation_id, int type_id)

    {
        Character_id = character_id;

        Last_updated = last_updated;

        Quantity = quantity;

        Recorded_corporation_id = recorded_corporation_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     The character that did the mining
    ///     <br />
    /// </summary>

    [JsonPropertyName("character_id")]
    public int Character_id { get; init; }

    /// <summary>
    ///     last_updated string
    /// </summary>

    [JsonPropertyName("last_updated")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Last_updated { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public long Quantity { get; init; }

    /// <summary>
    ///     The corporation id of the character at the time data was recorded.
    ///     <br />
    /// </summary>

    [JsonPropertyName("recorded_corporation_id")]
    public int Recorded_corporation_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}