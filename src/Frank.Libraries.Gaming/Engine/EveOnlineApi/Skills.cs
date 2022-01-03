namespace EveOnlineApi;

    /// <summary>
    /// skill object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Skills
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Skills(int @active_skill_level, int @skill_id, long @skillpoints_in_skill, int @trained_skill_level)

        {

            this.Active_skill_level = @active_skill_level;

            this.Skill_id = @skill_id;

            this.Skillpoints_in_skill = @skillpoints_in_skill;

            this.Trained_skill_level = @trained_skill_level;

        }    /// <summary>
        /// active_skill_level integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("active_skill_level")]
        public int Active_skill_level { get; init; }

        /// <summary>
        /// skill_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public int Skill_id { get; init; }

        /// <summary>
        /// skillpoints_in_skill integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("skillpoints_in_skill")]
        public long Skillpoints_in_skill { get; init; }

        /// <summary>
        /// trained_skill_level integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("trained_skill_level")]
        public int Trained_skill_level { get; init; }

    }
