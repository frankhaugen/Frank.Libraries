namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_skillqueue_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_skillqueue_200_ok(System.DateTimeOffset? @finish_date, int @finished_level, int? @level_end_sp, int? @level_start_sp, int @queue_position, int @skill_id, System.DateTimeOffset? @start_date, int? @training_start_sp)

        {

            this.Finish_date = @finish_date;

            this.Finished_level = @finished_level;

            this.Level_end_sp = @level_end_sp;

            this.Level_start_sp = @level_start_sp;

            this.Queue_position = @queue_position;

            this.Skill_id = @skill_id;

            this.Start_date = @start_date;

            this.Training_start_sp = @training_start_sp;

        }    /// <summary>
        /// Date on which training of the skill will complete. Omitted if the skill queue is paused.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("finish_date")]
        public System.DateTimeOffset? Finish_date { get; init; }

        /// <summary>
        /// finished_level integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("finished_level")]
        public int Finished_level { get; init; }

        /// <summary>
        /// level_end_sp integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("level_end_sp")]
        public int? Level_end_sp { get; init; }

        /// <summary>
        /// Amount of SP that was in the skill when it started training it's current level. Used to calculate % of current level complete.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("level_start_sp")]
        public int? Level_start_sp { get; init; }

        /// <summary>
        /// queue_position integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("queue_position")]
        public int Queue_position { get; init; }

        /// <summary>
        /// skill_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public int Skill_id { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public System.DateTimeOffset? Start_date { get; init; }

        /// <summary>
        /// training_start_sp integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("training_start_sp")]
        public int? Training_start_sp { get; init; }

    }
