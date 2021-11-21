# IO.Swagger.Model.Payment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **long?** | Id of given payment. | [optional]
**Date** | **DateTime?** | Payment date, format yyyy-mm-dd |
**Account** | **string** | Account associated with payment. |
**Amount** | **
long?** | Amount paid in the specified currency. If no currency is provided then currency defaults to \&quot;NOK\&quot;. Formatted in cents (34000 &#x3D; 340.00) |
**AmountInNok** | **
long?** | Attribute of a foreign payment only. Calculated by Fiken if amount is provided in currency other than NOK. Formatted in cents (500000 &#x3D; 5000.00) | [optional]
**Currency** | **
string** | Only specify the currency if other than \&quot;NOK\&quot;, otherwise default currency is \&quot;NOK\&quot;. ISO 4217 currency code | [optional]
**Fee** | **
long?** | Any fees additional to the amount paid in the specified currency (\&quot;NOK\&quot; default value). | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

