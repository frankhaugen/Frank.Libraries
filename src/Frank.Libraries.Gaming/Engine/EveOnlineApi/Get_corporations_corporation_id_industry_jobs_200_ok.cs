namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_industry_jobs_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_industry_jobs_200_ok(int @activity_id, long @blueprint_id, long @blueprint_location_id, int @blueprint_type_id, int? @completed_character_id, System.DateTimeOffset? @completed_date, double? @cost, int @duration, System.DateTimeOffset @end_date, long @facility_id, int @installer_id, int @job_id, int? @licensed_runs, long @location_id, long @output_location_id, System.DateTimeOffset? @pause_date, float? @probability, int? @product_type_id, int @runs, System.DateTimeOffset @start_date, Get_corporations_corporation_id_industry_jobs_200_okStatus @status, int? @successful_runs)

        {

            this.Activity_id = @activity_id;

            this.Blueprint_id = @blueprint_id;

            this.Blueprint_location_id = @blueprint_location_id;

            this.Blueprint_type_id = @blueprint_type_id;

            this.Completed_character_id = @completed_character_id;

            this.Completed_date = @completed_date;

            this.Cost = @cost;

            this.Duration = @duration;

            this.End_date = @end_date;

            this.Facility_id = @facility_id;

            this.Installer_id = @installer_id;

            this.Job_id = @job_id;

            this.Licensed_runs = @licensed_runs;

            this.Location_id = @location_id;

            this.Output_location_id = @output_location_id;

            this.Pause_date = @pause_date;

            this.Probability = @probability;

            this.Product_type_id = @product_type_id;

            this.Runs = @runs;

            this.Start_date = @start_date;

            this.Status = @status;

            this.Successful_runs = @successful_runs;

        }    /// <summary>
        /// Job activity ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public int Activity_id { get; init; }

        /// <summary>
        /// blueprint_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("blueprint_id")]
        public long Blueprint_id { get; init; }

        /// <summary>
        /// Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset (e.g. container) or corporation facility
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("blueprint_location_id")]
        public long Blueprint_location_id { get; init; }

        /// <summary>
        /// blueprint_type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("blueprint_type_id")]
        public int Blueprint_type_id { get; init; }

        /// <summary>
        /// ID of the character which completed this job
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("completed_character_id")]
        public int? Completed_character_id { get; init; }

        /// <summary>
        /// Date and time when this job was completed
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("completed_date")]
        public System.DateTimeOffset? Completed_date { get; init; }

        /// <summary>
        /// The sume of job installation fee and industry facility tax
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; init; }

        /// <summary>
        /// Job duration in seconds
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// Date and time when this job finished
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public System.DateTimeOffset End_date { get; init; }

        /// <summary>
        /// ID of the facility where this job is running
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("facility_id")]
        public long Facility_id { get; init; }

        /// <summary>
        /// ID of the character which installed this job
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("installer_id")]
        public int Installer_id { get; init; }

        /// <summary>
        /// Unique job ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int Job_id { get; init; }

        /// <summary>
        /// Number of runs blueprint is licensed for
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("licensed_runs")]
        public int? Licensed_runs { get; init; }

        /// <summary>
        /// ID of the location for the industry facility
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("output_location_id")]
        public long Output_location_id { get; init; }

        /// <summary>
        /// Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pause_date")]
        public System.DateTimeOffset? Pause_date { get; init; }

        /// <summary>
        /// Chance of success for invention
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("probability")]
        public float? Probability { get; init; }

        /// <summary>
        /// Type ID of product (manufactured, copied or invented)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("product_type_id")]
        public int? Product_type_id { get; init; }

        /// <summary>
        /// Number of runs for a manufacturing job, or number of copies to make for a blueprint copy
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("runs")]
        public int Runs { get; init; }

        /// <summary>
        /// Date and time when this job started
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public System.DateTimeOffset Start_date { get; init; }

        /// <summary>
        /// status string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_industry_jobs_200_okStatus Status { get; init; }

        /// <summary>
        /// Number of successful runs for this job. Equal to runs unless this is an invention job
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("successful_runs")]
        public int? Successful_runs { get; init; }

    }
