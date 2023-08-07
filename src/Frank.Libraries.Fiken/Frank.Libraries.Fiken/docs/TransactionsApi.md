# IO.Swagger.Api.TransactionsApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                      | HTTP request | Description
-------------------------------------------------------------|--------------|-------------
 [**GetTransaction**](TransactionsApi.md#gettransaction)     | **
 GET** /companies/{companySlug}/transactions/{transactionId} |

<a name="gettransaction"></a>

# **GetTransaction**

> Transaction GetTransaction (string companySlug, long? transactionId)



Returns given transaction with associated id. Transaction id is returned in GET calls for sales, purchases, and journal
entries.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var transactionId = 789;  // long? |

            try
            {
                Transaction result = apiInstance.GetTransaction(companySlug, transactionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name              | Type       | Description                 | Notes
-------------------|------------|-----------------------------|-------
 **companySlug**   | **string** | Slug of company to retrieve |
 **transactionId** | **long?**  |                             |

### Return type

[**Transaction**](Transaction.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

