# IO.Swagger.Api.CreditNotesApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachmentToCreditNoteDraft**](CreditNotesApi.md#addattachmenttocreditnotedraft) | **
POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments |
[**CreateCreditNoteDraft**](CreditNotesApi.md#createcreditnotedraft) | **
POST** /companies/{companySlug}/creditNotes/drafts |
[**CreateCreditNoteFromDraft**](CreditNotesApi.md#createcreditnotefromdraft) | **
POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/createCreditNote |
[**CreateFullCreditNote**](CreditNotesApi.md#createfullcreditnote) | **
POST** /companies/{companySlug}/creditNotes/full |
[**CreatePartialCreditNote**](CreditNotesApi.md#createpartialcreditnote) | **
POST** /companies/{companySlug}/creditNotes/partial |
[**DeleteCreditNoteDraft**](CreditNotesApi.md#deletecreditnotedraft) | **
DELETE** /companies/{companySlug}/creditNotes/drafts/{draftId} |
[**GetCreditNote**](CreditNotesApi.md#getcreditnote) | **GET** /companies/{companySlug}/creditNotes/{creditNoteId} |
[**GetCreditNoteDraft**](CreditNotesApi.md#getcreditnotedraft) | **
GET** /companies/{companySlug}/creditNotes/drafts/{draftId} |
[**GetCreditNoteDraftAttachments**](CreditNotesApi.md#getcreditnotedraftattachments) | **
GET** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments |
[**GetCreditNoteDrafts**](CreditNotesApi.md#getcreditnotedrafts) | **GET** /companies/{companySlug}/creditNotes/drafts |
[**GetCreditNotes**](CreditNotesApi.md#getcreditnotes) | **GET** /companies/{companySlug}/creditNotes |
[**SendCreditNote**](CreditNotesApi.md#sendcreditnote) | **POST** /companies/{companySlug}/creditNotes/send |
[**UpdateCreditNoteDraft**](CreditNotesApi.md#updatecreditnotedraft) | **
PUT** /companies/{companySlug}/creditNotes/drafts/{draftId} |

<a name="addattachmenttocreditnotedraft"></a>

# **AddAttachmentToCreditNoteDraft**

> void AddAttachmentToCreditNoteDraft (string companySlug, long? draftId, string filename, string comment, byte[] file)



Creates and adds a new attachment to a credit note draft

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToCreditNoteDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var comment = comment_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToCreditNoteDraft(companySlug, draftId, filename, comment, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.AddAttachmentToCreditNoteDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |
**filename** | **string**|  | [optional]
**comment** | **string**|  | [optional]
**file** | **byte[]****byte[]**|  | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcreditnotedraft"></a>

# **CreateCreditNoteDraft**

> void CreateCreditNoteDraft (InvoiceishDraftRequest body, string companySlug)



Creates a credit note draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCreditNoteDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateCreditNoteDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcreditnotefromdraft"></a>

# **CreateCreditNoteFromDraft**

> void CreateCreditNoteFromDraft (string companySlug, long? draftId)



Creates a credit note from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCreditNoteFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreateCreditNoteFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateCreditNoteFromDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcreditnote"></a>

# **CreateFullCreditNote**

> void CreateFullCreditNote (FullCreditNoteRequest body, string companySlug)



Creates a new credit note.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFullCreditNoteExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var body = new FullCreditNoteRequest(); // FullCreditNoteRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateFullCreditNote(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreateFullCreditNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**FullCreditNoteRequest**](FullCreditNoteRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpartialcreditnote"></a>

# **CreatePartialCreditNote**

> void CreatePartialCreditNote (PartialCreditNoteRequest body, string companySlug)



Creates a new credit note.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePartialCreditNoteExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var body = new PartialCreditNoteRequest(); // PartialCreditNoteRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreatePartialCreditNote(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreatePartialCreditNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**PartialCreditNoteRequest**](PartialCreditNoteRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecreditnotedraft"></a>

# **DeleteCreditNoteDraft**

> void DeleteCreditNoteDraft (string companySlug, long? draftId)



Delete credit note draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCreditNoteDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeleteCreditNoteDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.DeleteCreditNoteDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditnote"></a>

# **GetCreditNote**

> CreditNoteResult GetCreditNote (string companySlug, string creditNoteId)



Returns credit note with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditNoteExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var creditNoteId = creditNoteId_example;  // string | The creditNoteId (primary key of the returned object) is returned as the first field in the GET all credit notes call; not to be confused with creditNoteNumber

            try
            {
                CreditNoteResult result = apiInstance.GetCreditNote(companySlug, creditNoteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**creditNoteId** | **
string**| The creditNoteId (primary key of the returned object) is returned as the first field in the GET all credit notes call; not to be confused with creditNoteNumber  |

### Return type

[**CreditNoteResult**](CreditNoteResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditnotedraft"></a>

# **GetCreditNoteDraft**

> InvoiceishDraftResult GetCreditNoteDraft (string companySlug, long? draftId)



Returns credit note draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditNoteDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                InvoiceishDraftResult result = apiInstance.GetCreditNoteDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |

### Return type

[**InvoiceishDraftResult**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditnotedraftattachments"></a>

# **GetCreditNoteDraftAttachments**

> List<Attachment> GetCreditNoteDraftAttachments (string companySlug, long? draftId)



Returns all attachments for specified draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditNoteDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetCreditNoteDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDraftAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditnotedrafts"></a>

# **GetCreditNoteDrafts**

> List<InvoiceishDraftResult> GetCreditNoteDrafts (string companySlug, int? page, int? pageSize)



Returns all credit note drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditNoteDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;InvoiceishDraftResult&gt; result = apiInstance.GetCreditNoteDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNoteDrafts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**page** | **
int?**| Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0]
**pageSize** | **
int?**| Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25]

### Return type

[**List<InvoiceishDraftResult>**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditnotes"></a>

# **GetCreditNotes**

> List<CreditNoteResult> GetCreditNotes (string companySlug, int? page, int? pageSize, DateTime? issueDate, DateTime? issueDateLe, DateTime? issueDateLt, DateTime? issueDateGe, DateTime? issueDateGt, long? customerId, bool? settled)



Returns all credit notes for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditNotesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var issueDate = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateLe = 2013-10-20;  // DateTime? | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateLt = 2013-10-20;  // DateTime? | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateGe = 2013-10-20;  // DateTime? | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateGt = 2013-10-20;  // DateTime? | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var customerId = 789;  // long? | Returns only credit notes sent to specified customer. Must be the contactId provided by a GET contacts call.  (optional)
            var settled = true;  // bool? | When set to true, returns only credit notes that have been settled. Otherwise false returns all credit notes that have not been fully settled.  (optional)

            try
            {
                List&lt;CreditNoteResult&gt; result = apiInstance.GetCreditNotes(companySlug, page, pageSize, issueDate, issueDateLe, issueDateLt, issueDateGe, issueDateGt, customerId, settled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.GetCreditNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**page** | **
int?**| Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  | [optional] [default to 0]
**pageSize** | **
int?**| Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  | [optional] [default to 25]
**issueDate** | **
DateTime?**| Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**issueDateLe** | **
DateTime?**| Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**issueDateLt** | **
DateTime?**| Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**issueDateGe** | **
DateTime?**| Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**issueDateGt** | **
DateTime?**| Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**customerId** | **
long?**| Returns only credit notes sent to specified customer. Must be the contactId provided by a GET contacts call.  | [optional]
**settled** | **
bool?**| When set to true, returns only credit notes that have been settled. Otherwise false returns all credit notes that have not been fully settled.  | [optional]

### Return type

[**List<CreditNoteResult>**](CreditNoteResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendcreditnote"></a>

# **SendCreditNote**

> void SendCreditNote (SendCreditNoteRequest body, string companySlug)



Sends the specified document

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendCreditNoteExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var body = new SendCreditNoteRequest(); // SendCreditNoteRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.SendCreditNote(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.SendCreditNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**SendCreditNoteRequest**](SendCreditNoteRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecreditnotedraft"></a>

# **UpdateCreditNoteDraft**

> void UpdateCreditNoteDraft (InvoiceishDraftRequest body, string companySlug, long? draftId)



Updates credit note draft with provided id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCreditNoteDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CreditNotesApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdateCreditNoteDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditNotesApi.UpdateCreditNoteDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**draftId** | **long?**| The draftId (primary key of the returned object) is returned in the GET all drafts call.  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

