# IO.Swagger.Api.OrderConfirmationsApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                                                                        | HTTP request | Description
---------------------------------------------------------------------------------------------------------------|--------------|-------------
 [**AddAttachmentToOrderConfirmationDraft**](OrderConfirmationsApi.md#addattachmenttoorderconfirmationdraft)   | **
 POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments                               |
 [**CreateInvoicDraftFromOrderConfirmation**](OrderConfirmationsApi.md#createinvoicdraftfromorderconfirmation) | **
 POST** /companies/{companySlug}/orderConfirmations/{confirmationId}/createInvoiceDraft                        |
 [**CreateOrderConfirmationDraft**](OrderConfirmationsApi.md#createorderconfirmationdraft)                     | **
 POST** /companies/{companySlug}/orderConfirmations/drafts                                                     |
 [**CreateOrderConfirmationFromDraft**](OrderConfirmationsApi.md#createorderconfirmationfromdraft)             | **
 POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/createOrderConfirmation                   |
 [**DeleteOrderConfirmationDraft**](OrderConfirmationsApi.md#deleteorderconfirmationdraft)                     | **
 DELETE** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                         |
 [**GetOrderConfirmation**](OrderConfirmationsApi.md#getorderconfirmation)                                     | **
 GET** /companies/{companySlug}/orderConfirmations/{confirmationId}                                            |
 [**GetOrderConfirmationDraft**](OrderConfirmationsApi.md#getorderconfirmationdraft)                           | **
 GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                            |
 [**GetOrderConfirmationDraftAttachments**](OrderConfirmationsApi.md#getorderconfirmationdraftattachments)     | **
 GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments                                |
 [**GetOrderConfirmationDrafts**](OrderConfirmationsApi.md#getorderconfirmationdrafts)                         | **
 GET** /companies/{companySlug}/orderConfirmations/drafts                                                      |
 [**GetOrderConfirmations**](OrderConfirmationsApi.md#getorderconfirmations)                                   | **
 GET** /companies/{companySlug}/orderConfirmations                                                             |
 [**UpdateOrderConfirmationDraft**](OrderConfirmationsApi.md#updateorderconfirmationdraft)                     | **
 PUT** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                            |

<a name="addattachmenttoorderconfirmationdraft"></a>

# **AddAttachmentToOrderConfirmationDraft**

> void AddAttachmentToOrderConfirmationDraft (string companySlug, long? draftId, string filename, string comment, byte[]
> file)



Creates and adds a new attachment to an order confirmation draft

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToOrderConfirmationDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var comment = comment_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToOrderConfirmationDraft(companySlug, draftId, filename, comment, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.AddAttachmentToOrderConfirmationDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                 | Description                                                                              | Notes
-----------------|----------------------|------------------------------------------------------------------------------------------|------------
 **companySlug** | **string**           | Slug of company to retrieve                                                              |
 **draftId**     | **long?**            | The draftId (primary key of the returned object) is returned in the GET all drafts call. |
 **filename**    | **string**           |                                                                                          | [optional]
 **comment**     | **string**           |                                                                                          | [optional]
 **file**        | **byte[]****byte[]** |                                                                                          | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvoicdraftfromorderconfirmation"></a>

# **CreateInvoicDraftFromOrderConfirmation**

> void CreateInvoicDraftFromOrderConfirmation (string companySlug, string confirmationId)



Creates an invoice draft from an order confirmation

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInvoicDraftFromOrderConfirmationExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var confirmationId = confirmationId_example;  // string | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call

            try
            {
                apiInstance.CreateInvoicDraftFromOrderConfirmation(companySlug, confirmationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateInvoicDraftFromOrderConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name               | Type                                                                                                                           | Description                 | Notes
--------------------|--------------------------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug**    | **string**                                                                                                                     | Slug of company to retrieve |
 **confirmationId** | **
 string**           | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorderconfirmationdraft"></a>

# **CreateOrderConfirmationDraft**

> void CreateOrderConfirmationDraft (InvoiceishDraftRequest body, string companySlug)



Creates an order confirmation draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrderConfirmationDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateOrderConfirmationDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                    | Description                 | Notes
-----------------|---------------------------------------------------------|-----------------------------|-------
 **body**        | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md) |                             |
 **companySlug** | **string**                                              | Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorderconfirmationfromdraft"></a>

# **CreateOrderConfirmationFromDraft**

> void CreateOrderConfirmationFromDraft (string companySlug, long? draftId)



Creates an order confirmation from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrderConfirmationFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreateOrderConfirmationFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.CreateOrderConfirmationFromDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                                                              | Notes
-----------------|------------|------------------------------------------------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                                                              |
 **draftId**     | **long?**  | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorderconfirmationdraft"></a>

# **DeleteOrderConfirmationDraft**

> void DeleteOrderConfirmationDraft (string companySlug, long? draftId)



Delete order confirmation draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOrderConfirmationDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeleteOrderConfirmationDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.DeleteOrderConfirmationDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                                                              | Notes
-----------------|------------|------------------------------------------------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                                                              |
 **draftId**     | **long?**  | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderconfirmation"></a>

# **GetOrderConfirmation**

> OrderConfirmation GetOrderConfirmation (string companySlug, string confirmationId)



Returns order confirmation with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderConfirmationExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var confirmationId = confirmationId_example;  // string | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call

            try
            {
                OrderConfirmation result = apiInstance.GetOrderConfirmation(companySlug, confirmationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name               | Type                                                                                                                           | Description                 | Notes
--------------------|--------------------------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug**    | **string**                                                                                                                     | Slug of company to retrieve |
 **confirmationId** | **
 string**           | The confirmationId (primary key of the returned object) is returned as the first field in the GET all order confirmations call |

### Return type

[**OrderConfirmation**](OrderConfirmation.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderconfirmationdraft"></a>

# **GetOrderConfirmationDraft**

> InvoiceishDraftResult GetOrderConfirmationDraft (string companySlug, long? draftId)



Returns order confirmation draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderConfirmationDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                InvoiceishDraftResult result = apiInstance.GetOrderConfirmationDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                                                              | Notes
-----------------|------------|------------------------------------------------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                                                              |
 **draftId**     | **long?**  | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

[**InvoiceishDraftResult**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderconfirmationdraftattachments"></a>

# **GetOrderConfirmationDraftAttachments**

> List<Attachment> GetOrderConfirmationDraftAttachments (string companySlug, long? draftId)



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
    public class GetOrderConfirmationDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetOrderConfirmationDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDraftAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                                                              | Notes
-----------------|------------|------------------------------------------------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                                                              |
 **draftId**     | **long?**  | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderconfirmationdrafts"></a>

# **GetOrderConfirmationDrafts**

> List<InvoiceishDraftResult> GetOrderConfirmationDrafts (string companySlug, int? page, int? pageSize)



Returns all order confirmation drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderConfirmationDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;InvoiceishDraftResult&gt; result = apiInstance.GetOrderConfirmationDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmationDrafts: " + e.Message );
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

[**List<InvoiceishDraftResult>**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderconfirmations"></a>

# **GetOrderConfirmations**

> List<OrderConfirmation> GetOrderConfirmations (string companySlug, int? page, int? pageSize)



Returns all order confirmations for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderConfirmationsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;OrderConfirmation&gt; result = apiInstance.GetOrderConfirmations(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.GetOrderConfirmations: " + e.Message );
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

[**List<OrderConfirmation>**](OrderConfirmation.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorderconfirmationdraft"></a>

# **UpdateOrderConfirmationDraft**

> void UpdateOrderConfirmationDraft (InvoiceishDraftRequest body, string companySlug, long? draftId)



Updates order confirmation draft with provided id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateOrderConfirmationDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderConfirmationsApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdateOrderConfirmationDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderConfirmationsApi.UpdateOrderConfirmationDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                    | Description                                                                              | Notes
-----------------|---------------------------------------------------------|------------------------------------------------------------------------------------------|-------
 **body**        | [**InvoiceishDraftRequest**](InvoiceishDraftRequest.md) |                                                                                          |
 **companySlug** | **string**                                              | Slug of company to retrieve                                                              |
 **draftId**     | **long?**                                               | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

