using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class JournalEntry
    {
        /// <summary>
        /// Gets or Sets JournalEntryId
        /// </summary>
        [DataMember(Name = "journalEntryId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "journalEntryId")]
        public long? JournalEntryId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionId")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// If a journal entry has been cancelled this provides the id of the balancing transaction
        /// </summary>
        /// <value>If a journal entry has been cancelled this provides the id of the balancing transaction</value>
        [DataMember(Name = "offsetTransactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offsetTransactionId")]
        public long? OffsetTransactionId { get; set; }

        /// <summary>
        /// Gets or Sets JournalEntryNumber
        /// </summary>
        [DataMember(Name = "journalEntryNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "journalEntryNumber")]
        public int? JournalEntryNumber { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<JournalEntryLine> Lines { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachments")]
        public List<Attachment> Attachments { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalEntry {\n");
            sb.Append("  JournalEntryId: ")
              .Append(JournalEntryId)
              .Append("\n");
            sb.Append("  TransactionId: ")
              .Append(TransactionId)
              .Append("\n");
            sb.Append("  OffsetTransactionId: ")
              .Append(OffsetTransactionId)
              .Append("\n");
            sb.Append("  JournalEntryNumber: ")
              .Append(JournalEntryNumber)
              .Append("\n");
            sb.Append("  Description: ")
              .Append(Description)
              .Append("\n");
            sb.Append("  Date: ")
              .Append(Date)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("  Attachments: ")
              .Append(Attachments)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}