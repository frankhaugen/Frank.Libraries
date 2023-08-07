using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
///     Returns a payment object with additional fields currrencyAmount, currency, and fee if it is a foreign currency
///     payment
/// </summary>
public class Payment
{
    /// <summary>
    ///     Id of given payment.
    /// </summary>
    /// <value>Id of given payment.</value>
    [DataMember(Name = "paymentId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentId")]
    public long? PaymentId { get; set; }

    /// <summary>
    ///     Payment date, format yyyy-mm-dd
    /// </summary>
    /// <value>Payment date, format yyyy-mm-dd</value>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    ///     Account associated with payment.
    /// </summary>
    /// <value>Account associated with payment.</value>
    [DataMember(Name = "account", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "account")]
    public string Account { get; set; }

    /// <summary>
    ///     Amount paid in the specified currency. If no currency is provided then currency defaults to \"NOK\". Formatted in
    ///     cents (34000 = 340.00)
    /// </summary>
    /// <value>
    ///     Amount paid in the specified currency. If no currency is provided then currency defaults to \"NOK\". Formatted
    ///     in cents (34000 = 340.00)
    /// </value>
    [DataMember(Name = "amount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amount")]
    public long? Amount { get; set; }

    /// <summary>
    ///     Attribute of a foreign payment only. Calculated by Fiken if amount is provided in currency other than NOK.
    ///     Formatted in cents (500000 = 5000.00)
    /// </summary>
    /// <value>
    ///     Attribute of a foreign payment only. Calculated by Fiken if amount is provided in currency other than NOK.
    ///     Formatted in cents (500000 = 5000.00)
    /// </value>
    [DataMember(Name = "amountInNok", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "amountInNok")]
    public long? AmountInNok { get; set; }

    /// <summary>
    ///     Only specify the currency if other than \"NOK\", otherwise default currency is \"NOK\". ISO 4217 currency code
    /// </summary>
    /// <value>Only specify the currency if other than \"NOK\", otherwise default currency is \"NOK\". ISO 4217 currency code</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    ///     Any fees additional to the amount paid in the specified currency (\"NOK\" default value).
    /// </summary>
    /// <value>Any fees additional to the amount paid in the specified currency (\"NOK\" default value).</value>
    [DataMember(Name = "fee", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "fee")]
    public long? Fee { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Payment {\n");
        sb.Append("  PaymentId: ")
          .Append(PaymentId)
          .Append("\n");
        sb.Append("  Date: ")
          .Append(Date)
          .Append("\n");
        sb.Append("  Account: ")
          .Append(Account)
          .Append("\n");
        sb.Append("  Amount: ")
          .Append(Amount)
          .Append("\n");
        sb.Append("  AmountInNok: ")
          .Append(AmountInNok)
          .Append("\n");
        sb.Append("  Currency: ")
          .Append(Currency)
          .Append("\n");
        sb.Append("  Fee: ")
          .Append(Fee)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}