using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class GeneralJournalEntryRequest
    {
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets JournalEntries
        /// </summary>
        [DataMember(Name = "journalEntries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "journalEntries")]
        public List<JournalEntry> JournalEntries { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralJournalEntryRequest {\n");
            sb.Append("  Description: ")
              .Append(Description)
              .Append("\n");
            sb.Append("  JournalEntries: ")
              .Append(JournalEntries)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}