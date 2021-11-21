# IO.Swagger.Model.InvoiceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **
string** | UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters. If not provided, API will generate a UUID. | [optional]
**IssueDate** | **DateTime?** | Date that the invoice was issued, format yyyy-mm-dd |
**DueDate** | **DateTime?** | Due date of invoice, format yyyy-mm-dd |
**Lines** | [**List&lt;InvoiceLineRequest&gt;**](InvoiceLineRequest.md) |  |
**OurReference** | **string** |  | [optional]
**YourReference** | **string** | Your reference for invoice, free string format | [optional]
**OrderReference** | **string** | Reference if sending via EHF. | [optional]
**CustomerId** | **long?** | customerId &#x3D; contactId where customer &#x3D; true |
**ContactPersonId** | **long?** | Id of the contact person. Must be associated with the provided customer. | [optional]
**BankAccountCode** | **string** | Bank account code associated with invoice, format 1920:XXXXX |
**Currency** | **string** | ISO 4217 currency code. Defaults to \&quot;NOK\&quot; if unspecified. | [optional]
**InvoiceText** | **string** |  | [optional]
**Cash** | **bool?** | Payment taken in cash (True) or not (False). |
**PaymentAccount** | **string** | For Cash Invoices only. For instance \&quot;1920:10001\&quot;. | [optional]
**ProjectId** | **long?** | Optional - Associated project for the invoice to be created. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

