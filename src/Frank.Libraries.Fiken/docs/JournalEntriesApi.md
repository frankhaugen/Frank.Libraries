# IO.Swagger.Api.JournalEntriesApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachmentToJournalEntry**](JournalEntriesApi.md#addattachmenttojournalentry) | **
POST** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments |
[**CreateGeneralJournalEntry**](JournalEntriesApi.md#creategeneraljournalentry) | **
POST** /companies/{companySlug}/generalJournalEntries |
[**GetJournalEntries**](JournalEntriesApi.md#getjournalentries) | **GET** /companies/{companySlug}/journalEntries |
[**GetJournalEntry**](JournalEntriesApi.md#getjournalentry) | **
GET** /companies/{companySlug}/journalEntries/{journalEntryId} |
[**GetJournalEntryAttachments**](JournalEntriesApi.md#getjournalentryattachments) | **
GET** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments |

<a name="addattachmenttojournalentry"></a>

# **AddAttachmentToJournalEntry**

> void AddAttachmentToJournalEntry (string companySlug, long? journalEntryId, string filename, byte[] file)



Creates and adds a new attachment to a Journal Entry

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToJournalEntryExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var journalEntryId = 789;  // long? |
            var filename = filename_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToJournalEntry(companySlug, journalEntryId, filename, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.AddAttachmentToJournalEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**journalEntryId** | **long?**|  |
**filename** | **string**|  | [optional]
**file** | **byte[]****byte[]**|  | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creategeneraljournalentry"></a>

# **CreateGeneralJournalEntry**

> void CreateGeneralJournalEntry (GeneralJournalEntryRequest body, string companySlug)



Creates a new general journal entry (fri postering).

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGeneralJournalEntryExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi();
            var body = new GeneralJournalEntryRequest(); // GeneralJournalEntryRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateGeneralJournalEntry(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.CreateGeneralJournalEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**GeneralJournalEntryRequest**](GeneralJournalEntryRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjournalentries"></a>

# **GetJournalEntries**

> List<JournalEntry> GetJournalEntries (string companySlug, int? page, int? pageSize, DateTime? date, DateTime? dateLe, DateTime? dateLt, DateTime? dateGe, DateTime? dateGt)



Returns all general journal entries (posteringer) for the specified company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJournalEntriesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var date = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var dateLe = 2013-10-20;  // DateTime? | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var dateLt = 2013-10-20;  // DateTime? | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var dateGe = 2013-10-20;  // DateTime? | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var dateGt = 2013-10-20;  // DateTime? | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)

            try
            {
                List&lt;JournalEntry&gt; result = apiInstance.GetJournalEntries(companySlug, page, pageSize, date, dateLe, dateLt, dateGe, dateGt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntries: " + e.Message );
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
**date** | **
DateTime?**| Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**dateLe** | **
DateTime?**| Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**dateLt** | **
DateTime?**| Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**dateGe** | **
DateTime?**| Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**dateGt** | **
DateTime?**| Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]

### Return type

[**List<JournalEntry>**](JournalEntry.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjournalentry"></a>

# **GetJournalEntry**

> JournalEntry GetJournalEntry (string companySlug, long? journalEntryId)



Returns all journal entries within a given company's Journal Entry Service

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJournalEntryExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var journalEntryId = 789;  // long? |

            try
            {
                JournalEntry result = apiInstance.GetJournalEntry(companySlug, journalEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**journalEntryId** | **long?**|  |

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjournalentryattachments"></a>

# **GetJournalEntryAttachments**

> List<Attachment> GetJournalEntryAttachments (string companySlug, long? journalEntryId)



Returns all attachments for a given Journal Entry

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetJournalEntryAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JournalEntriesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var journalEntryId = 789;  // long? |

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetJournalEntryAttachments(companySlug, journalEntryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalEntriesApi.GetJournalEntryAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**journalEntryId** | **long?**|  |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

