# IO.Swagger.Api.BankAccountsApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                        | HTTP request                                   | Description
---------------------------------------------------------------|------------------------------------------------|-------------
 [**CreateBankAccount**](BankAccountsApi.md#createbankaccount) | **POST** /companies/{companySlug}/bankAccounts |
 [**GetBankAccount**](BankAccountsApi.md#getbankaccount)       | **
 GET** /companies/{companySlug}/bankAccounts/{bankAccountId}   |
 [**GetBankAccounts**](BankAccountsApi.md#getbankaccounts)     | **GET** /companies/{companySlug}/bankAccounts  |

<a name="createbankaccount"></a>

# **CreateBankAccount**

> void CreateBankAccount (BankAccountRequest body, string companySlug)



Creates a new bank account. The Location response header returns the URL of the newly created bank account. Possible
types of bank accounts are NORMAL, TAX_DEDUCTION, FOREIGN, and CREDIT_CARD. The field \"foreignService\" should only be
filled out for accounts of type FOREIGN.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBankAccountExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountsApi();
            var body = new BankAccountRequest(); // BankAccountRequest |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateBankAccount(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountsApi.CreateBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                            | Description                 | Notes
-----------------|-------------------------------------------------|-----------------------------|-------
 **body**        | [**BankAccountRequest**](BankAccountRequest.md) |                             |
 **companySlug** | **string**                                      | Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccount"></a>

# **GetBankAccount**

> BankAccountResult GetBankAccount (string companySlug, long? bankAccountId)



Retrieves specified bank account.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBankAccountExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var bankAccountId = 789;  // long? |

            try
            {
                BankAccountResult result = apiInstance.GetBankAccount(companySlug, bankAccountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountsApi.GetBankAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name              | Type       | Description                 | Notes
-------------------|------------|-----------------------------|-------
 **companySlug**   | **string** | Slug of company to retrieve |
 **bankAccountId** | **long?**  |                             |

### Return type

[**BankAccountResult**](BankAccountResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbankaccounts"></a>

# **GetBankAccounts**

> List<BankAccountResult> GetBankAccounts (string companySlug, int? page, int? pageSize)



Retrieves all bank accounts associated with the company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBankAccountsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BankAccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;BankAccountResult&gt; result = apiInstance.GetBankAccounts(companySlug, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BankAccountsApi.GetBankAccounts: " + e.Message );
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

[**List<BankAccountResult>**](BankAccountResult.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

