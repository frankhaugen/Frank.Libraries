using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_markets_prices_200_ok
{
    [JsonConstructor]
    public Get_markets_prices_200_ok(double? adjusted_price, double? average_price, int type_id)

    {
        Adjusted_price = adjusted_price;

        Average_price = average_price;

        Type_id = type_id;
    }

    /// <summary>
    ///     adjusted_price number
    /// </summary>

    [JsonPropertyName("adjusted_price")]
    public double? Adjusted_price { get; init; }

    /// <summary>
    ///     average_price number
    /// </summary>

    [JsonPropertyName("average_price")]
    public double? Average_price { get; init; }

    /// <summary>
    ///     type_id integer
    /// </summary>

    [JsonPropertyName("type_id")]
    public int Type_id { get; init; }
}