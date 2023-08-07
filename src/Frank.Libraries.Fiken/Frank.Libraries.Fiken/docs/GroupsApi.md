# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                  | HTTP request                            | Description
-----------------------------------------|-----------------------------------------|-------------
 [**GetGroups**](GroupsApi.md#getgroups) | **GET** /companies/{companySlug}/groups |

<a name="getgroups"></a>

# **GetGroups**

> List<string> GetGroups (string companySlug, int? page, int? pageSize)



Returns all customer groups for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;string&gt; result = apiInstance.GetGroups(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                                                           | Description                 | Notes
-----------------|------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug** | **string**                                                                                                                                     | Slug of company to retrieve |
 **page**        | **
 int?**          | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.              | [optional] [default to 0]
 **pageSize**    | **
 int?**          | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. | [optional] [default to 25]

### Return type

**List<string>**

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

