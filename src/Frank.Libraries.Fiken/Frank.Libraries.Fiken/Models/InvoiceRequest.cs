using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class InvoiceRequest
{
    /// <summary>
    ///     UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form
    ///     8-4-4-4-12 for a total of 36 characters. If not provided, API will generate a UUID.
    /// </summary>
    /// <value>
    ///     UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form
    ///     8-4-4-4-12 for a total of 36 characters. If not provided, API will generate a UUID.
    /// </value>
    [DataMember(Name = "uuid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    ///     Date that the invoice was issued, format yyyy-mm-dd
    /// </summary>
    /// <value>Date that the invoice was issued, format yyyy-mm-dd</value>
    [DataMember(Name = "issueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "issueDate")]
    public DateTime? IssueDate { get; set; }

    /// <summary>
    ///     Due date of invoice, format yyyy-mm-dd
    /// </summary>
    /// <value>Due date of invoice, format yyyy-mm-dd</value>
    [DataMember(Name = "dueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    ///     Gets or Sets Lines
    /// </summary>
    [DataMember(Name = "lines", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "lines")]
    public List<InvoiceLineRequest> Lines { get; set; }

    /// <summary>
    ///     Gets or Sets OurReference
    /// </summary>
    [DataMember(Name = "ourReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ourReference")]
    public string OurReference { get; set; }

    /// <summary>
    ///     Your reference for invoice, free string format
    /// </summary>
    /// <value>Your reference for invoice, free string format</value>
    [DataMember(Name = "yourReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "yourReference")]
    public string YourReference { get; set; }

    /// <summary>
    ///     Reference if sending via EHF.
    /// </summary>
    /// <value>Reference if sending via EHF.</value>
    [DataMember(Name = "orderReference", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "orderReference")]
    public string OrderReference { get; set; }

    /// <summary>
    ///     customerId = contactId where customer = true
    /// </summary>
    /// <value>customerId = contactId where customer = true</value>
    [DataMember(Name = "customerId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "customerId")]
    public long? CustomerId { get; set; }

    /// <summary>
    ///     Id of the contact person. Must be associated with the provided customer.
    /// </summary>
    /// <value>Id of the contact person. Must be associated with the provided customer.</value>
    [DataMember(Name = "contactPersonId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contactPersonId")]
    public long? ContactPersonId { get; set; }

    /// <summary>
    ///     Bank account code associated with invoice, format 1920:XXXXX
    /// </summary>
    /// <value>Bank account code associated with invoice, format 1920:XXXXX</value>
    [DataMember(Name = "bankAccountCode", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "bankAccountCode")]
    public string BankAccountCode { get; set; }

    /// <summary>
    ///     ISO 4217 currency code. Defaults to \"NOK\" if unspecified.
    /// </summary>
    /// <value>ISO 4217 currency code. Defaults to \"NOK\" if unspecified.</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    ///     Gets or Sets InvoiceText
    /// </summary>
    [DataMember(Name = "invoiceText", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "invoiceText")]
    public string InvoiceText { get; set; }

    /// <summary>
    ///     Payment taken in cash (True) or not (False).
    /// </summary>
    /// <value>Payment taken in cash (True) or not (False).</value>
    [DataMember(Name = "cash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cash")]
    public bool? Cash { get; set; }

    /// <summary>
    ///     For Cash Invoices only. For instance \"1920:10001\".
    /// </summary>
    /// <value>For Cash Invoices only. For instance \"1920:10001\".</value>
    [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentAccount")]
    public string PaymentAccount { get; set; }

    /// <summary>
    ///     Optional - Associated project for the invoice to be created.
    /// </summary>
    /// <value>Optional - Associated project for the invoice to be created.</value>
    [DataMember(Name = "projectId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "projectId")]
    public long? ProjectId { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InvoiceRequest {\n");
        sb.Append("  Uuid: ")
          .Append(Uuid)
          .Append("\n");
        sb.Append("  IssueDate: ")
          .Append(IssueDate)
          .Append("\n");
        sb.Append("  DueDate: ")
          .Append(DueDate)
          .Append("\n");
        sb.Append("  Lines: ")
          .Append(Lines)
          .Append("\n");
        sb.Append("  OurReference: ")
          .Append(OurReference)
          .Append("\n");
        sb.Append("  YourReference: ")
          .Append(YourReference)
          .Append("\n");
        sb.Append("  OrderReference: ")
          .Append(OrderReference)
          .Append("\n");
        sb.Append("  CustomerId: ")
          .Append(CustomerId)
          .Append("\n");
        sb.Append("  ContactPersonId: ")
          .Append(ContactPersonId)
          .Append("\n");
        sb.Append("  BankAccountCode: ")
          .Append(BankAccountCode)
          .Append("\n");
        sb.Append("  Currency: ")
          .Append(Currency)
          .Append("\n");
        sb.Append("  InvoiceText: ")
          .Append(InvoiceText)
          .Append("\n");
        sb.Append("  Cash: ")
          .Append(Cash)
          .Append("\n");
        sb.Append("  PaymentAccount: ")
          .Append(PaymentAccount)
          .Append("\n");
        sb.Append("  ProjectId: ")
          .Append(ProjectId)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}