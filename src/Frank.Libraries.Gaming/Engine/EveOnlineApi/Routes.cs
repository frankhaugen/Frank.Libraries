using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// route object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Routes
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Routes(int @content_type_id, long @destination_pin_id, float @quantity, long @route_id, long @source_pin_id, IList<long>? @waypoints)

        {

            this.Content_type_id = @content_type_id;

            this.Destination_pin_id = @destination_pin_id;

            this.Quantity = @quantity;

            this.Route_id = @route_id;

            this.Source_pin_id = @source_pin_id;

            this.Waypoints = @waypoints;

        }    /// <summary>
        /// content_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("content_type_id")]
        public int Content_type_id { get; init; }

        /// <summary>
        /// destination_pin_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destination_pin_id")]
        public long Destination_pin_id { get; init; }

        /// <summary>
        /// quantity number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public float Quantity { get; init; }

        /// <summary>
        /// route_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("route_id")]
        public long Route_id { get; init; }

        /// <summary>
        /// source_pin_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("source_pin_id")]
        public long Source_pin_id { get; init; }

        /// <summary>
        /// list of pin ID waypoints
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("waypoints")]
        public IList<long>? Waypoints { get; init; }

    }
