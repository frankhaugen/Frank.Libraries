# IO.Swagger.Model.InvoiceishDraftResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DraftId** | **long?** | Invoice draft ID | [optional]
**Uuid** | **
string** | UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters. | [optional]
**Type** | **string** | Type of invoice draft. | [optional] [default to TypeEnum.InvoiceEnum]
**IssueDate** | **DateTime?** | Issue date of the invoice draft, format yyyy-mm-dd | [optional]
**DaysUntilDueDate** | **int?** | Days until due date of the invoice draft. | [optional]
**InvoiceText** | **string** | Comment/description printed above the invoice lines | [optional]
**Currency** | **string** | ISO 4217 currency code | [optional]
**YourReference** | **string** |  | [optional]
**OurReference** | **string** |  | [optional]
**OrderReference** | **string** | Reference if sending invoice via EHF. | [optional]
**Lines** | [**List&lt;InvoiceishDraftLine&gt;**](InvoiceishDraftLine.md) |  | [optional]
**BankAccountNumber** | **string** |  | [optional]
**Iban** | **string** |  | [optional]
**Bic** | **string** |  | [optional]
**PaymentAccount** | **string** |  | [optional]
**Customers** | [**List&lt;Contact&gt;**](Contact.md) | Customer(s) to be invoiced. | [optional]
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional]
**CreatedFromInvoiceId** | **long?** |  | [optional]
**ProjectId** | **long?** |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

