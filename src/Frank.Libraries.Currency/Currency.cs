using System.Text.Json.Serialization;

namespace Frank.Libraries.Currency;

public class Currency
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("timestamp")] public long Timestamp { get; set; }

    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("base")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CurrencyCode Base { get; set; }

    [JsonPropertyName("rates")] public Dictionary<CurrencyCode, decimal> Rates { get; set; }
}