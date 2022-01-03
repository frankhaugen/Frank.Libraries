namespace EveOnlineApi;

    /// <summary>
    /// level object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Levels
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Levels(float @cost, string @name, float @payout)

        {

            this.Cost = @cost;

            this.Name = @name;

            this.Payout = @payout;

        }    /// <summary>
        /// cost number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cost")]
        public float Cost { get; init; }

        /// <summary>
        /// Localized insurance level
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// payout number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("payout")]
        public float Payout { get; init; }

    }
