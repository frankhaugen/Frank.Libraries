# IO.Swagger.Model.PurchaseResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PurchaseId** | **long?** | Id of given purchase. | [optional]
**TransactionId** | **long?** |  | [optional]
**Identifier** | **string** | Invoice/sale number or similar. | [optional]
**Date** | **DateTime?** | Payment date, format yyyy-mm-dd |
**DueDate** | **DateTime?** | Due date of the invoice, format yyyy-mm-dd | [optional]
**Kind** | **string** | Purchased with cash or through a supplier. |
**Paid** | **bool?** |  |
**Lines** | [**List&lt;OrderLine&gt;**](OrderLine.md) |  |
**Supplier** | [**Contact**](Contact.md) |  | [optional]
**Currency** | **string** | ISO 4217 currency code |
**PaymentAccount** | **string** |  | [optional]
**PaymentDate** | **DateTime?** | Payment date, format yyyy-mm-dd | [optional]
**Payments** | [**List&lt;Payment&gt;**](Payment.md) |  | [optional]
**PurchaseAttachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional]
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional]
**Project** | [**List&lt;ProjectResult&gt;**](ProjectResult.md) |  | [optional]
**Deleted** | **bool?** | Whether the purchase has been deleted or not | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

