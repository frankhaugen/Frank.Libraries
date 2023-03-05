using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     pin object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Pins
{
    [JsonConstructor]
    public Pins(IList<Contents>? contents, DateTimeOffset? expiry_time, Extractor_details? extractor_details, Factory_details? factory_details, DateTimeOffset? install_time, DateTimeOffset? last_cycle_start, float latitude, float longitude, long pin_id, int? schematic_id, int type_id)

    {
        Contents = contents;

        Expiry_time = expiry_time;

        Extractor_details = extractor_details;

        Factory_details = factory_details;

        Install_time = install_time;

        Last_cycle_start = last_cycle_start;

        Latitude = latitude;

        Longitude = longitude;

        Pin_id = pin_id;

        Schematic_id = schematic_id;

        Type_id = type_id;
    }

    /// <summary>
    ///     contents array
    /// </summary>

    [JsonPropertyName("contents")]
    public IList<Contents>? Contents { get; init; }

    /// <summary>
    ///     expiry_time string
    /// </summary>

    [JsonPropertyName("expiry_time")]
    public DateTimeOffset? Expiry_time { get; init; }

    /// <summary>
    ///     extractor_details object
    /// </summary>

    [JsonPropertyName("extractor_details")]
    public Extractor_details? Extractor_details { get; init; }

    /// <summary>
    ///     factory_details object
    /// </summary>

    [JsonPropertyName("factory_details")]
    public Factory_details? Factory_details { get; init; }

    /// <summary>
    ///     install_time string
    /// </summary>

    [JsonPropertyName("install_time")]
    public DateTimeOffset? Install_time { get; init; }

    /// <summary>
    ///     last_cycle_start string
    /// </summary>

    [JsonPropertyName("last_cycle_start")]
    public DateTimeOffset? Last_cycle_start { get; init; }

    /// <summary>
    ///     latitude number
    /// </summary>

    [JsonPropertyName("latitude")]
    public float Latitude { get; init; }

    /// <summary>
    ///     longitude number
    /// </summary>

    [JsonPropertyName("longitude")]
    public float Longitude { get; init; }

    /// <summary>
    ///     pin_id integer
    /// </summary>

    [JsonPropertyName("pin_id")]
    public long Pin_id { get; init; }

    /// <summary>
    ///     schematic_id integer
    /// </summary>

    [JsonPropertyName("schematic_id")]
    public int? Schematic_id { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}