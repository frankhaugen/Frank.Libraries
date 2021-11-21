# IO.Swagger.Model.CreditNoteLineResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncomeAccount** | **
string** | Field is similar to vatType, it defaults to the product&#x27;s income account. Either the line or the product needs to have an income account set. | [optional]
**VatType** | **
string** | One of: {\&quot;HIGH\&quot;, \&quot;MEDIUM\&quot;, \&quot;LOW\&quot;, \&quot;EXEMPT\&quot;, \&quot;EXEMPT_IMPORT_EXPORT\&quot;, \&quot;EXEMPT_REVERSE\&quot;, \&quot;OUTSIDE\&quot;, \&quot;NONE\&quot;}. \&quot;HIGH\&quot; is the most common. Example: High  | [optional]
**UnitPrice** | **long?** | Net price per unit in invoice currency (in cents). |
**Quantity** | [**decimal?**](BigDecimal.md) | Number of units to be invoiced. |
**Discount** | [**
decimal?**](BigDecimal.md) | If field is set, all amounts must be given before the discount is applied. The API will calculate the new totals. Discount value should be a percent with a value between 0 and 100. Decimal values such as 25.5 are also allowed. | [optional]
**ProductId** | **long?** | Product Id of product associated with invoice line. | [optional]
**Description** | **string** | Description of the invoiced product or service. | [optional]
**Comment** | **string** | Additional information to be printed on invoice. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

