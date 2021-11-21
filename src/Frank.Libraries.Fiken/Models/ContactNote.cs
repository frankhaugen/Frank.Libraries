using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class ContactNote
    {
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactNote {\n");
            sb.Append("  Author: ")
              .Append(Author)
              .Append("\n");
            sb.Append("  Note: ")
              .Append(Note)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}