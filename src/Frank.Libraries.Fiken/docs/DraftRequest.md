# IO.Swagger.Model.DraftRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceIssueDate** | **DateTime?** | Issue date of the draft, format yyyy-mm-dd | [optional]
**DueDate** | **DateTime?** | Due date of draft, format yyyy-mm-dd | [optional]
**InvoiceNumber** | **
string** | If invoice associated with draft, this is the invoice number (not to be confused with the invoiceId of an invoice issued from Fiken) | [optional]
**ContactId** | **long?** | Contact Id | [optional]
**ProjectId** | **
long?** | Project ID if only 1 project associated with entire draft. It is also possible to specify the project on individual draft lines | [optional]
**Cash** | **bool?** | If a cash sale/purchase (true) or otherwise (false) |
**Currency** | **string** | ISO 4217 currency code | [optional]
**Kid** | **string** | Norwegian KID number. Number from 2 to 25 digits long. | [optional]
**Paid** | **bool?** | Whether the sale/purchase has been paid (true) or not (false) | [optional]
**Payments** | [**List&lt;Payment&gt;**](Payment.md) |  | [optional]
**Lines** | [**List&lt;DraftLineRequest&gt;**](DraftLineRequest.md) |  |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

