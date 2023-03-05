using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_markets_region_id_history_200_ok
{
    [JsonConstructor]
    public Get_markets_region_id_history_200_ok(double average, DateTimeOffset date, double highest, double lowest, long order_count, long volume)

    {
        Average = average;

        Date = date;

        Highest = highest;

        Lowest = lowest;

        Order_count = order_count;

        Volume = volume;
    }

    /// <summary>
    ///     average number
    /// </summary>

    [JsonPropertyName("average")]
    public double Average { get; init; }

    /// <summary>
    ///     The date of this historical statistic entry
    /// </summary>

    [JsonPropertyName("date")]
    [JsonConverter(typeof(DateFormatConverter))]
    public DateTimeOffset Date { get; init; }

    /// <summary>
    ///     highest number
    /// </summary>

    [JsonPropertyName("highest")]
    public double Highest { get; init; }

    /// <summary>
    ///     lowest number
    /// </summary>

    [JsonPropertyName("lowest")]
    public double Lowest { get; init; }

    /// <summary>
    ///     Total number of orders happened that day
    /// </summary>

    [JsonPropertyName("order_count")]
    public long Order_count { get; init; }

    /// <summary>
    ///     Total
    /// </summary>

    [JsonPropertyName("volume")]
    public long Volume { get; init; }
}