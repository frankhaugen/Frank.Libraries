# IO.Swagger.Api.ProductsApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProduct**](ProductsApi.md#createproduct) | **POST** /companies/{companySlug}/products |
[**CreateProductSalesReport**](ProductsApi.md#createproductsalesreport) | **
POST** /companies/{companySlug}/products/salesReport |
[**DeleteProduct**](ProductsApi.md#deleteproduct) | **DELETE** /companies/{companySlug}/products/{productId} |
[**GetProduct**](ProductsApi.md#getproduct) | **GET** /companies/{companySlug}/products/{productId} |
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /companies/{companySlug}/products |
[**UpdateProduct**](ProductsApi.md#updateproduct) | **PUT** /companies/{companySlug}/products/{productId} |

<a name="createproduct"></a>

# **CreateProduct**

> void CreateProduct (Product body, string companySlug)



Creates a new product.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProductExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var body = new Product(); // Product |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateProduct(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**Product**](Product.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproductsalesreport"></a>

# **CreateProductSalesReport**

> List<ProductSalesReportResult> CreateProductSalesReport (ProductSalesReportRequest body, string companySlug)



Creates a report based on provided specifications.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProductSalesReportExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var body = new ProductSalesReportRequest(); // ProductSalesReportRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                List&lt;ProductSalesReportResult&gt; result = apiInstance.CreateProductSalesReport(body, companySlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProductSalesReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**ProductSalesReportRequest**](ProductSalesReportRequest.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

[**List<ProductSalesReportResult>**](ProductSalesReportResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproduct"></a>

# **DeleteProduct**

> void DeleteProduct (string companySlug, long? productId)



Delete product with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var productId = 789;  // long? | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.

            try
            {
                apiInstance.DeleteProduct(companySlug, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**productId** | **
long?**| The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproduct"></a>

# **GetProduct**

> Product GetProduct (string companySlug, long? productId)



Returns product with specified id.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var productId = 789;  // long? | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.

            try
            {
                Product result = apiInstance.GetProduct(companySlug, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**productId** | **
long?**| The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |

### Return type

[**Product**](Product.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproducts"></a>

# **GetProducts**

> List<Product> GetProducts (string companySlug, int? page, int? pageSize, DateTime? createdDate, DateTime? lastModified, string name, string productNumber, bool? active)



Returns all products for given company

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var createdDate = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModified = 2013-10-20;  // DateTime? | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var name = name_example;  // string | Find all results with product name equal to the specified parameter. (optional)
            var productNumber = productNumber_example;  // string | Find all results with product number (varenummer) equal to the specified parameter. (optional)
            var active = true;  // bool? | Returns active (true) or inactive (false) products. (optional)

            try
            {
                List&lt;Product&gt; result = apiInstance.GetProducts(companySlug, page, pageSize, createdDate, lastModified, name, productNumber, active);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message );
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
**createdDate** | **
DateTime?**| Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**lastModified** | **
DateTime?**| Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;  | [optional]
**name** | **string**| Find all results with product name equal to the specified parameter. | [optional]
**productNumber** | **
string**| Find all results with product number (varenummer) equal to the specified parameter. | [optional]
**active** | **bool?**| Returns active (true) or inactive (false) products. | [optional]

### Return type

[**List<Product>**](Product.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproduct"></a>

# **UpdateProduct**

> void UpdateProduct (Product body, string companySlug, long? productId)



Updates an existing product.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductsApi();
            var body = new Product(); // Product |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var productId = 789;  // long? | The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.

            try
            {
                apiInstance.UpdateProduct(body, companySlug, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**Product**](Product.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**productId** | **
long?**| The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber.  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

