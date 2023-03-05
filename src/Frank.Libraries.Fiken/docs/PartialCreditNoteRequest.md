# IO.Swagger.Model.PartialCreditNoteRequest

## Properties

 Name                | Type                                                                                                              | Description                                                       | Notes
---------------------|-------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------|------------
 **OurReference**    | **string**                                                                                                        | Optional                                                          | [optional]
 **YourReference**   | **string**                                                                                                        | Optional - Your reference for invoice, free string format.        | [optional]
 **OrderReference**  | **string**                                                                                                        | Reference if sending via EHF.                                     | [optional]
 **Project**         | **long?**                                                                                                         | Optional - Project associated with the credit note.               | [optional]
 **Currency**        | **string**                                                                                                        | ISO 4217 currency code                                            | [optional]
 **IssueDate**       | **DateTime?**                                                                                                     | Date that the credit note is issued, format yyyy-mm-dd            |
 **InvoiceId**       | **long?**                                                                                                         | Optional - Id of invoice that the credit note is associated with. | [optional]
 **ContactId**       | **long?**                                                                                                         | Id of contact that the credit note is associated with.            | [optional]
 **ContactPersonId** | **
 long?**             | Id of contact person that the credit note is associated with (Credit person must belong to the provided contact). | [optional]
 **CreditNoteText**  | **string**                                                                                                        |                                                                   | [optional]
 **Lines**           | [**List&lt;CreditNoteLineResult&gt;**](CreditNoteLineResult.md)                                                   |                                                                   |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

