using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class CompanySlugInboxBody
{
    /// <summary>
    ///     The name of the inbox document, usually the same as the filename
    /// </summary>
    /// <value>The name of the inbox document, usually the same as the filename</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    ///     The filename of the file uploaded
    /// </summary>
    /// <value>The filename of the file uploaded</value>
    [DataMember(Name = "filename", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    ///     Additional description of the inbox document
    /// </summary>
    /// <value>Additional description of the inbox document</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    ///     Gets or Sets File
    /// </summary>
    [DataMember(Name = "file", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "file")]
    public byte[] File { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CompanySlugInboxBody {\n");
        sb.Append("  Name: ")
          .Append(Name)
          .Append("\n");
        sb.Append("  Filename: ")
          .Append(Filename)
          .Append("\n");
        sb.Append("  Description: ")
          .Append(Description)
          .Append("\n");
        sb.Append("  File: ")
          .Append(File)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}