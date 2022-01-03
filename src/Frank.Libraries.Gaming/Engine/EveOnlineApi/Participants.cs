namespace EveOnlineApi;

    /// <summary>
    /// participant object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Participants
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Participants(int @alliance_id, float @score)

        {

            this.Alliance_id = @alliance_id;

            this.Score = @score;

        }    /// <summary>
        /// alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int Alliance_id { get; init; }

        /// <summary>
        /// score number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("score")]
        public float Score { get; init; }

    }
