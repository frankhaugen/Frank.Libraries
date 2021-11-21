# IO.Swagger.Api.InvoicesApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachmentToInvoice**](InvoicesApi.md#addattachmenttoinvoice) | **
POST** /companies/{companySlug}/invoices/{invoiceId}/attachments |
[**AddAttachmentToInvoiceDraft**](InvoicesApi.md#addattachmenttoinvoicedraft) | **
POST** /companies/{companySlug}/invoices/drafts/{draftId}/attachments |
[**CreateInvoice**](InvoicesApi.md#createinvoice) | **POST** /companies/{companySlug}/invoices |
[**CreateInvoiceDraft**](InvoicesApi.md#createinvoicedraft) | **POST** /companies/{companySlug}/invoices/drafts |
[**CreateInvoiceFromDraft**](InvoicesApi.md#createinvoicefromdraft) | **
POST** /companies/{companySlug}/invoices/drafts/{draftId}/createInvoice |
[**DeleteInvoiceDraft**](InvoicesApi.md#deleteinvoicedraft) | **
DELETE** /companies/{companySlug}/invoices/drafts/{draftId} |
[**GetInvoice**](InvoicesApi.md#getinvoice) | **GET** /companies/{companySlug}/invoices/{invoiceId} |
[**GetInvoiceAttachments**](InvoicesApi.md#getinvoiceattachments) | **
GET** /companies/{companySlug}/invoices/{invoiceId}/attachments |
[**GetInvoiceDraft**](InvoicesApi.md#getinvoicedraft) | **GET** /companies/{companySlug}/invoices/drafts/{draftId} |
[**GetInvoiceDraftAttachments**](InvoicesApi.md#getinvoicedraftattachments) | **
GET** /companies/{companySlug}/invoices/drafts/{draftId}/attachments |
[**GetInvoiceDrafts**](InvoicesApi.md#getinvoicedrafts) | **GET** /companies/{companySlug}/invoices/drafts |
[**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /companies/{companySlug}/invoices |
[**SendInvoice**](InvoicesApi.md#sendinvoice) | **POST** /companies/{companySlug}/invoices/send |
[**UpdateInvoice**](InvoicesApi.md#updateinvoice) | **PATCH** /companies/{companySlug}/invoices/{invoiceId} |
[**UpdateInvoiceDraft**](InvoicesApi.md#updateinvoicedraft) | **
PUT** /companies/{companySlug}/invoices/drafts/{draftId} |

<a name="addattachmenttoinvoice"></a>

# **AddAttachmentToInvoice**

> void AddAttachmentToInvoice (string companySlug, long? invoiceId, string filename, byte[] file)



Creates and adds a new attachment to an Invoice

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToInvoiceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var invoiceId = 789;  // long? | The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber
            var filename = filename_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToInvoice(companySlug, invoiceId, filename, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.AddAttachmentToInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**invoiceId** | **
long?**| The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber  |
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

<a name="addattachmenttoinvoicedraft"></a>

# **AddAttachmentToInvoiceDraft**

> void AddAttachmentToInvoiceDraft (string companySlug, long? draftId, string filename, string comment, byte[] file)



Creates and adds a new attachment to an invoice draft

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToInvoiceDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var comment = comment_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToInvoiceDraft(companySlug, draftId, filename, comment, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.AddAttachmentToInvoiceDraft: " + e.Message );
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

<a name="createinvoice"></a>

# **CreateInvoice**

> void CreateInvoice (InvoiceRequest body, string companySlug)



Creates an invoice. There are two types of invoice lines that can be added to an invoice line: product line or free text
line. Provide a product Id if you are invoicing a product. All information regarding the price and VAT for this product
will be added to the invoice. It is however also possible to override the unit amount by sending information in both
fields \"productId\" and \"unitAmount\". An invoice line can also be a free text line meaning that no existing product
will be associated with the invoiced line. In this case all information regarding the price and VAT of the product or
service to be invoiced must be provided.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInvoiceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var body = new InvoiceRequest(); // InvoiceRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateInvoice(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**InvoiceRequest**](InvoiceRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createinvoicedraft"></a>

# **CreateInvoiceDraft**

> void CreateInvoiceDraft (InvoiceishDraftRequest body, string companySlug)



Creates an invoice draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInvoiceDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateInvoiceDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoiceDraft: " + e.Message );
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

<a name="createinvoicefromdraft"></a>

# **CreateInvoiceFromDraft**

> void CreateInvoiceFromDraft (string companySlug, long? draftId)



Creates an invoice from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateInvoiceFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreateInvoiceFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.CreateInvoiceFromDraft: " + e.Message );
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

<a name="deleteinvoicedraft"></a>

# **DeleteInvoiceDraft**

> void DeleteInvoiceDraft (string companySlug, long? draftId)



Delete invoice draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteInvoiceDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeleteInvoiceDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.DeleteInvoiceDraft: " + e.Message );
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

<a name="getinvoice"></a>

# **GetInvoice**

> InvoiceResult GetInvoice (string companySlug, long? invoiceId)



Returns invoice with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var invoiceId = 789;  // long? | The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber

            try
            {
                InvoiceResult result = apiInstance.GetInvoice(companySlug, invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**invoiceId** | **
long?**| The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber  |

### Return type

[**InvoiceResult**](InvoiceResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoiceattachments"></a>

# **GetInvoiceAttachments**

> List<Attachment> GetInvoiceAttachments (string companySlug, long? invoiceId)



Returns all attachments for a given Invoice

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var invoiceId = 789;  // long? | The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetInvoiceAttachments(companySlug, invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**invoiceId** | **
long?**| The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber  |

### Return type

[**List<Attachment>**](Attachment.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoicedraft"></a>

# **GetInvoiceDraft**

> InvoiceishDraftResult GetInvoiceDraft (string companySlug, long? draftId)



Returns invoice draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                InvoiceishDraftResult result = apiInstance.GetInvoiceDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceDraft: " + e.Message );
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

<a name="getinvoicedraftattachments"></a>

# **GetInvoiceDraftAttachments**

> List<Attachment> GetInvoiceDraftAttachments (string companySlug, long? draftId)



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
    public class GetInvoiceDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetInvoiceDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceDraftAttachments: " + e.Message );
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

<a name="getinvoicedrafts"></a>

# **GetInvoiceDrafts**

> List<InvoiceishDraftResult> GetInvoiceDrafts (string companySlug, int? page, int? pageSize, string orderReference)



Returns all invoice drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoiceDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var orderReference = orderReference_example;  // string | Filter based on order reference for a given invoice (optional)

            try
            {
                List&lt;InvoiceishDraftResult&gt; result = apiInstance.GetInvoiceDrafts(companySlug, page, pageSize, orderReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoiceDrafts: " + e.Message );
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
**orderReference** | **string**| Filter based on order reference for a given invoice | [optional]

### Return type

[**List<InvoiceishDraftResult>**](InvoiceishDraftResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>

# **GetInvoices**

> List<InvoiceResult> GetInvoices (string companySlug, int? page, int? pageSize, DateTime? issueDate, DateTime? issueDateLe, DateTime? issueDateLt, DateTime? issueDateGe, DateTime? issueDateGt, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, long? customerId, bool? settled, string orderReference, Guid? invoiceDraftUuid)



Returns all invoices for given company. You can filter based on issue date, last modified date, customer ID, and if the
invoice is settled or not.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var issueDate = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateLe = 2013-10-20;  // DateTime? | Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateLt = 2013-10-20;  // DateTime? | Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateGe = 2013-10-20;  // DateTime? | Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var issueDateGt = 2013-10-20;  // DateTime? | Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModified = 2013-10-20;  // DateTime? | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLe = 2013-10-20;  // DateTime? | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGe = 2013-10-20;  // DateTime? | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var customerId = 789;  // long? | Returns only invoices sent to specified customer. Must be the contactId provided by a GET contacts call.  (optional)
            var settled = true;  // bool? | When set to true, returns only invoices that have been settled. Otherwise false returns all invoices that have not been fully settled.  (optional)
            var orderReference = orderReference_example;  // string | Filter based on order reference for a given invoice (optional)
            var invoiceDraftUuid = new Guid?(); // Guid? | Filter based on the UUID of the invoice draft that was used to create a given invoice (optional)

            try
            {
                List&lt;InvoiceResult&gt; result = apiInstance.GetInvoices(companySlug, page, pageSize, issueDate, issueDateLe, issueDateLt, issueDateGe, issueDateGt, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, customerId, settled, orderReference, invoiceDraftUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message );
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
**customerId** | **
long?**| Returns only invoices sent to specified customer. Must be the contactId provided by a GET contacts call.  | [optional]
**settled** | **
bool?**| When set to true, returns only invoices that have been settled. Otherwise false returns all invoices that have not been fully settled.  | [optional]
**orderReference** | **string**| Filter based on order reference for a given invoice | [optional]
**invoiceDraftUuid** | [**
Guid?**](.md)| Filter based on the UUID of the invoice draft that was used to create a given invoice | [optional]

### Return type

[**List<InvoiceResult>**](InvoiceResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvoice"></a>

# **SendInvoice**

> void SendInvoice (SendInvoiceRequest body, string companySlug)



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
    public class SendInvoiceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var body = new SendInvoiceRequest(); // SendInvoiceRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.SendInvoice(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.SendInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**SendInvoiceRequest**](SendInvoiceRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoice"></a>

# **UpdateInvoice**

> void UpdateInvoice (UpdateInvoiceRequest body, string companySlug, long? invoiceId)



Updates invoice with provided id. It is possible to update the due date of an invoice as well as if the invoice was sent
manually, outside of Fiken.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateInvoiceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var body = new UpdateInvoiceRequest(); // UpdateInvoiceRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var invoiceId = 789;  // long? | The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber

            try
            {
                apiInstance.UpdateInvoice(body, companySlug, invoiceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**UpdateInvoiceRequest**](UpdateInvoiceRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**invoiceId** | **
long?**| The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvoicedraft"></a>

# **UpdateInvoiceDraft**

> void UpdateInvoiceDraft (InvoiceishDraftRequest body, string companySlug, long? draftId)



Updates invoice draft with provided id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateInvoiceDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdateInvoiceDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.UpdateInvoiceDraft: " + e.Message );
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

