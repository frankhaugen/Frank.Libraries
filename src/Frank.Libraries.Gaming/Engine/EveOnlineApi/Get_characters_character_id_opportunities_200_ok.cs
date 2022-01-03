namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_opportunities_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_opportunities_200_ok(System.DateTimeOffset @completed_at, int @task_id)

        {

            this.Completed_at = @completed_at;

            this.Task_id = @task_id;

        }    /// <summary>
        /// completed_at string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public System.DateTimeOffset Completed_at { get; init; }

        /// <summary>
        /// task_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int Task_id { get; init; }

    }
