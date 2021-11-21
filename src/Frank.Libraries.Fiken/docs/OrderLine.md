# IO.Swagger.Model.OrderLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the product or service. | [optional]
**NetPrice** | **long?** | Net amount of order line in cents. | [optional]
**Vat** | **long?** | VAT amount of order line in cents. | [optional]
**Account** | **string** | Expense account (kostnadskonto) associated with payment. | [optional]
**VatType** | **
string** | Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis, medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible, medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible, high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible, high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]  |
**NetPriceInCurrency** | **long?** | Net amount in currency (in cents) | [optional]
**VatInCurrency** | **long?** | VAT amount in currency (in cents) | [optional]
**ProjectId** | **
long?** | If a purchase is split over several projects, project/line can be specified. This field is only to be used for purchases. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

