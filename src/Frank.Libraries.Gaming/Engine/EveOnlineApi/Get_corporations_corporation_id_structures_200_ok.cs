using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_structures_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_structures_200_ok(int @corporation_id, System.DateTimeOffset? @fuel_expires, string? @name, System.DateTimeOffset? @next_reinforce_apply, int? @next_reinforce_hour, int @profile_id, int? @reinforce_hour, IList<Services>? @services, Get_corporations_corporation_id_structures_200_okState @state, System.DateTimeOffset? @state_timer_end, System.DateTimeOffset? @state_timer_start, long @structure_id, int @system_id, int @type_id, System.DateTimeOffset? @unanchors_at)

        {

            this.Corporation_id = @corporation_id;

            this.Fuel_expires = @fuel_expires;

            this.Name = @name;

            this.Next_reinforce_apply = @next_reinforce_apply;

            this.Next_reinforce_hour = @next_reinforce_hour;

            this.Profile_id = @profile_id;

            this.Reinforce_hour = @reinforce_hour;

            this.Services = @services;

            this.State = @state;

            this.State_timer_end = @state_timer_end;

            this.State_timer_start = @state_timer_start;

            this.Structure_id = @structure_id;

            this.System_id = @system_id;

            this.Type_id = @type_id;

            this.Unanchors_at = @unanchors_at;

        }    /// <summary>
        /// ID of the corporation that owns the structure
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// Date on which the structure will run out of fuel
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fuel_expires")]
        public System.DateTimeOffset? Fuel_expires { get; init; }

        /// <summary>
        /// The structure name
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The date and time when the structure's newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("next_reinforce_apply")]
        public System.DateTimeOffset? Next_reinforce_apply { get; init; }

        /// <summary>
        /// The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("next_reinforce_hour")]
        public int? Next_reinforce_hour { get; init; }

        /// <summary>
        /// The id of the ACL profile for this citadel
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        public int Profile_id { get; init; }

        /// <summary>
        /// The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reinforce_hour")]
        public int? Reinforce_hour { get; init; }

        /// <summary>
        /// Contains a list of service upgrades, and their state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("services")]
        public IList<Services>? Services { get; init; }

        /// <summary>
        /// state string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_structures_200_okState State { get; init; }

        /// <summary>
        /// Date at which the structure will move to it's next state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state_timer_end")]
        public System.DateTimeOffset? State_timer_end { get; init; }

        /// <summary>
        /// Date at which the structure entered it's current state
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("state_timer_start")]
        public System.DateTimeOffset? State_timer_start { get; init; }

        /// <summary>
        /// The Item ID of the structure
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("structure_id")]
        public long Structure_id { get; init; }

        /// <summary>
        /// The solar system the structure is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// The type id of the structure
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

        /// <summary>
        /// Date at which the structure will unanchor
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("unanchors_at")]
        public System.DateTimeOffset? Unanchors_at { get; init; }

    }
