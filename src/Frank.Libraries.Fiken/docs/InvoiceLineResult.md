# IO.Swagger.Model.InvoiceLineResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Net** | **long?** | Net amount of invoice line in cents in original currency. | [optional]
**Vat** | **long?** | VAT amount of invoice line in cents in original currency. | [optional]
**VatType** | **
string** | Taken from either 1) the line or 2) the product. At least vatType or vatPercent has to be specified. If both are specified, Fiken will assert that the given vat type matches the given vat percent for the issue date. One of: {\&quot;HIGH\&quot;, \&quot;MEDIUM\&quot;, \&quot;LOW\&quot;, \&quot;EXEMPT\&quot;, \&quot;EXEMPT_IMPORT_EXPORT\&quot;, \&quot;EXEMPT_REVERSE\&quot;, \&quot;OUTSIDE\&quot;, \&quot;NONE\&quot;}. \&quot;HIGH\&quot; is the most common. Example: High  | [optional]
**Gross** | **long?** | Gross amount of invoice line in cents. | [optional]
**NetInNok** | **
long?** | Net amount of invoice line in cents in NOK if currency and amounts provided are in foreign currency. This is calculated by Fiken. | [optional]
**VatInNok** | **
long?** | VAT amount of invoice line in cents in NOK if currency and amounts provided are in foreign currency. This is calculated by Fiken. | [optional]
**GrossInNok** | **
long?** | Gross amount of invoice line in cents in NOK if currency and amounts provided are in foreign currency. This is calculated by Fiken. | [optional]
**VatInPercent** | [**
decimal?**](BigDecimal.md) | Percentage value of VAT charged on invoice line. Should be a value between 0 and 100. Can be decimal values such as 25.5 | [optional]
**UnitPrice** | **long?** | Net price per unit in invoice currency (in cents). | [optional]
**Quantity** | [**decimal?**](BigDecimal.md) | Number of units to be invoiced. | [optional]
**Discount** | [**
decimal?**](BigDecimal.md) | If field is set, all amounts must be given before the discount is applied. The API will calculate the new totals. Discount value should be a value between 0 and 100. | [optional]
**ProductId** | **long?** | Product Id of product associated with invoice line. | [optional]
**ProductName** | **string** | Name of product to be printed on invoice line. | [optional]
**Description** | **string** | Description of the invoiced product or service. | [optional]
**Comment** | **string** | Additional information to be printed on invoice. | [optional]
**IncomeAccount** | **
string** | Field is similar to vatType, it defaults to the product&#x27;s income account. Either the line or the product needs to have an income account set. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

