using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class SaleResult
{
    /// <summary>
    ///     Sale Id
    /// </summary>
    /// <value>Sale Id</value>
    [DataMember(Name = "saleId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "saleId")]
    public long? SaleId { get; set; }

    /// <summary>
    ///     Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name = "transactionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionId")]
    public long? TransactionId { get; set; }

    /// <summary>
    ///     Identifier for sale.
    /// </summary>
    /// <value>Identifier for sale.</value>
    [DataMember(Name = "saleNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "saleNumber")]
    public string SaleNumber { get; set; }

    /// <summary>
    ///     Due date of the invoice, format yyyy-mm-dd
    /// </summary>
    /// <value>Due date of the invoice, format yyyy-mm-dd</value>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    ///     Either cash_sale, invoice, or external_invoice.
    /// </summary>
    /// <value>Either cash_sale, invoice, or external_invoice.</value>
    [DataMember(Name = "kind", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    ///     Total net amount of the sale to be paid.
    /// </summary>
    /// <value>Total net amount of the sale to be paid.</value>
    [DataMember(Name = "netAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "netAmount")]
    public long? NetAmount { get; set; }

    /// <summary>
    ///     VAT amount on sale.
    /// </summary>
    /// <value>VAT amount on sale.</value>
    [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatAmount")]
    public long? VatAmount { get; set; }

    /// <summary>
    ///     If the sale as been marked as settled (True) or not (False).
    /// </summary>
    /// <value>If the sale as been marked as settled (True) or not (False).</value>
    [DataMember(Name = "settled", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "settled")]
    public bool? Settled { get; set; }

    /// <summary>
    ///     If a loss has been registered for this sale (tapsføring av salg).
    /// </summary>
    /// <value>If a loss has been registered for this sale (tapsføring av salg).</value>
    [DataMember(Name = "writeOff", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "writeOff")]
    public bool? WriteOff { get; set; }

    /// <summary>
    ///     Total amount paid in NOK
    /// </summary>
    /// <value>Total amount paid in NOK</value>
    [DataMember(Name = "totalPaid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalPaid")]
    public long? TotalPaid { get; set; }

    /// <summary>
    ///     Total amount paid in other currency.
    /// </summary>
    /// <value>Total amount paid in other currency.</value>
    [DataMember(Name = "totalPaidInCurrency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "totalPaidInCurrency")]
    public long? TotalPaidInCurrency { get; set; }

    /// <summary>
    ///     Gets or Sets OutstandingBalance
    /// </summary>
    [DataMember(Name = "outstandingBalance", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "outstandingBalance")]
    public long? OutstandingBalance { get; set; }

    /// <summary>
    ///     Gets or Sets Lines
    /// </summary>
    [DataMember(Name = "lines", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "lines")]
    public List<OrderLine> Lines { get; set; }

    /// <summary>
    ///     Gets or Sets Customer
    /// </summary>
    [DataMember(Name = "customer", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "customer")]
    public Contact Customer { get; set; }

    /// <summary>
    ///     ISO 4217 currency code
    /// </summary>
    /// <value>ISO 4217 currency code</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    ///     Due date of the invoice, format yyyy-mm-dd
    /// </summary>
    /// <value>Due date of the invoice, format yyyy-mm-dd</value>
    [DataMember(Name = "dueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    ///     Norwegian KID number. Number from 2 to 25 digits long.
    /// </summary>
    /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
    [DataMember(Name = "kid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "kid")]
    public string Kid { get; set; }

    /// <summary>
    ///     Gets or Sets PaymentAccount
    /// </summary>
    [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentAccount")]
    public string PaymentAccount { get; set; }

    /// <summary>
    ///     Gets or Sets SalePayments
    /// </summary>
    [DataMember(Name = "salePayments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "salePayments")]
    public List<Payment> SalePayments { get; set; }

    /// <summary>
    ///     Gets or Sets SaleAttachments
    /// </summary>
    [DataMember(Name = "saleAttachments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "saleAttachments")]
    public List<Attachment> SaleAttachments { get; set; }

    /// <summary>
    ///     Payment date of the invoice, format yyyy-mm-dd
    /// </summary>
    /// <value>Payment date of the invoice, format yyyy-mm-dd</value>
    [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentDate")]
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    ///     Gets or Sets Project
    /// </summary>
    [DataMember(Name = "project", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project")]
    public ProjectResult Project { get; set; }

    /// <summary>
    ///     Whether the sale has been deleted or not
    /// </summary>
    /// <value>Whether the sale has been deleted or not</value>
    [DataMember(Name = "deleted", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "deleted")]
    public bool? Deleted { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SaleResult {\n");
        sb.Append("  SaleId: ")
          .Append(SaleId)
          .Append("\n");
        sb.Append("  TransactionId: ")
          .Append(TransactionId)
          .Append("\n");
        sb.Append("  SaleNumber: ")
          .Append(SaleNumber)
          .Append("\n");
        sb.Append("  Date: ")
          .Append(Date)
          .Append("\n");
        sb.Append("  Kind: ")
          .Append(Kind)
          .Append("\n");
        sb.Append("  NetAmount: ")
          .Append(NetAmount)
          .Append("\n");
        sb.Append("  VatAmount: ")
          .Append(VatAmount)
          .Append("\n");
        sb.Append("  Settled: ")
          .Append(Settled)
          .Append("\n");
        sb.Append("  WriteOff: ")
          .Append(WriteOff)
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
        sb.Append("  Customer: ")
          .Append(Customer)
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
        sb.Append("  SalePayments: ")
          .Append(SalePayments)
          .Append("\n");
        sb.Append("  SaleAttachments: ")
          .Append(SaleAttachments)
          .Append("\n");
        sb.Append("  PaymentDate: ")
          .Append(PaymentDate)
          .Append("\n");
        sb.Append("  Project: ")
          .Append(Project)
          .Append("\n");
        sb.Append("  Deleted: ")
          .Append(Deleted)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}