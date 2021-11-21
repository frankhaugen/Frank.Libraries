# IO.Swagger.Model.JournalEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JournalEntryId** | **long?** |  | [optional]
**TransactionId** | **long?** |  | [optional]
**OffsetTransactionId** | **
long?** | If a journal entry has been cancelled this provides the id of the balancing transaction | [optional]
**JournalEntryNumber** | **int?** |  | [optional]
**Description** | **string** |  |
**Date** | **DateTime?** |  |
**Lines** | [**List&lt;JournalEntryLine&gt;**](JournalEntryLine.md) |  |
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

