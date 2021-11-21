using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// User-defined identifier for attachment. Could be the Invoice Id or receipt number for example.
        /// </summary>
        /// <value>User-defined identifier for attachment. Could be the Invoice Id or receipt number for example.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrlWithFikenNormalUserCredentials
        /// </summary>
        [DataMember(Name = "downloadUrlWithFikenNormalUserCredentials", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "downloadUrlWithFikenNormalUserCredentials")]
        public string DownloadUrlWithFikenNormalUserCredentials { get; set; }

        /// <summary>
        /// Field for additional information for this attachment.
        /// </summary>
        /// <value>Field for additional information for this attachment.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  Identifier: ")
              .Append(Identifier)
              .Append("\n");
            sb.Append("  DownloadUrl: ")
              .Append(DownloadUrl)
              .Append("\n");
            sb.Append("  DownloadUrlWithFikenNormalUserCredentials: ")
              .Append(DownloadUrlWithFikenNormalUserCredentials)
              .Append("\n");
            sb.Append("  Comment: ")
              .Append(Comment)
              .Append("\n");
            sb.Append("  Type: ")
              .Append(Type)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}