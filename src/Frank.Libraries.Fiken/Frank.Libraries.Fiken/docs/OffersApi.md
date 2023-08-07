# IO.Swagger.Api.OffersApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                                  | HTTP request                                                | Description
-------------------------------------------------------------------------|-------------------------------------------------------------|-------------
 [**AddAttachmentToOfferDraft**](OffersApi.md#addattachmenttoofferdraft) | **
 POST** /companies/{companySlug}/offers/drafts/{draftId}/attachments     |
 [**CreateOfferDraft**](OffersApi.md#createofferdraft)                   | **POST** /companies/{companySlug}/offers/drafts             |
 [**CreateOfferFromDraft**](OffersApi.md#createofferfromdraft)           | **
 POST** /companies/{companySlug}/offers/drafts/{draftId}/createOffer     |
 [**DeleteOfferDraft**](OffersApi.md#deleteofferdraft)                   | **DELETE** /companies/{companySlug}/offers/drafts/{draftId} |
 [**GetOffer**](OffersApi.md#getoffer)                                   | **GET** /companies/{companySlug}/offers/{offerId}           |
 [**GetOfferDraft**](OffersApi.md#getofferdraft)                         | **GET** /companies/{companySlug}/offers/drafts/{draftId}    |
 [**GetOfferDraftAttachments**](OffersApi.md#getofferdraftattachments)   | **
 GET** /companies/{companySlug}/offers/drafts/{draftId}/attachments      |
 [**GetOfferDrafts**](OffersApi.md#getofferdrafts)                       | **GET** /companies/{companySlug}/offers/drafts              |
 [**GetOffers**](OffersApi.md#getoffers)                                 | **GET** /companies/{companySlug}/offers                     |
 [**UpdateOfferDraft**](OffersApi.md#updateofferdraft)                   | **PUT** /companies/{companySlug}/offers/drafts/{draftId}    |

<a name="addattachmenttoofferdraft"></a>

# **AddAttachmentToOfferDraft**

> void AddAttachmentToOfferDraft (string companySlug, long? draftId, string filename, string comment, byte[] file)



Creates and adds a new attachment to an offer draft

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToOfferDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.
            var filename = filename_example;  // string |  (optional)
            var comment = comment_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToOfferDraft(companySlug, draftId, filename, comment, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.AddAttachmentToOfferDraft: " + e.Message );
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

<a name="createofferdraft"></a>

# **CreateOfferDraft**

> void CreateOfferDraft (InvoiceishDraftRequest body, string companySlug)



Creates an offer draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOfferDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateOfferDraft(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferDraft: " + e.Message );
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

<a name="createofferfromdraft"></a>

# **CreateOfferFromDraft**

> void CreateOfferFromDraft (string companySlug, long? draftId)



Creates an offer from an already created draft.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOfferFromDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.CreateOfferFromDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.CreateOfferFromDraft: " + e.Message );
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

<a name="deleteofferdraft"></a>

# **DeleteOfferDraft**

> void DeleteOfferDraft (string companySlug, long? draftId)



Delete offer draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOfferDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.DeleteOfferDraft(companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.DeleteOfferDraft: " + e.Message );
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

<a name="getoffer"></a>

# **GetOffer**

> Offer GetOffer (string companySlug, string offerId)



Returns offer with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfferExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var offerId = offerId_example;  // string | The offerId (primary key of the returned object) is returned as the first field in the GET all offers call

            try
            {
                Offer result = apiInstance.GetOffer(companySlug, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                       | Description                 | Notes
-----------------|------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug** | **string**                                                                                                 | Slug of company to retrieve |
 **offerId**     | **
 string**        | The offerId (primary key of the returned object) is returned as the first field in the GET all offers call |

### Return type

[**Offer**](Offer.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getofferdraft"></a>

# **GetOfferDraft**

> InvoiceishDraftResult GetOfferDraft (string companySlug, long? draftId)



Returns offer draft with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfferDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                InvoiceishDraftResult result = apiInstance.GetOfferDraft(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDraft: " + e.Message );
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

<a name="getofferdraftattachments"></a>

# **GetOfferDraftAttachments**

> List<Attachment> GetOfferDraftAttachments (string companySlug, long? draftId)



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
    public class GetOfferDraftAttachmentsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                List&lt;Attachment&gt; result = apiInstance.GetOfferDraftAttachments(companySlug, draftId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDraftAttachments: " + e.Message );
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

<a name="getofferdrafts"></a>

# **GetOfferDrafts**

> List<InvoiceishDraftResult> GetOfferDrafts (string companySlug, int? page, int? pageSize)



Returns all offer drafts for given company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfferDraftsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;InvoiceishDraftResult&gt; result = apiInstance.GetOfferDrafts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOfferDrafts: " + e.Message );
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

<a name="getoffers"></a>

# **GetOffers**

> List<Offer> GetOffers (string companySlug, int? page, int? pageSize)



Returns all offers for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOffersExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;Offer&gt; result = apiInstance.GetOffers(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.GetOffers: " + e.Message );
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

[**List<Offer>**](Offer.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateofferdraft"></a>

# **UpdateOfferDraft**

> void UpdateOfferDraft (InvoiceishDraftRequest body, string companySlug, long? draftId)



Updates offer draft with provided id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateOfferDraftExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OffersApi();
            var body = new InvoiceishDraftRequest(); // InvoiceishDraftRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var draftId = 789;  // long? | The draftId (primary key of the returned object) is returned in the GET all drafts call.

            try
            {
                apiInstance.UpdateOfferDraft(body, companySlug, draftId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OffersApi.UpdateOfferDraft: " + e.Message );
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

