namespace EveOnlineApi;

    /// <summary>
    /// active_total object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Active_total5
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Active_total5(int? @amount, int? @corporation_id)

        {

            this.Amount = @amount;

            this.Corporation_id = @corporation_id;

        }    /// <summary>
        /// Amount of kills
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int? Amount { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

    }
