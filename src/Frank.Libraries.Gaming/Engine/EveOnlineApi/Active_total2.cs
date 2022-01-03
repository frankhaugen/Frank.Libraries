namespace EveOnlineApi;

    /// <summary>
    /// active_total object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Active_total2
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Active_total2(int? @amount, int? @faction_id)

        {

            this.Amount = @amount;

            this.Faction_id = @faction_id;

        }    /// <summary>
        /// Amount of victory points
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

    }
