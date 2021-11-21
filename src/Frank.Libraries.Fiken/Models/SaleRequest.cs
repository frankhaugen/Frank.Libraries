using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class SaleRequest
    {
        /// <summary>
        /// Identifier for sale.
        /// </summary>
        /// <value>Identifier for sale.</value>
        [DataMember(Name = "saleNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "saleNumber")]
        public string SaleNumber { get; set; }

        /// <summary>
        /// Due date of the invoice, format yyyy-mm-dd
        /// </summary>
        /// <value>Due date of the invoice, format yyyy-mm-dd</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Either cash_sale, invoice, or external_invoice.
        /// </summary>
        /// <value>Either cash_sale, invoice, or external_invoice.</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// If the sale as been marked as settled (True) or not (False).
        /// </summary>
        /// <value>If the sale as been marked as settled (True) or not (False).</value>
        [DataMember(Name = "settled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "settled")]
        public bool? Settled { get; set; }

        /// <summary>
        /// Total amount paid in NOK
        /// </summary>
        /// <value>Total amount paid in NOK</value>
        [DataMember(Name = "totalPaid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalPaid")]
        public long? TotalPaid { get; set; }

        /// <summary>
        /// Total amount paid in other currency.
        /// </summary>
        /// <value>Total amount paid in other currency.</value>
        [DataMember(Name = "totalPaidInCurrency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalPaidInCurrency")]
        public long? TotalPaidInCurrency { get; set; }

        /// <summary>
        /// Gets or Sets OutstandingBalance
        /// </summary>
        [DataMember(Name = "outstandingBalance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "outstandingBalance")]
        public long? OutstandingBalance { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<OrderLine> Lines { get; set; }

        /// <summary>
        /// customerId = contactId where customer = true
        /// </summary>
        /// <value>customerId = contactId where customer = true</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerId")]
        public long? CustomerId { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        /// <value>ISO 4217 currency code</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Due date of the invoice, format yyyy-mm-dd
        /// </summary>
        /// <value>Due date of the invoice, format yyyy-mm-dd</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Norwegian KID number. Number from 2 to 25 digits long.
        /// </summary>
        /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentAccount")]
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Payment date of the invoice, format yyyy-mm-dd
        /// </summary>
        /// <value>Payment date of the invoice, format yyyy-mm-dd</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentDate")]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Fee associated with payment of sale.
        /// </summary>
        /// <value>Fee associated with payment of sale.</value>
        [DataMember(Name = "paymentFee", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentFee")]
        public long? PaymentFee { get; set; }

        /// <summary>
        /// Id of given project.
        /// </summary>
        /// <value>Id of given project.</value>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projectId")]
        public long? ProjectId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleRequest {\n");
            sb.Append("  SaleNumber: ")
              .Append(SaleNumber)
              .Append("\n");
            sb.Append("  Date: ")
              .Append(Date)
              .Append("\n");
            sb.Append("  Kind: ")
              .Append(Kind)
              .Append("\n");
            sb.Append("  Settled: ")
              .Append(Settled)
              .Append("\n");
            sb.Append("  TotalPaid: ")
              .Append(TotalPaid)
              .Append("\n");
            sb.Append("  TotalPaidInCurrency: ")
              .Append(TotalPaidInCurrency)
              .Append("\n");
            sb.Append("  OutstandingBalance: ")
              .Append(OutstandingBalance)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("  CustomerId: ")
              .Append(CustomerId)
              .Append("\n");
            sb.Append("  Currency: ")
              .Append(Currency)
              .Append("\n");
            sb.Append("  DueDate: ")
              .Append(DueDate)
              .Append("\n");
            sb.Append("  Kid: ")
              .Append(Kid)
              .Append("\n");
            sb.Append("  PaymentAccount: ")
              .Append(PaymentAccount)
              .Append("\n");
            sb.Append("  PaymentDate: ")
              .Append(PaymentDate)
              .Append("\n");
            sb.Append("  PaymentFee: ")
              .Append(PaymentFee)
              .Append("\n");
            sb.Append("  ProjectId: ")
              .Append(ProjectId)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}