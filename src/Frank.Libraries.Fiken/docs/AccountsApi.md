# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://api.fiken.no/api/v2*

 Method                                                       | HTTP request                                            | Description
--------------------------------------------------------------|---------------------------------------------------------|-------------
 [**GetAccount**](AccountsApi.md#getaccount)                  | **GET** /companies/{companySlug}/accounts/{accountCode} |
 [**GetAccountBalance**](AccountsApi.md#getaccountbalance)    | **
 GET** /companies/{companySlug}/accountBalances/{accountCode} |
 [**GetAccountBalances**](AccountsApi.md#getaccountbalances)  | **GET** /companies/{companySlug}/accountBalances        |
 [**GetAccounts**](AccountsApi.md#getaccounts)                | **GET** /companies/{companySlug}/accounts               |

<a name="getaccount"></a>

# **GetAccount**

> Account GetAccount (string companySlug, string accountCode)



Retrieves the specified bookkeping account. An account is a string with either four digits, or four digits, a colon and
five digits (\"reskontro\"). Examples:       3020 and 1500:10001

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var accountCode = accountCode_example;  // string | Code number of the bookkeeping account to retrieve for the current year.

            try
            {
                Account result = apiInstance.GetAccount(companySlug, accountCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type       | Description                                                              | Notes
-----------------|------------|--------------------------------------------------------------------------|-------
 **companySlug** | **string** | Slug of company to retrieve                                              |
 **accountCode** | **string** | Code number of the bookkeeping account to retrieve for the current year. |

### Return type

[**Account**](Account.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountbalance"></a>

# **GetAccountBalance**

> AccountBalance GetAccountBalance (string companySlug, string accountCode, DateTime? date)



Retrieves the specified bookkeping account and balance for a given date.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountBalanceExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var accountCode = accountCode_example;  // string | Code number of the bookkeeping account to retrieve
            var date = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"

            try
            {
                AccountBalance result = apiInstance.GetAccountBalance(companySlug, accountCode, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                           | Description                                        | Notes
-----------------|----------------------------------------------------------------------------------------------------------------|----------------------------------------------------|-------
 **companySlug** | **string**                                                                                                     | Slug of company to retrieve                        |
 **accountCode** | **string**                                                                                                     | Code number of the bookkeeping account to retrieve |
 **date**        | **
 DateTime?**     | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; |

### Return type

[**AccountBalance**](AccountBalance.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountbalances"></a>

# **GetAccountBalances**

> List<AccountBalance> GetAccountBalances (string companySlug, DateTime? date, long? fromAccount, long? toAccount, int?
> page, int? pageSize)



Retrieves the bookkeeping accounts and balances for a given date. An account is a string with either four digits, or
four digits, a colon and five digits (\"reskontro\"). Examples: 3020 and 1500:10001

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountBalancesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var date = 2013-10-20;  // DateTime? | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"
            var fromAccount = 789;  // long? | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional)
            var toAccount = 789;  // long? | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional)
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;AccountBalance&gt; result = apiInstance.GetAccountBalances(companySlug, date, fromAccount, toAccount, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                                                           | Description                 | Notes
-----------------|------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug** | **string**                                                                                                                                     | Slug of company to retrieve |
 **date**        | **
 DateTime?**     | Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;                                 |
 **fromAccount** | **
 long?**         | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).                  | [optional]
 **toAccount**   | **
 long?**         | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).                  | [optional]
 **page**        | **
 int?**          | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.              | [optional] [default to 0]
 **pageSize**    | **
 int?**          | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. | [optional] [default to 25]

### Return type

[**List<AccountBalance>**](AccountBalance.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccounts"></a>

# **GetAccounts**

> List<Account> GetAccounts (string companySlug, long? fromAccount, long? toAccount, int? page, int? pageSize)



Retrieves the bookkeeping accounts for the current year

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var fromAccount = 789;  // long? | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional)
            var toAccount = 789;  // long? | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount). (optional)
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)

            try
            {
                List&lt;Account&gt; result = apiInstance.GetAccounts(companySlug, fromAccount, toAccount, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

 Name            | Type                                                                                                                                           | Description                 | Notes
-----------------|------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------|-------
 **companySlug** | **string**                                                                                                                                     | Slug of company to retrieve |
 **fromAccount** | **
 long?**         | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).                  | [optional]
 **toAccount**   | **
 long?**         | Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).                  | [optional]
 **page**        | **
 int?**          | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.              | [optional] [default to 0]
 **pageSize**    | **
 int?**          | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. | [optional] [default to 25]

### Return type

[**List<Account>**](Account.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

