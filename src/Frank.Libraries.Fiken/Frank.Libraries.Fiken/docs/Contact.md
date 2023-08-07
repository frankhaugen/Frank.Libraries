# IO.Swagger.Model.Contact

## Properties

 Name                          | Type                                                                                                              | Description                                                          | Notes
-------------------------------|-------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------|------------
 **ContactId**                 | **long?**                                                                                                         |                                                                      | [optional]
 **LastModifiedDate**          | **DateTime?**                                                                                                     | Date that product was last modified in Fiken, format yyyy-mm-dd.     | [optional]
 **Name**                      | **string**                                                                                                        |                                                                      |
 **Email**                     | **string**                                                                                                        |                                                                      | [optional]
 **OrganizationNumber**        | **string**                                                                                                        | Brreg organiztion number.                                            | [optional]
 **CustomerNumber**            | **long?**                                                                                                         |                                                                      | [optional]
 **CustomerAccountCode**       | **string**                                                                                                        | Format 1500:XXXXX                                                    | [optional]
 **PhoneNumber**               | **string**                                                                                                        |                                                                      | [optional]
 **MemberNumber**              | [**
 decimal?**](BigDecimal.md)    | A number that can be used to connect a contact to your own data.                                                  | [optional]
 **SupplierNumber**            | **long?**                                                                                                         |                                                                      | [optional]
 **SupplierAccountCode**       | **string**                                                                                                        | Format 2400:XXXXX                                                    | [optional]
 **Customer**                  | **
 bool?**                       | True if the contact is a customer. It is possible for a contact to be both customer and supplier.                 | [optional] [default to false]
 **Supplier**                  | **
 bool?**                       | True if the contact is a supplier. It is possible for a contact to be both supplier and customer.                 | [optional] [default to false]
 **ContactPerson**             | [**List&lt;ContactPerson&gt;**](ContactPerson.md)                                                                 |                                                                      | [optional]
 **Notes**                     | [**List&lt;ContactNote&gt;**](ContactNote.md)                                                                     |                                                                      | [optional]
 **Currency**                  | **
 string**                      | ISO 4217 currency code. Default foreign currency to use when creating invoice to this contact (USD, EUR, SEK etc) | [optional]
 **Language**                  | **
 string**                      | The language to use when sending documents to this contact. NORWEGIAN or ENGLISH. Defaults to NORWEGIAN.          | [optional]
 **Inactive**                  | **bool?**                                                                                                         | Whether the contact has been deactivated (true) or is active (false) | [optional]
 **DaysUntilInvoicingDueDate** | **int?**                                                                                                          | Default number of days until due date for invoices.                  | [optional]
 **Address**                   | [**Address**](Address.md)                                                                                         |                                                                      | [optional]
 **Groups**                    | **List&lt;string&gt;**                                                                                            |                                                                      | [optional]
 **Documents**                 | [**List&lt;Attachment&gt;**](Attachment.md)                                                                       |                                                                      | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

