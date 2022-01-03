namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Victory_points6
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Victory_points6(int @last_week, int @total, int @yesterday)

        {

            this.Last_week = @last_week;

            this.Total = @total;

            this.Yesterday = @yesterday;

        }    /// <summary>
        /// Last week's victory points gained
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_week")]
        public int Last_week { get; init; }

        /// <summary>
        /// Total victory points gained since faction warfare began
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; init; }

        /// <summary>
        /// Yesterday's victory points gained
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("yesterday")]
        public int Yesterday { get; init; }

    }
