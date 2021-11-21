using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class SendCreditNoteRequest : SendFakturaisjRequest
    {
        /// <summary>
        /// Id of credit note to send.
        /// </summary>
        /// <value>Id of credit note to send.</value>
        [DataMember(Name = "creditNoteId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNoteId")]
        public long? CreditNoteId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendCreditNoteRequest {\n");
            sb.Append("  CreditNoteId: ")
              .Append(CreditNoteId)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}