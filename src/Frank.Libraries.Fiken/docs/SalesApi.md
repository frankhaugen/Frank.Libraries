# IO.Swagger.Api.SalesApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachmentToSale**](SalesApi.md#addattachmenttosale) | **
POST** /companies/{companySlug}/sales/{saleId}/attachments |
[**AddAttachmentToSaleDraft**](SalesApi.md#addattachmenttosaledraft) | **
POST** /companies/{companySlug}/sales/drafts/{draftId}/attachments |
[**CreateSale**](SalesApi.md#createsale) | **POST** /companies/{companySlug}/sales |
[**CreateSaleDraft**](SalesApi.md#createsaledraft) | **POST** /companies/{companySlug}/sales/drafts |
[**CreateSaleFromDraft**](SalesApi.md#createsalefromdraft) | **
POST** /companies/{companySlug}/sales/drafts/{draftId}/createSale |
[**CreateSalePayment**](SalesApi.md#createsalepayment) | **POST** /companies/{companySlug}/sales/{saleId}/payments |
[**DeleteSale**](SalesApi.md#deletesale) | **PATCH** /companies/{companySlug}/sales/{saleId}/delete |
[**DeleteSaleDraft**](SalesApi.md#deletesaledraft) | **DELETE** /companies/{companySlug}/sales/drafts/{draftId} |
[**GetSale**](SalesApi.md#getsale) | **GET** /companies/{companySlug}/sales/{saleId} |
[**GetSaleAttachments**](SalesApi.md#getsaleattachments) | **GET** /companies/{companySlug}/sales/{saleId}/attachments |
[**GetSaleDraft**](SalesApi.md#getsaledraft) | **GET** /companies/{companySlug}/sales/drafts/{draftId} |
[**GetSaleDraftAttachments**](SalesApi.md#getsaledraftattachments) | **
GET** /companies/{companySlug}/sales/drafts/{draftId}/attachments |
[**GetSaleDrafts**](SalesApi.md#getsaledrafts) | **GET** /companies/{companySlug}/sales/drafts |
[**GetSalePayment**](SalesApi.md#getsalepayment) | **
GET** /companies/{companySlug}/sales/{saleId}/payments/{paymentId} |
[**GetSalePayments**](SalesApi.md#getsalepayments) | **GET** /companies/{companySlug}/sales/{saleId}/payments |
[**GetSales**](SalesApi.md#getsales) | **GET** /companies/{companySlug}/sales |
[**UpdateSaleDraft**](SalesApi.md#updatesaledraft) | **PUT** /companies/{companySlug}/sales/drafts/{draftId} |

<a name="addattachmenttosale"></a>

# **AddAttachmentToSale**

> void AddAttachmentToSale (string companySlug, long? saleId, string filename, bool? attachToPayment, bool? attachToSale, byte[] file)



Creates and adds a new attachment to a Sale

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToSaleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |
            var filename = filename_example;  // string |  (optional)
            var attachToPayment = true;  // bool? |  (optional)
            var attachToSale = true;  // bool? |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToSale(companySlug, saleId, filename, attachToPayment, attachToSale, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.AddAttachmentToSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |
**filename** | **string**|  | [optional]
**attachToPayment** | **bool?**|  | [optional]
**attachToSale** | **bool?**|  | [optional]
**file** | **byte[]****byte[]**|  | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addattachmenttosaledraft"></a>

# **AddAttachmentToSaleDraft**

> void AddAttachmentToSaleDraft (string companySlug, long? draftId, string filename, byte[] file)



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
    public class AddAttachmentToSaleDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToSaleDraft(companySlug, draftId, filename, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.AddAttachmentToSaleDraft: " + e.Message );
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
**file** | **byte[]****byte[]**|  | [optional]

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsale"></a>

# **CreateSale**

> void CreateSale (SaleRequest body, string companySlug)



Creates a new sale.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSaleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var body = new SaleRequest(); // SaleRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateSale(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**SaleRequest**](SaleRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsaledraft"></a>

# **CreateSaleDraft**

> void CreateSaleDraft (DraftRequest body, string companySlug)



Creates a sale draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSaleDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var body = new DraftRequest(); // DraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateSaleDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSaleDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**DraftRequest**](DraftRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsalefromdraft"></a>

# **CreateSaleFromDraft**

> void CreateSaleFromDraft (string companySlug, long? draftId)



Creates a sale from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSaleFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreateSaleFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSaleFromDraft: " + e.Message );
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

<a name="createsalepayment"></a>

# **CreateSalePayment**

> void CreateSalePayment (Payment body, string companySlug, long? saleId)



Creates a new payment for a given sale.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateSalePaymentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var body = new Payment(); // Payment |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |

            try
            {
                apiInstance.CreateSalePayment(body, companySlug, saleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.CreateSalePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**Payment**](Payment.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesale"></a>

# **DeleteSale**

> SaleResult DeleteSale (string companySlug, long? saleId, string description)



Sets the deleted flag for a sale. The sale is not deleted, but a reverse transaction is created and the \"deleted\"
property is set to true.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSaleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |
            var description = description_example;  // string | Required description for deleting the sale

            try
            {
                SaleResult result = apiInstance.DeleteSale(companySlug, saleId, description);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.DeleteSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |
**description** | **string**| Required description for deleting the sale |

### Return type

[**SaleResult**](SaleResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesaledraft"></a>

# **DeleteSaleDraft**

> void DeleteSaleDraft (string companySlug, long? draftId)



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
    public class DeleteSaleDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeleteSaleDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.DeleteSaleDraft: " + e.Message );
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

<a name="getsale"></a>

# **GetSale**

> SaleResult GetSale (string companySlug, long? saleId)



Returns sale with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSaleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |

            try
            {
                SaleResult result = apiInstance.GetSale(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSale: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |

### Return type

[**SaleResult**](SaleResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsaleattachments"></a>

# **GetSaleAttachments**

> List<Attachment> GetSaleAttachments (string companySlug, long? saleId)



Returns all attachments for specified sale.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSaleAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetSaleAttachments(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsaledraft"></a>

# **GetSaleDraft**

> DraftResult GetSaleDraft (string companySlug, long? draftId)



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
    public class GetSaleDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                DraftResult result = apiInstance.GetSaleDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDraft: " + e.Message );
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

[**DraftResult**](DraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsaledraftattachments"></a>

# **GetSaleDraftAttachments**

> List<Attachment> GetSaleDraftAttachments (string companySlug, long? draftId)



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
    public class GetSaleDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetSaleDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDraftAttachments: " + e.Message );
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

<a name="getsaledrafts"></a>

# **GetSaleDrafts**

> List<DraftResult> GetSaleDrafts (string companySlug, int? page, int? pageSize)



Returns all sale drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSaleDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;DraftResult&gt; result = apiInstance.GetSaleDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSaleDrafts: " + e.Message );
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

[**List<DraftResult>**](DraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsalepayment"></a>

# **GetSalePayment**

> Payment GetSalePayment (string companySlug, long? saleId, long? paymentId)



Returns payment with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSalePaymentExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |
            var paymentId = 789;  // long? |

            try
            {
                Payment result = apiInstance.GetSalePayment(companySlug, saleId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSalePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |
**paymentId** | **long?**|  |

### Return type

[**Payment**](Payment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsalepayments"></a>

# **GetSalePayments**

> List<Payment> GetSalePayments (string companySlug, long? saleId)



Returns all payments for given sale

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSalePaymentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var saleId = 789;  // long? |

            try
            {
                List&lt;Payment&gt; result = apiInstance.GetSalePayments(companySlug, saleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSalePayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**saleId** | **long?**|  |

### Return type

[**List<Payment>**](Payment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsales"></a>

# **GetSales**

> List<SaleResult> GetSales (string companySlug, int? page, int? pageSize, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, string saleNumber)



Returns all sales for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSalesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var lastModified = 2013-10-20;  // DateTime? | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLe = 2013-10-20;  // DateTime? | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGe = 2013-10-20;  // DateTime? | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var saleNumber = saleNumber_example;  // string | Find all results with the sale number equal to the specified parameter. (optional)

            try
            {
                List&lt;SaleResult&gt; result = apiInstance.GetSales(companySlug, page, pageSize, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, saleNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.GetSales: " + e.Message );
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
**lastModified** | **
DateTime?**| Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**lastModifiedLe** | **
DateTime?**| Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**lastModifiedLt** | **
DateTime?**| Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**lastModifiedGe** | **
DateTime?**| Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**lastModifiedGt** | **
DateTime?**| Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**saleNumber** | **string**| Find all results with the sale number equal to the specified parameter. | [optional]

### Return type

[**List<SaleResult>**](SaleResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesaledraft"></a>

# **UpdateSaleDraft**

> void UpdateSaleDraft (DraftRequest body, string companySlug, long? draftId)



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
    public class UpdateSaleDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SalesApi();
            var body = new DraftRequest(); // DraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdateSaleDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SalesApi.UpdateSaleDraft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**DraftRequest**](DraftRequest.md)|  |
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

