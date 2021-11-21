# IO.Swagger.Model.InvoiceishDraftLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **long?** | Product to be credited/debited on invoice draft line. | [optional]
**Description** | **string** | Description of the invoiced product or service. | [optional]
**UnitPrice** | **long?** | Net price per unit in invoice currency (in cents). | [optional]
**VatType** | **
string** | Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis, medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible, medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible, high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible, high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]  | [optional]
**Quantity** | [**decimal?**](BigDecimal.md) | Number of units to be invoiced. |
**Discount** | [**
decimal?**](BigDecimal.md) | Percentage discount charged on invoice draft line. Should be a value between 0 and 100. Can be decimal values such as 25.5 | [optional]
**Comment** | **string** | Additional information to be printed on invoice. | [optional]
**IncomeAccount** | **
string** | Field is similar to vatType, it defaults to the product&#x27;s income account. Either the line or the product needs to have an income account set. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

