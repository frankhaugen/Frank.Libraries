# IO.Swagger.Api.InboxApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInboxDocument**](InboxApi.md#createinboxdocument) | **POST** /companies/{companySlug}/inbox |
[**GetInbox**](InboxApi.md#getinbox) | **GET** /companies/{companySlug}/inbox |
[**GetInboxDocument**](InboxApi.md#getinboxdocument) | **GET** /companies/{companySlug}/inbox/{inboxDocumentId} |

<a name="createinboxdocument"></a>

# **CreateInboxDocument**

> void CreateInboxDocument (string name, string filename, string description, byte[] file, string companySlug)



Upload a document to the inbox

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInboxDocumentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi();
            var name = name_example;  // string |
            var filename = filename_example;  // string |
            var description = description_example;  // string |
            var file = file_example;  // byte[] |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateInboxDocument(name, filename, description, file, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboxApi.CreateInboxDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**name** | **string**|  |
**filename** | **string**|  |
**description** | **string**|  |
**file** | **byte[]****byte[]**|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinbox"></a>

# **GetInbox**

> List<InboxResult> GetInbox (string companySlug, int? page, int? pageSize, string sortBy, string status, string name)



Returns the contents of the inbox for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInboxExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. (optional)  (default to createdDate desc)
            var status = status_example;  // string |  (optional)  (default to all)
            var name = name_example;  // string | Filter documents based on their name, case-insensitive substring match. (optional)

            try
            {
                List&lt;InboxResult&gt; result = apiInstance.GetInbox(companySlug, page, pageSize, sortBy, status, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboxApi.GetInbox: " + e.Message );
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
**sortBy** | **
string**| Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. | [optional] [default to createdDate desc]
**status** | **string**|  | [optional] [default to all]
**name** | **string**| Filter documents based on their name, case-insensitive substring match. | [optional]

### Return type

[**List<InboxResult>**](InboxResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboxdocument"></a>

# **GetInboxDocument**

> InboxResult GetInboxDocument (string companySlug, long? inboxDocumentId)



Returns the inbox document with specified id

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInboxDocumentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InboxApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var inboxDocumentId = 789;  // long? |

            try
            {
                InboxResult result = apiInstance.GetInboxDocument(companySlug, inboxDocumentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboxApi.GetInboxDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**inboxDocumentId** | **long?**|  |

### Return type

[**InboxResult**](InboxResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

