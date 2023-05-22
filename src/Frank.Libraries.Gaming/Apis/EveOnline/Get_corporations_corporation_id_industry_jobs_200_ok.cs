using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_corporations_corporation_id_industry_jobs_200_ok
{
    [JsonConstructor]
    public Get_corporations_corporation_id_industry_jobs_200_ok(int activity_id, long blueprint_id, long blueprint_location_id, int blueprint_type_id, int? completed_character_id, DateTimeOffset? completed_date, double? cost, int duration, DateTimeOffset end_date, long facility_id, int installer_id, int job_id, int? licensed_runs, long location_id, long output_location_id, DateTimeOffset? pause_date, float? probability, int? product_type_id, int runs, DateTimeOffset start_date, Get_corporations_corporation_id_industry_jobs_200_okStatus status, int? successful_runs)

    {
        Activity_id = activity_id;

        Blueprint_id = blueprint_id;

        Blueprint_location_id = blueprint_location_id;

        Blueprint_type_id = blueprint_type_id;

        Completed_character_id = completed_character_id;

        Completed_date = completed_date;

        Cost = cost;

        Duration = duration;

        End_date = end_date;

        Facility_id = facility_id;

        Installer_id = installer_id;

        Job_id = job_id;

        Licensed_runs = licensed_runs;

        Location_id = location_id;

        Output_location_id = output_location_id;

        Pause_date = pause_date;

        Probability = probability;

        Product_type_id = product_type_id;

        Runs = runs;

        Start_date = start_date;

        Status = status;

        Successful_runs = successful_runs;
    }

    /// <summary>
    ///     Job activity ID
    /// </summary>

    [JsonPropertyName("activity_id")]
    public int Activity_id { get; init; }

    /// <summary>
    ///     blueprint_id integer
    /// </summary>

    [JsonPropertyName("blueprint_id")]
    public long Blueprint_id { get; init; }

    /// <summary>
    ///     Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset
    ///     (e.g. container) or corporation facility
    /// </summary>

    [JsonPropertyName("blueprint_location_id")]
    public long Blueprint_location_id { get; init; }

    /// <summary>
    ///     blueprint_type_id integer
    /// </summary>

    [JsonPropertyName("blueprint_type_id")]
    public int Blueprint_type_id { get; init; }

    /// <summary>
    ///     ID of the character which completed this job
    /// </summary>

    [JsonPropertyName("completed_character_id")]
    public int? Completed_character_id { get; init; }

    /// <summary>
    ///     Date and time when this job was completed
    /// </summary>

    [JsonPropertyName("completed_date")]
    public DateTimeOffset? Completed_date { get; init; }

    /// <summary>
    ///     The sume of job installation fee and industry facility tax
    /// </summary>

    [JsonPropertyName("cost")]
    public double? Cost { get; init; }

    /// <summary>
    ///     Job duration in seconds
    /// </summary>

    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    /// <summary>
    ///     Date and time when this job finished
    /// </summary>

    [JsonPropertyName("end_date")]
    public DateTimeOffset End_date { get; init; }

    /// <summary>
    ///     ID of the facility where this job is running
    /// </summary>

    [JsonPropertyName("facility_id")]
    public long Facility_id { get; init; }

    /// <summary>
    ///     ID of the character which installed this job
    /// </summary>

    [JsonPropertyName("installer_id")]
    public int Installer_id { get; init; }

    /// <summary>
    ///     Unique job ID
    /// </summary>

    [JsonPropertyName("job_id")]
    public int Job_id { get; init; }

    /// <summary>
    ///     Number of runs blueprint is licensed for
    /// </summary>

    [JsonPropertyName("licensed_runs")]
    public int? Licensed_runs { get; init; }

    /// <summary>
    ///     ID of the location for the industry facility
    /// </summary>

    [JsonPropertyName("location_id")]
    public long Location_id { get; init; }

    /// <summary>
    ///     Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also
    ///     be a corporation facility
    /// </summary>

    [JsonPropertyName("output_location_id")]
    public long Output_location_id { get; init; }

    /// <summary>
    ///     Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)
    /// </summary>

    [JsonPropertyName("pause_date")]
    public DateTimeOffset? Pause_date { get; init; }

    /// <summary>
    ///     Chance of success for invention
    /// </summary>

    [JsonPropertyName("probability")]
    public float? Probability { get; init; }

    /// <summary>
    ///     Type ID of product (manufactured, copied or invented)
    /// </summary>

    [JsonPropertyName("product_type_id")]
    public int? Product_type_id { get; init; }

    /// <summary>
    ///     Number of runs for a manufacturing job, or number of copies to make for a blueprint copy
    /// </summary>

    [JsonPropertyName("runs")]
    public int Runs { get; init; }

    /// <summary>
    ///     Date and time when this job started
    /// </summary>

    [JsonPropertyName("start_date")]
    public DateTimeOffset Start_date { get; init; }

    /// <summary>
    ///     status string
    /// </summary>

    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Get_corporations_corporation_id_industry_jobs_200_okStatus Status { get; init; }

    /// <summary>
    ///     Number of successful runs for this job. Equal to runs unless this is an invention job
    /// </summary>

    [JsonPropertyName("successful_runs")]
    public int? Successful_runs { get; init; }
}