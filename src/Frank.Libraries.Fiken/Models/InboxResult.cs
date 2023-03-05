using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class InboxResult
{
    /// <summary>
    ///     Gets or Sets DocumentId
    /// </summary>
    [DataMember(Name = "documentId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "documentId")]
    public long? DocumentId { get; set; }

    /// <summary>
    ///     Name of the document as it appears in the inbox
    /// </summary>
    /// <value>Name of the document as it appears in the inbox</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    ///     Additional description of document
    /// </summary>
    /// <value>Additional description of document</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    ///     Name of the underlying file for the inbox document
    /// </summary>
    /// <value>Name of the underlying file for the inbox document</value>
    [DataMember(Name = "filename", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    ///     Whether the document has been used as documentation or not
    /// </summary>
    /// <value>Whether the document has been used as documentation or not</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "status")]
    public bool? Status { get; set; }

    /// <summary>
    ///     When the document was created
    /// </summary>
    /// <value>When the document was created</value>
    [DataMember(Name = "createdAt", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InboxResult {\n");
        sb.Append("  DocumentId: ")
          .Append(DocumentId)
          .Append("\n");
        sb.Append("  Name: ")
          .Append(Name)
          .Append("\n");
        sb.Append("  Description: ")
          .Append(Description)
          .Append("\n");
        sb.Append("  Filename: ")
          .Append(Filename)
          .Append("\n");
        sb.Append("  Status: ")
          .Append(Status)
          .Append("\n");
        sb.Append("  CreatedAt: ")
          .Append(CreatedAt)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}