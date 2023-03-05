# IO.Swagger.Model.SendFakturaisjRequest

## Properties

 Name                           | Type                                                                                                                                            | Description                                                      | Notes
--------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------|------------
 **Method**                     | **List&lt;string&gt;**                                                                                                                          | The method of sending. Has to be auto, email, ehf, vipps or sms. |
 **IncludeDocumentAttachments** | **
 bool?**                        | Whether the document&#x27;s attachment should be included when sending (True) or not (False).                                                   | [default to true]
 **RecipientName**              | **string**                                                                                                                                      |                                                                  | [optional]
 **RecipientEmail**             | **string**                                                                                                                                      |                                                                  | [optional]
 **Message**                    | **string**                                                                                                                                      | Additional message to send with document.                        | [optional]
 **EmailSendOption**            | **
 string**                       | document_link, attachment or auto. Defaults to auto which uses customer/company settings.                                                       | [optional] [default to EmailSendOptionEnum.AutoEnum]
 **OrganizationNumber**         | **
 string**                       | Brreg organiztion number. Defaults to the customers organization number if not provided.                                                        | [optional]
 **MobileNumber**               | **
 string**                       | Defaults to the customers phone number. Format should include the country code. If a Norwegian phone number, the country code is not necessary. | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

