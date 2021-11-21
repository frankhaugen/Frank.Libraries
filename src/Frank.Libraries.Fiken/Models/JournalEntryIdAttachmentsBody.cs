using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class JournalEntryIdAttachmentsBody
    {
        /// <summary>
        /// Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf
        /// </summary>
        /// <value>Required. The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "file")]
        public byte[] File { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalEntryIdAttachmentsBody {\n");
            sb.Append("  Filename: ")
              .Append(Filename)
              .Append("\n");
            sb.Append("  File: ")
              .Append(File)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}