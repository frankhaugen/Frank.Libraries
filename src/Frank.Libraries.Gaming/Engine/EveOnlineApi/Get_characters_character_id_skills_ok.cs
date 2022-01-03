using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_skills_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_skills_ok(IList<Skills> @skills, long @total_sp, int? @unallocated_sp)

        {

            this.Skills = @skills;

            this.Total_sp = @total_sp;

            this.Unallocated_sp = @unallocated_sp;

        }    /// <summary>
        /// skills array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("skills")]
        public IList<Skills> Skills { get; init; }

        /// <summary>
        /// total_sp integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("total_sp")]
        public long Total_sp { get; init; }

        /// <summary>
        /// Skill points available to be assigned
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unallocated_sp")]
        public int? Unallocated_sp { get; init; }

    }
