using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_wars_war_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_wars_war_id_ok(Aggressor @aggressor, IList<Allies>? @allies, System.DateTimeOffset @declared, Defender @defender, System.DateTimeOffset? @finished, int @id, bool @mutual, bool @open_for_allies, System.DateTimeOffset? @retracted, System.DateTimeOffset? @started)

        {

            this.Aggressor = @aggressor;

            this.Allies = @allies;

            this.Declared = @declared;

            this.Defender = @defender;

            this.Finished = @finished;

            this.Id = @id;

            this.Mutual = @mutual;

            this.Open_for_allies = @open_for_allies;

            this.Retracted = @retracted;

            this.Started = @started;

        }    /// <summary>
        /// The aggressor corporation or alliance that declared this war, only contains either corporation_id or alliance_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("aggressor")]
        public Aggressor Aggressor { get; init; }

        /// <summary>
        /// allied corporations or alliances, each object contains either corporation_id or alliance_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("allies")]
        public IList<Allies>? Allies { get; init; }

        /// <summary>
        /// Time that the war was declared
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("declared")]
        public System.DateTimeOffset Declared { get; init; }

        /// <summary>
        /// The defending corporation or alliance that declared this war, only contains either corporation_id or alliance_id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("defender")]
        public Defender Defender { get; init; }

        /// <summary>
        /// Time the war ended and shooting was no longer allowed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("finished")]
        public System.DateTimeOffset? Finished { get; init; }

        /// <summary>
        /// ID of the specified war
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Was the war declared mutual by both parties
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mutual")]
        public bool Mutual { get; init; }

        /// <summary>
        /// Is the war currently open for allies or not
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("open_for_allies")]
        public bool Open_for_allies { get; init; }

        /// <summary>
        /// Time the war was retracted but both sides could still shoot each other
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("retracted")]
        public System.DateTimeOffset? Retracted { get; init; }

        /// <summary>
        /// Time when the war started and both sides could shoot each other
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("started")]
        public System.DateTimeOffset? Started { get; init; }

    }
