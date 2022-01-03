namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_sovereignty_structures_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_sovereignty_structures_200_ok(int @alliance_id, int @solar_system_id, long @structure_id, int @structure_type_id, float? @vulnerability_occupancy_level, System.DateTimeOffset? @vulnerable_end_time, System.DateTimeOffset? @vulnerable_start_time)

        {

            this.Alliance_id = @alliance_id;

            this.Solar_system_id = @solar_system_id;

            this.Structure_id = @structure_id;

            this.Structure_type_id = @structure_type_id;

            this.Vulnerability_occupancy_level = @vulnerability_occupancy_level;

            this.Vulnerable_end_time = @vulnerable_end_time;

            this.Vulnerable_start_time = @vulnerable_start_time;

        }    /// <summary>
        /// The alliance that owns the structure.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int Alliance_id { get; init; }

        /// <summary>
        /// Solar system in which the structure is located.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

        /// <summary>
        /// Unique item ID for this structure.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("structure_id")]
        public long Structure_id { get; init; }

        /// <summary>
        /// A reference to the type of structure this is.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("structure_type_id")]
        public int Structure_type_id { get; init; }

        /// <summary>
        /// The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("vulnerability_occupancy_level")]
        public float? Vulnerability_occupancy_level { get; init; }

        /// <summary>
        /// The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to 'overtime' and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("vulnerable_end_time")]
        public System.DateTimeOffset? Vulnerable_end_time { get; init; }

        /// <summary>
        /// The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("vulnerable_start_time")]
        public System.DateTimeOffset? Vulnerable_start_time { get; init; }

    }
