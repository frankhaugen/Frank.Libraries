# IO.Swagger.Model.PurchaseRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **long?** |  | [optional]
**Identifier** | **string** | Invoice/sale number or similar. | [optional]
**Date** | **DateTime?** | Payment date, format yyyy-mm-dd |
**DueDate** | **DateTime?** | Due date of the invoice, format yyyy-mm-dd | [optional]
**Kind** | **string** | Purchased with cash or through a supplier. |
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  |
**SupplierId** | **long?** | Id of supplier if not a cash purchase. | [optional]
**Currency** | **string** | ISO 4217 currency code |
**PaymentAccount** | **string** |  | [optional]
**PaymentDate** | **DateTime?** | Payment date, format yyyy-mm-dd | [optional]
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional]
**ProjectId** | **long?** | Id of given project. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

