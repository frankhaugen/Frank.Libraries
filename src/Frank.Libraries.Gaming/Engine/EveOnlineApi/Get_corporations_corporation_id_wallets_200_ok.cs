namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_wallets_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_wallets_200_ok(double @balance, int @division)

        {

            this.Balance = @balance;

            this.Division = @division;

        }    /// <summary>
        /// balance number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public double Balance { get; init; }

        /// <summary>
        /// division integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("division")]
        public int Division { get; init; }

    }
