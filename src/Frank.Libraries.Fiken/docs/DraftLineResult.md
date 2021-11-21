# IO.Swagger.Model.DraftLineResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Description of the sale/purchase line. | [optional]
**VatType** | **
string** | Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis, medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible, medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible, high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible, high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]  | [optional]
**IncomeAccount** | **
string** | Field is similar to vatType, it defaults to the product&#x27;s income account. Either the line or the product needs to have an income account set. | [optional]
**Net** | **long?** | Net amount (in creditNote currency) in cents. | [optional]
**Gross** | **long?** | Gross amount (&#x3D; net+VAT) (in creditNote currency) in cents. | [optional]
**Project** | [**ProjectResult**](ProjectResult.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

