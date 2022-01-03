namespace EveOnlineApi;

    /// <summary>
    /// content object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Contents
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Contents(long @amount, int @type_id)

        {

            this.Amount = @amount;

            this.Type_id = @type_id;

        }    /// <summary>
        /// amount integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public long Amount { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
