using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class ProjectRequest
{
    /// <summary>
    ///     Gets or Sets Number
    /// </summary>
    [DataMember(Name = "number", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    ///     Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    ///     Start date for the project, inclusive, format yyyy-mm-dd
    /// </summary>
    /// <value>Start date for the project, inclusive, format yyyy-mm-dd</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    ///     End date for the project, inclusive, format yyyy-mm-dd
    /// </summary>
    /// <value>End date for the project, inclusive, format yyyy-mm-dd</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    ///     Gets or Sets ContactId
    /// </summary>
    [DataMember(Name = "contactId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contactId")]
    public long? ContactId { get; set; }

    /// <summary>
    ///     Whether the project is completed or not.
    /// </summary>
    /// <value>Whether the project is completed or not.</value>
    [DataMember(Name = "completed", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "completed")]
    public bool? Completed { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProjectRequest {\n");
        sb.Append("  Number: ")
          .Append(Number)
          .Append("\n");
        sb.Append("  Name: ")
          .Append(Name)
          .Append("\n");
        sb.Append("  Description: ")
          .Append(Description)
          .Append("\n");
        sb.Append("  StartDate: ")
          .Append(StartDate)
          .Append("\n");
        sb.Append("  EndDate: ")
          .Append(EndDate)
          .Append("\n");
        sb.Append("  ContactId: ")
          .Append(ContactId)
          .Append("\n");
        sb.Append("  Completed: ")
          .Append(Completed)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}