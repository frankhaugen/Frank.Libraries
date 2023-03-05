using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EveOnlineApi;

/// <summary>
///     route object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Routes
{
    [JsonConstructor]
    public Routes(int content_type_id, long destination_pin_id, float quantity, long route_id, long source_pin_id, IList<long>? waypoints)

    {
        Content_type_id = content_type_id;

        Destination_pin_id = destination_pin_id;

        Quantity = quantity;

        Route_id = route_id;

        Source_pin_id = source_pin_id;

        Waypoints = waypoints;
    }

    /// <summary>
    ///     content_type_id integer
    /// </summary>

    [JsonPropertyName("content_type_id")]
    public int Content_type_id { get; init; }

    /// <summary>
    ///     destination_pin_id integer
    /// </summary>

    [JsonPropertyName("destination_pin_id")]
    public long Destination_pin_id { get; init; }

    /// <summary>
    ///     quantity number
    /// </summary>

    [JsonPropertyName("quantity")]
    public float Quantity { get; init; }

    /// <summary>
    ///     route_id integer
    /// </summary>

    [JsonPropertyName("route_id")]
    public long Route_id { get; init; }

    /// <summary>
    ///     source_pin_id integer
    /// </summary>

    [JsonPropertyName("source_pin_id")]
    public long Source_pin_id { get; init; }

    /// <summary>
    ///     list of pin ID waypoints
    /// </summary>

    [JsonPropertyName("waypoints")]
    public IList<long>? Waypoints { get; init; }
}