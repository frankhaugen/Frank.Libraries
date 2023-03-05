using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_characters_character_id_mining_200_ok
{
    [JsonConstructor]
    public Get_characters_character_id_mining_200_ok(DateTimeOffset date, long quantity, int solar_system_id, int type_id)

    {
        Date = date;

        Quantity = quantity;

        Solar_system_id = solar_system_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     date string
    /// </summary>

    [JsonPropertyName("date")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Date { get; init; }

    /// <summary>
    ///     quantity integer
    /// </summary>

    [JsonPropertyName("quantity")]
    public long Quantity { get; init; }

    /// <summary>
    ///     solar_system_id integer
    /// </summary>

    [JsonPropertyName("solar_system_id")]
    public int Solar_system_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}