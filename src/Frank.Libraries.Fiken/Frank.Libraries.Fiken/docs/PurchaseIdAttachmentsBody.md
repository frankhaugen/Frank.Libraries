# IO.Swagger.Model.PurchaseIdAttachmentsBody

## Properties

 Name                | Type                                                                                                                                                                                                                                          | Description                                                        | Notes
---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------|------------
 **Filename**        | **string**                                                                                                                                                                                                                                    | The filename. Must end with either .png, .jpeg, .jpg, .gif or .pdf | [optional]
 **AttachToPayment** | **
 bool?**             | True if this attachment may document the payment (i.e. transaction receipt from credit card/payment company, export from bank, etc.). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true. | [optional]
 **AttachToSale**    | **
 bool?**             | True if this attachment may document the sale (i.e. invoice, etc). Default value is false if not specified. At least one of attachToPayment and attachToSale must be true.                                                                    | [optional]
 **File**            | **byte[]**                                                                                                                                                                                                                                    |                                                                    | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

