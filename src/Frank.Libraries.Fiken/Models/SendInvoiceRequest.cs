using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class SendInvoiceRequest : SendFakturaisjRequest
    {
        /// <summary>
        /// Id of invoice to send.
        /// </summary>
        /// <value>Id of invoice to send.</value>
        [DataMember(Name = "invoiceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoiceId")]
        public long? InvoiceId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendInvoiceRequest {\n");
            sb.Append("  InvoiceId: ")
              .Append(InvoiceId)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}