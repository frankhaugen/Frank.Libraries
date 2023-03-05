# IO.Swagger.Api.PurchasesApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                                           | HTTP request                                                | Description
----------------------------------------------------------------------------------|-------------------------------------------------------------|-------------
 [**AddAttachmentToPurchase**](PurchasesApi.md#addattachmenttopurchase)           | **
 POST** /companies/{companySlug}/purchases/{purchaseId}/attachments               |
 [**AddAttachmentToPurchaseDraft**](PurchasesApi.md#addattachmenttopurchasedraft) | **
 POST** /companies/{companySlug}/purchases/drafts/{draftId}/attachments           |
 [**CreatePurchase**](PurchasesApi.md#createpurchase)                             | **POST** /companies/{companySlug}/purchases                 |
 [**CreatePurchaseDraft**](PurchasesApi.md#createpurchasedraft)                   | **POST** /companies/{companySlug}/purchases/drafts          |
 [**CreatePurchaseFromDraft**](PurchasesApi.md#createpurchasefromdraft)           | **
 POST** /companies/{companySlug}/purchases/drafts/{draftId}/createPurchase        |
 [**CreatePurchasePayment**](PurchasesApi.md#createpurchasepayment)               | **
 POST** /companies/{companySlug}/purchases/{purchaseId}/payments                  |
 [**DeletePurchase**](PurchasesApi.md#deletepurchase)                             | **
 PATCH** /companies/{companySlug}/purchases/{purchaseId}/delete                   |
 [**DeletePurchaseDraft**](PurchasesApi.md#deletepurchasedraft)                   | **
 DELETE** /companies/{companySlug}/purchases/drafts/{draftId}                     |
 [**GetPurchase**](PurchasesApi.md#getpurchase)                                   | **GET** /companies/{companySlug}/purchases/{purchaseId}     |
 [**GetPurchaseAttachments**](PurchasesApi.md#getpurchaseattachments)             | **
 GET** /companies/{companySlug}/purchases/{purchaseId}/attachments                |
 [**GetPurchaseDraft**](PurchasesApi.md#getpurchasedraft)                         | **GET** /companies/{companySlug}/purchases/drafts/{draftId} |
 [**GetPurchaseDraftAttachments**](PurchasesApi.md#getpurchasedraftattachments)   | **
 GET** /companies/{companySlug}/purchases/drafts/{draftId}/attachments            |
 [**GetPurchaseDrafts**](PurchasesApi.md#getpurchasedrafts)                       | **GET** /companies/{companySlug}/purchases/drafts           |
 [**GetPurchasePayment**](PurchasesApi.md#getpurchasepayment)                     | **
 GET** /companies/{companySlug}/purchases/{purchaseId}/payments/{paymentId}       |
 [**GetPurchasePayments**](PurchasesApi.md#getpurchasepayments)                   | **
 GET** /companies/{companySlug}/purchases/{purchaseId}/payments                   |
 [**GetPurchases**](PurchasesApi.md#getpurchases)                                 | **GET** /companies/{companySlug}/purchases                  |
 [**UpdatePurchaseDraft**](PurchasesApi.md#updatepurchasedraft)                   | **
 PUT** /companies/{companySlug}/purchases/drafts/{draftId}                        |

<a name="addattachmenttopurchase"></a>

# **AddAttachmentToPurchase**

> void AddAttachmentToPurchase (string companySlug, long? purchaseId, string filename, bool? attachToPayment, bool?
> attachToSale, byte[] file)



Creates and adds a new attachment to a Purchase

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToPurchaseExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |
            var filename = filename_example;  // string |  (optional)
            var attachToPayment = true;  // bool? |  (optional)
            var attachToSale = true;  // bool? |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToPurchase(companySlug, purchaseId, filename, attachToPayment, attachToSale, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name                | Type                 | Description                 | Notes
---------------------|----------------------|-----------------------------|------------
 **companySlug**     | **string**           | Slug of company to retrieve |
 **purchaseId**      | **long?**            |                             |
 **filename**        | **string**           |                             | [optional]
 **attachToPayment** | **bool?**            |                             | [optional]
 **attachToSale**    | **bool?**            |                             | [optional]
 **file**            | **byte[]****byte[]** |                             | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addattachmenttopurchasedraft"></a>

# **AddAttachmentToPurchaseDraft**

> void AddAttachmentToPurchaseDraft (string companySlug, long? draftId, string filename, byte[] file)



Creates and adds a new attachment to a draft

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToPurchaseDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToPurchaseDraft(companySlug, draftId, filename, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.AddAttachmentToPurchaseDraft: " + e.Message );
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
 **file**        | **byte[]****byte[]** |                                                                                          | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpurchase"></a>

# **CreatePurchase**

> void CreatePurchase (PurchaseRequest body, string companySlug)



Creates a new purchase.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePurchaseExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var body = new PurchaseRequest(); // PurchaseRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreatePurchase(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                      | Description                 | Notes
-----------------|-------------------------------------------|-----------------------------|-------
 **body**        | [**PurchaseRequest**](PurchaseRequest.md) |                             |
 **companySlug** | **string**                                | Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpurchasedraft"></a>

# **CreatePurchaseDraft**

> void CreatePurchaseDraft (DraftRequest body, string companySlug)



Creates a purchase draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePurchaseDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var body = new DraftRequest(); // DraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreatePurchaseDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchaseDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                | Description                 | Notes
-----------------|-------------------------------------|-----------------------------|-------
 **body**        | [**DraftRequest**](DraftRequest.md) |                             |
 **companySlug** | **string**                          | Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpurchasefromdraft"></a>

# **CreatePurchaseFromDraft**

> void CreatePurchaseFromDraft (string companySlug, long? draftId)



Creates a purchase from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePurchaseFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreatePurchaseFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchaseFromDraft: " + e.Message );
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

<a name="createpurchasepayment"></a>

# **CreatePurchasePayment**

> void CreatePurchasePayment (Payment body, string companySlug, long? purchaseId)



Creates a new payment for a purchase

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePurchasePaymentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var body = new Payment(); // Payment |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |

            try
            {
                apiInstance.CreatePurchasePayment(body, companySlug, purchaseId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.CreatePurchasePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                      | Description                 | Notes
-----------------|---------------------------|-----------------------------|-------
 **body**        | [**Payment**](Payment.md) |                             |
 **companySlug** | **string**                | Slug of company to retrieve |
 **purchaseId**  | **long?**                 |                             |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepurchase"></a>

# **DeletePurchase**

> PurchaseResult DeletePurchase (string companySlug, long? purchaseId, string description)



Sets the deleted flag for a purchase. The purchase is not deleted, but a reverse transaction is created and the
\"deleted\" property is set to true.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePurchaseExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |
            var description = description_example;  // string | Required description for deleting the purchase

            try
            {
                PurchaseResult result = apiInstance.DeletePurchase(companySlug, purchaseId, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.DeletePurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                    | Notes
-----------------|------------|------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                    |
 **purchaseId**  | **long?**  |                                                |
 **description** | **string** | Required description for deleting the purchase |

### Return type

[**PurchaseResult**](PurchaseResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepurchasedraft"></a>

# **DeletePurchaseDraft**

> void DeletePurchaseDraft (string companySlug, long? draftId)



Delete draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePurchaseDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeletePurchaseDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.DeletePurchaseDraft: " + e.Message );
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

<a name="getpurchase"></a>

# **GetPurchase**

> PurchaseResult GetPurchase (string companySlug, long? purchaseId)



Returns purchase with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchaseExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |

            try
            {
                PurchaseResult result = apiInstance.GetPurchase(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                 | Notes
-----------------|------------|-----------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve |
 **purchaseId**  | **long?**  |                             |

### Return type

[**PurchaseResult**](PurchaseResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchaseattachments"></a>

# **GetPurchaseAttachments**

> List<Attachment> GetPurchaseAttachments (string companySlug, long? purchaseId)



Returns all attachments for specified purchase.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchaseAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetPurchaseAttachments(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                 | Notes
-----------------|------------|-----------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve |
 **purchaseId**  | **long?**  |                             |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchasedraft"></a>

# **GetPurchaseDraft**

> DraftResult GetPurchaseDraft (string companySlug, long? draftId)



Returns draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchaseDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                DraftResult result = apiInstance.GetPurchaseDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraft: " + e.Message );
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

[**DraftResult**](DraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchasedraftattachments"></a>

# **GetPurchaseDraftAttachments**

> List<Attachment> GetPurchaseDraftAttachments (string companySlug, long? draftId)



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
    public class GetPurchaseDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetPurchaseDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDraftAttachments: " + e.Message );
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

<a name="getpurchasedrafts"></a>

# **GetPurchaseDrafts**

> List<DraftResult> GetPurchaseDrafts (string companySlug, int? page, int? pageSize)



Returns all purchase drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchaseDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;DraftResult&gt; result = apiInstance.GetPurchaseDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchaseDrafts: " + e.Message );
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

[**List<DraftResult>**](DraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchasepayment"></a>

# **GetPurchasePayment**

> Payment GetPurchasePayment (string companySlug, long? purchaseId, long? paymentId)



Returns given payment for specified purchase

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchasePaymentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |
            var paymentId = 789;  // long? |

            try
            {
                Payment result = apiInstance.GetPurchasePayment(companySlug, purchaseId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchasePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                 | Notes
-----------------|------------|-----------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve |
 **purchaseId**  | **long?**  |                             |
 **paymentId**   | **long?**  |                             |

### Return type

[**Payment**](Payment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchasepayments"></a>

# **GetPurchasePayments**

> List<Payment> GetPurchasePayments (string companySlug, long? purchaseId)



Returns all purchases for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchasePaymentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var purchaseId = 789;  // long? |

            try
            {
                List&lt;Payment&gt; result = apiInstance.GetPurchasePayments(companySlug, purchaseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchasePayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                 | Notes
-----------------|------------|-----------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve |
 **purchaseId**  | **long?**  |                             |

### Return type

[**List<Payment>**](Payment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpurchases"></a>

# **GetPurchases**

> List<PurchaseResult> GetPurchases (string companySlug, int? page, int? pageSize, string sortBy)



Returns all purchases for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPurchasesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var sortBy = sortBy_example;  // string | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value. (optional)  (default to date asc)

            try
            {
                List&lt;PurchaseResult&gt; result = apiInstance.GetPurchases(companySlug, page, pageSize, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.GetPurchases: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                                                           | Description                      | Notes
-----------------|------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------|-------
 **companySlug** | **string**                                                                                                                                     | Slug of company to retrieve      |
 **page**        | **
 int?**          | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.              | [optional] [default to 0]
 **pageSize**    | **
 int?**          | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. | [optional] [default to 25]
 **sortBy**      | **
 string**        | Sorts results in either ascending (asc) or descending (desc) order based on the parameter value.                                               | [optional] [default to date asc]

### Return type

[**List<PurchaseResult>**](PurchaseResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepurchasedraft"></a>

# **UpdatePurchaseDraft**

> void UpdatePurchaseDraft (DraftRequest body, string companySlug, long? draftId)



Updates draft with provided id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePurchaseDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PurchasesApi();
            var body = new DraftRequest(); // DraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdatePurchaseDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchasesApi.UpdatePurchaseDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                | Description                                                                              | Notes
-----------------|-------------------------------------|------------------------------------------------------------------------------------------|-------
 **body**        | [**DraftRequest**](DraftRequest.md) |                                                                                          |
 **companySlug** | **string**                          | Slug of company to retrieve                                                              |
 **draftId**     | **long?**                           | The draftId (primary key of the returned object) is returned in the GET all drafts call. |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

