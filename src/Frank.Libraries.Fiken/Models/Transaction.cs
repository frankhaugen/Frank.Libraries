using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    /// Transaction result upon creation of a General Journal Entry
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionId")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Entries
        /// </summary>
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "entries")]
        public List<JournalEntry> Entries { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  TransactionId: ")
              .Append(TransactionId)
              .Append("\n");
            sb.Append("  Description: ")
              .Append(Description)
              .Append("\n");
            sb.Append("  Type: ")
              .Append(Type)
              .Append("\n");
            sb.Append("  Entries: ")
              .Append(Entries)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}