# IO.Swagger.Model.DraftResult

## Properties

 Name                 | Type                                                                                                                                                      | Description                                                   | Notes
----------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------|------------
 **DraftId**          | **long?**                                                                                                                                                 | Draft ID                                                      | [optional]
 **Uuid**             | **
 string**             | UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters. | [optional]
 **InvoiceIssueDate** | **DateTime?**                                                                                                                                             | Issue date of the draft, format yyyy-mm-dd                    | [optional]
 **DueDate**          | **DateTime?**                                                                                                                                             | Due date of draft, format yyyy-mm-dd                          | [optional]
 **InvoiceNumber**    | **
 string**             | If invoice associated with draft, this is the invoice number (not to be confused with the invoiceId of an invoice issued from Fiken)                      | [optional]
 **Contact**          | [**Contact**](Contact.md)                                                                                                                                 |                                                               | [optional]
 **Project**          | [**ProjectResult**](ProjectResult.md)                                                                                                                     |                                                               | [optional]
 **Cash**             | **bool?**                                                                                                                                                 | If a cash sale/purchase (true) or otherwise (false)           | [optional]
 **Currency**         | **string**                                                                                                                                                | ISO 4217 currency code                                        | [optional]
 **Kid**              | **string**                                                                                                                                                | Norwegian KID number. Number from 2 to 25 digits long.        | [optional]
 **Paid**             | **bool?**                                                                                                                                                 | Whether the sale/purchase has been paid (true) or not (false) | [optional]
 **Attachments**      | [**List&lt;Attachment&gt;**](Attachment.md)                                                                                                               |                                                               | [optional]
 **Payments**         | [**List&lt;Payment&gt;**](Payment.md)                                                                                                                     |                                                               | [optional]
 **Lines**            | [**List&lt;DraftLineResult&gt;**](DraftLineResult.md)                                                                                                     |                                                               | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

