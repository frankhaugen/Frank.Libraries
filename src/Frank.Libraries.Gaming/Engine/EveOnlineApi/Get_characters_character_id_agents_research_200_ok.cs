namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_agents_research_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_agents_research_200_ok(int @agent_id, float @points_per_day, float @remainder_points, int @skill_type_id, System.DateTimeOffset @started_at)

        {

            this.Agent_id = @agent_id;

            this.Points_per_day = @points_per_day;

            this.Remainder_points = @remainder_points;

            this.Skill_type_id = @skill_type_id;

            this.Started_at = @started_at;

        }    /// <summary>
        /// agent_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public int Agent_id { get; init; }

        /// <summary>
        /// points_per_day number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("points_per_day")]
        public float Points_per_day { get; init; }

        /// <summary>
        /// remainder_points number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("remainder_points")]
        public float Remainder_points { get; init; }

        /// <summary>
        /// skill_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("skill_type_id")]
        public int Skill_type_id { get; init; }

        /// <summary>
        /// started_at string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public System.DateTimeOffset Started_at { get; init; }

    }
