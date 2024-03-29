# IO.Swagger - the C# library for the Fiken API

## Introduction

[Fiken.no](https://fiken.no) is an online accounting system aimed at making accounting easy for small businesses. The
API Module allows other systems to integrate with Fiken. This document describes Fiken's API. Using the API Use of this
API in production environments on live data is normally associated with a fee for the end user (company). API access
costs 99kr per month and can be ordered through the Module access page under Settings in your Fiken account. If you have
any questions regarding the API pricing, contact us at <api@fiken.no>. The API provides two different ways of
authorizing requests.

1. OAuth2
2. Personal API tokens Third parties that wish to integrate with Fiken on behalf of their customers should use the
   OAuth2 authorization method. In order to develop OAuth2 applications that integrate with this API you must log into
   your Fiken account and check the box saying that you are a developer (Rediger konto → Profil → Andre innstillinger).
   This will allow you to create an App by clicking on the \"API\" tab under Brukerinnstillinger. Upon creation of the
   new App you will be provided a Client ID and Client Secret that are needed for the OAuth2 authorization flow. This
   will allow you to use the API during development with up to 5 users. If you would like to use the API with more than
   5 users and gain production status, you will need to send an email to <api@fiken.no> to gain full access to the API
   module. Fiken customers that wish to integrate their own solutions with this API can use personal API tokens.
   Personal API tokens can be created in Rediger konto -> API -> Personlige API-nøkler. Note that personal API tokens do
   not expire.

Base URL All URLs start with https://api.fiken.no/api/v2. Note that TLS is required, unencrypted HTTP is not supported.
Although we currently redirect HTTP requests to HTTPS, you are not allowed to this with your application as using HTTP
is a security risk. In the future we might respond with 403 Forbidden instead. ## Concurrent requests / rate limiting
You are only allowed to make a single concurrent API-request. This is currently not automatically enforced, but it might
be in the future. If you break this rule you might be banned. In case of a ban please contact us to be unbanned. API
calls may be slowed if you execute more than 4 requests per second. ## Personal API tokens Personal API tokens can be
created in Rediger konto -> API. Personal API tokens never expire and can be revoked from the same place. To use a
personal API token simply send it as a bearer token in the `Authorization` header:
GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <api token>  ## Authorization with OAuth2 Fiken API
V2 uses OAuth 2.0 for authorizing API requests. Authorized requests to the API should use an `Authorization` header with
the value `Bearer <TOKEN>` where `<TOKEN>` is an access token obtained through the OAuth flow. ### Authorize Endpoint To
start the OAuth flow in order to obtain an access token for a user, you will first have to get consent from the user. To
do this, direct your user to the authorization endpoint:
GET https://fiken.no/oauth/authorize?response_type=code&client_id=CLIENT_ID&redirect_uri=REDIRECT_URI&state=STATE  If
the user is logged in and accepts your request, the user is redirected back to your redirect url. If the user is not
logged in, the regular Fiken.no login form is presented first, requiring the user to authenticate before accepting or
rejecting your request. If the user rejects the request or if there is an error in your request, the user is redirected
back to your redirect url with the parameters `error` and `error_description`. If the user rejected the request the
error code will be `access_denied`.

## Parameters

| Name                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | response_type |
|----------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------|
| Required** Should always be the value `code`                                                                   |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | client_id     |
| Required** The client id you received from Fiken when you registered your application                          |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | redirect_uri  |
| Required** The URL in your application where users will be sent with an authorization code after authorization |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | state         |
| Required** An unguessable random string, used to protect against CSRF attacks                                  | Token Endpoint  If the user accepts your request, Fiken redirects the user back to your `redirect_uri` with a parameter named `code` as well as the state you provided in the previous step in the `state` parameter. This temporary code will expire after a short while. The temporary authorization code can be exchanged for an access token at the token endpoint. The token endpoint is protected with Http Basic Authentication and you should use your application client id and client secret as credentials to authenticate. POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=authorization_code&code=AUTHCODE&redirect_uri=REDIRECT_URI&state=STATE  The response will contain the access token, a refresh token (see below) as well as information about the expiry time for the token. { \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\", \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\", \"token_type\": \"bearer\", \"expires_in\": 86157 } If an error occurs during the token exchange request, an error object is returned with an error and an error description. { \"error\": \"invalid_grant\", \"error_description\": \"The authorization code is invalid or expired.\" } #### Parameters | Name          |
| Required** Should be the value `authorization_code`                                                            |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | code          |
| Required** The authorization code that was received in the redirect from the authorize endpoint                |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | redirect_uri  |
| Required** The URL in your application where users will be sent with an authorization code after authorization |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | state         |
| Required** An unguessable random string, used to protect against CSRF attacks                                  | Refresh Tokens  If an access token has expired you can use the refresh token that was sent in the response from the token endpoint to get a new access token. Note that if the user has revoked the consent to your app, the refresh token will no longer be valid. To get a new access token from the refresh token, use the token endpoint with the grant type `refresh_token`:      POST https://fiken.no/oauth/token     Content-Type: application/x-www-form-urlencoded     Authorization: Basic dXNlIHlvdXIgY2xpZW50IGlkOmFuZCBjbGllbnQgc2VjcmV0      grant_type=refresh_token&refresh_token=REFRESH_TOKEN  The response contains a fresh access token along with a possibly updated refresh token:      { \"access_token\": \"K2QwoFp4ZfugWLWk7Ipu9kni5cyv3luXKQ-GDShvV2g=\", \"refresh_token\": \"naFOD_j8m6PFGcP0pfImVZlSxKklHLbgj9Hzao4rhg8=\", \"token_type\": \"bearer\", \"expires_in\": 86157 } #### Parameters                                                                                                                                                                                                                                                                                                                                                                                                                                                          | Name          |
| Required** Should be the value `refresh_token`                                                                 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | refresh_token |
| Required** The refresh token last returned for this user from the token endpoint                               | Using Access Tokens in API Requests  To execute API requests on behalf of the end user, send the access token obtained at the token endpoint as a bearer token, as in this example:      GET https://api.fiken.no/api/v2/companies     Authorization: Bearer <access_token_value>  ### Revoking tokens  To revoke an access token and refresh token use the Revoke Token endpoint. The Revoke Token endpoint disables the application grant, the access token and the corresponding refresh token used to authenticate the call. Other access tokens obtained from the same refresh token are also revoked. POST https://fiken.no/oauth/revoke     Authorization: Bearer <access_token_value>  The response for a successful revocation is 200/OK. ## Try It Out  For each endpoint in the documentation below there is a button *                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |               |

Try It Out*. To invoke the API from this documentation you need an app and you need to authorize usage for you Fiken.no
user. Your app needs to be configured with a redirect URL for this documentation,
add `https://api.fiken.no/api/v2/docs/oauth2-redirect.html` to the list of redirect URLs for your app. Click the padlock
symbol on any of the endpoints and enter your `client_id` and `client_secret` and then press *
Authorize* to start the OAuth2 authorization flow, then click *
Close*. Enter the required parameters for the endpoint, such as `company_slug`, and then press *
Execute* to test. ## Request We recommend sending the `Fiken-Request-Id` header with all requests.

### Request Headers

| Request  Header    | Format | Description                       |
|--------------------|--------|-----------------------------------|
| `Fiken-Request-Id` | UUID   | UUID used to identify the request |

Response code All HTTP codes should be expected with their normal semantics. These are some of the common ones:

200** for successful GET * **201** for successful POST where you get a Location-header for the created content * **
400** when invalid content has be sent (for instance a required field is missing, unexpected fields, wrong format, etc)
* **
401** when the user is not authenticated * **403** when the user does not have the proper authorization * **
404** when the requested content is not found * **
405** When you are trying a method to a resource which doesn't support it (i.e. DELETE on an account). * **
415** Wrong media type. we accept application/json only. ### Response Content The default content type on the result of
GET requests is application/json. On successful POSTs/PUTs/PATCHs and DELETEs an empty body is returned. For successful
POSTs/PUTs/PATCHs a Location header is given in all cases. ## Pagination, Sorting & Filtering Pagination, sorting and
filtering query parameters are all optional. | URI | Pagination? | Sortable? | Sortable Fields | Filterable? | Filtered
Fields | | :- -- -- -- -- |:- -- -- -- -- -- | :- -- -- -- - | :- -- -- -- -- -- -- | :- -- | :- -- |
| https://api.fiken.no/api/v2/companies                                  | Yes | Yes | createdDate, name,
organizationNumber | No | | | https://api.fiken.no/api/v2/companies/{companySlug}/accounts           | No | No | | Yes |
fromAccount, toAccount | | https://api.fiken.no/api/v2/companies/{companySlug}/accountBalances    | Yes | No | | Yes |
fromAccount, toAccount | | https://api.fiken.no/api/v2/companies/{companySlug}/bankAccounts       | Yes | No | | No | |
| https://api.fiken.no/api/v2/companies/{companySlug}/contacts           | Yes | Yes | createdDate, lastModified | Yes |
supplierNumber, customerNumber, memberNumber, name, organizationNumber, email, group, lastModified|
| https://api.fiken.no/api/v2/companies/{companySlug}/creditNotes        | Yes | No | | Yes | issueDate, settled,
customerId | | https://api.fiken.no/api/v2/companies/{companySlug}/inbox              | Yes | Yes | createdDate, name |
Yes | status, name | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices           | Yes | No | | Yes |
issueDate, lastModified, settled, customerId | | https://api.fiken.no/api/v2/companies/{companySlug}/invoices/drafts
| Yes | No | | No | | | https://api.fiken.no/api/v2/companies/{companySlug}/journalEntries     | Yes | No | | Yes | date
| | https://api.fiken.no/api/v2/companies/{companySlug}/offers             | Yes | No | | No | |
| https://api.fiken.no/api/v2/companies/{companySlug}/orderConfirmations | Yes | No | | No | |
| https://api.fiken.no/api/v2/companies/{companySlug}/products           | Yes | No | | Yes | name, productNumber,
active, createdDate, lastModified | | https://api.fiken.no/api/v2/companies/{companySlug}/projects           | Yes | No
| | Yes | completed | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases          | Yes | Yes | createdDate
| No | | | https://api.fiken.no/api/v2/companies/{companySlug}/purchases/drafts   | Yes | No | | No | |
| https://api.fiken.no/api/v2/companies/{companySlug}/sales              | Yes | No | | Yes | saleNumber, lastModified |
| https://api.fiken.no/api/v2/companies/{companySlug}/sales/drafts       | Yes | No | | No | |
| https://api.fiken.no/api/v2/companies/{companySlug}/transactions       | No | No | | No | | ### Pagination By default
the API sets `page=0` and `pageSize=25` and returns the first 25 elements in a collection resource, if nothing else is
specified. PageSize has a maximum value of 100 meaning that you can only access at most 100 elements at once. To request
a collection resource with pagination, query the resource with the query filters page and pageSize, note that both query
parameters need to be set to enable pagination. The page counter starts at 0. The response will contain up to
Fiken-Api-Page-Size elements and the response headers below, detailing how many elements the resource has in total and
the total number of pages as well. By default the API returns the resources in the order they were created, if nothing
else is specified in the documentation. #### Pagination Response Headers | Response Header | Format | Description | | -
-- -- -- -- -- -- -- - | - -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | `Fiken-Api-Page`          |
integer | From the request header | | `Fiken-Api-Page-Size`     | integer | From the request header |
| `Fiken-Api-Page-Count`    | integer | The total number of pages in this resource with this page size |
| `Fiken-Api-Result-Count`  | integer | The total number of elements in this resource | ### Sorting To change the sort
order for a resource, set the sortBy query parameter to a sort field in either ascending or descending order.
Ex: `https://api.fiken.no/api/v2/companies?sortBy=name%20asc`  ### Filtering Some collections support filtering, and
depending on the type of field, different filters can be used. Dates are the most complex, and allow you do apply
different filters with different parameter names. For instance, for a field called date, the following mutations are
available:  | Parameter | Field | Format | Description | | - -- |- -- | - -- |- -- | |  `date`   |date |yyyy-MM-dd |date
equal to parameter value | |  `dateLe`  |date |yyyy-MM-dd |date less than or equal to parameter value | |  `dateLt`
|date |yyyy-MM-dd |date less than parameter value | |  `dateGe`  |date |yyyy-MM-dd |date greater than or equal to
parameter value | |  `dateGt`  |date |yyyy-MM-dd |date greater than parameter value | All date-fields will have these
mutations of parameter name that applies ## Data Types These are simple data-types that are used in several of our
objects. ### Date Dates are represented as strings formatted as yyyy-MM-dd. ##### Examples: January 2nd, 1970:
\"1970-01-02\" ### Amount Amounts are always represented as a number, and specifies the number of cents in the amount.
Fractions will be ignored. ##### Examples: One thousand: 100000 One hundred and twelve cents: 10012 ### Account An
account is a string with either four digits, or four digits, a colon and five digits (\"reskontro\"). ##### Examples:
3020 1500:10001 ### VatCode Fiken's VAT codes are based upon Sticos mvakoder. To see all VAT codes go to Fiken support,
check the \"Mva kode\"-selector in the Fiken web interface while creating a genereal ledger item (\"Fri postering\").

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET 2.0

<a name="dependencies"></a>

## Dependencies

- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are
bundled with this generator

<a name="installation"></a>

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="getting-started"></a>

## Getting Started

```c#
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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
                List<AccountBalance> result = apiInstance.GetAccountBalances(companySlug, date, fromAccount, toAccount, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountBalances: " + e.Message );
            }

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
                List<Account> result = apiInstance.GetAccounts(companySlug, fromAccount, toAccount, page, pageSize);
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

<a name="documentation-for-api-endpoints"></a>

## Documentation for API Endpoints

All URIs are relative to *https://api.fiken.no/api/v2*

| Class                                                                                                           | Method | HTTP request | Description |
|-----------------------------------------------------------------------------------------------------------------|--------|--------------|-------------|
| *AccountsApi*                                                                                                   | [**
 GetAccount**](docs/AccountsApi.md#getaccount)                                                                   | **     |              |
| GET** /companies/{companySlug}/accounts/{accountCode}                                                           |        |              |             |
| *AccountsApi*                                                                                                   | [**
 GetAccountBalance**](docs/AccountsApi.md#getaccountbalance)                                                     | **     |              |
| GET** /companies/{companySlug}/accountBalances/{accountCode}                                                    |        |              |             |
| *AccountsApi*                                                                                                   | [**
 GetAccountBalances**](docs/AccountsApi.md#getaccountbalances)                                                   | **     |              |
| GET** /companies/{companySlug}/accountBalances                                                                  |        |              |             |
| *AccountsApi*                                                                                                   | [**
 GetAccounts**](docs/AccountsApi.md#getaccounts)                                                                 | **
 GET** /companies/{companySlug}/accounts                                                                         |        |
| *BankAccountsApi*                                                                                               | [**
 CreateBankAccount**](docs/BankAccountsApi.md#createbankaccount)                                                 | **     |              |
| POST** /companies/{companySlug}/bankAccounts                                                                    |        |              |             |
| *BankAccountsApi*                                                                                               | [**
 GetBankAccount**](docs/BankAccountsApi.md#getbankaccount)                                                       | **     |              |
| GET** /companies/{companySlug}/bankAccounts/{bankAccountId}                                                     |        |              |             |
| *BankAccountsApi*                                                                                               | [**
 GetBankAccounts**](docs/BankAccountsApi.md#getbankaccounts)                                                     | **     |              |
| GET** /companies/{companySlug}/bankAccounts                                                                     |        |              |             |
| *CompaniesApi*                                                                                                  | [**
 GetCompanies**](docs/CompaniesApi.md#getcompanies)                                                              | **
 GET** /companies                                                                                                |        |
| *CompaniesApi*                                                                                                  | [**
 GetCompany**](docs/CompaniesApi.md#getcompany)                                                                  | **
 GET** /companies/{companySlug}                                                                                  |        |
| *ContactsApi*                                                                                                   | [**
 AddAttachmentToContact**](docs/ContactsApi.md#addattachmenttocontact)                                           | **     |              |
| POST** /companies/{companySlug}/contacts/{contactId}/attachments                                                |        |              |             |
| *ContactsApi*                                                                                                   | [**
 AddContactPersonToContact**](docs/ContactsApi.md#addcontactpersontocontact)                                     | **     |              |
| POST** /companies/{companySlug}/contacts/{contactId}/contactPerson                                              |        |              |             |
| *ContactsApi*                                                                                                   | [**
 CreateContact**](docs/ContactsApi.md#createcontact)                                                             | **
 POST** /companies/{companySlug}/contacts                                                                        |        |
| *ContactsApi*                                                                                                   | [**
 DeleteContactContactPerson**](docs/ContactsApi.md#deletecontactcontactperson)                                   | **     |              |
| DELETE** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId}                          |        |              |             |
| *ContactsApi*                                                                                                   | [**
 GetContact**](docs/ContactsApi.md#getcontact)                                                                   | **     |              |
| GET** /companies/{companySlug}/contacts/{contactId}                                                             |        |              |             |
| *ContactsApi*                                                                                                   | [**
 GetContactContactPerson**](docs/ContactsApi.md#getcontactcontactperson)                                         | **     |              |
| GET** /companies/{companySlug}/contacts/{contactId}/contactPerson                                               |        |              |             |
| *ContactsApi*                                                                                                   | [**
 GetContactPerson**](docs/ContactsApi.md#getcontactperson)                                                       | **     |              |
| GET** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId}                             |        |              |             |
| *ContactsApi*                                                                                                   | [**
 GetContacts**](docs/ContactsApi.md#getcontacts)                                                                 | **
 GET** /companies/{companySlug}/contacts                                                                         |        |
| *ContactsApi*                                                                                                   | [**
 UpdateContact**](docs/ContactsApi.md#updatecontact)                                                             | **     |              |
| PUT** /companies/{companySlug}/contacts/{contactId}                                                             |        |              |             |
| *ContactsApi*                                                                                                   | [**
 UpdateContactContactPerson**](docs/ContactsApi.md#updatecontactcontactperson)                                   | **     |              |
| PUT** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId}                             |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 AddAttachmentToCreditNoteDraft**](docs/CreditNotesApi.md#addattachmenttocreditnotedraft)                        | **     |              |
| POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments                                        |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 CreateCreditNoteDraft**](docs/CreditNotesApi.md#createcreditnotedraft)                                          | **     |              |
| POST** /companies/{companySlug}/creditNotes/drafts                                                              |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 CreateCreditNoteFromDraft**](docs/CreditNotesApi.md#createcreditnotefromdraft)                                  | **     |              |
| POST** /companies/{companySlug}/creditNotes/drafts/{draftId}/createCreditNote                                   |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 CreateFullCreditNote**](docs/CreditNotesApi.md#createfullcreditnote)                                            | **     |              |
| POST** /companies/{companySlug}/creditNotes/full                                                                |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 CreatePartialCreditNote**](docs/CreditNotesApi.md#createpartialcreditnote)                                      | **     |              |
| POST** /companies/{companySlug}/creditNotes/partial                                                             |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 DeleteCreditNoteDraft**](docs/CreditNotesApi.md#deletecreditnotedraft)                                          | **     |              |
| DELETE** /companies/{companySlug}/creditNotes/drafts/{draftId}                                                  |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 GetCreditNote**](docs/CreditNotesApi.md#getcreditnote)                                                          | **     |              |
| GET** /companies/{companySlug}/creditNotes/{creditNoteId}                                                       |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 GetCreditNoteDraft**](docs/CreditNotesApi.md#getcreditnotedraft)                                                | **     |              |
| GET** /companies/{companySlug}/creditNotes/drafts/{draftId}                                                     |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 GetCreditNoteDraftAttachments**](docs/CreditNotesApi.md#getcreditnotedraftattachments)                          | **     |              |
| GET** /companies/{companySlug}/creditNotes/drafts/{draftId}/attachments                                         |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 GetCreditNoteDrafts**](docs/CreditNotesApi.md#getcreditnotedrafts)                                              | **     |              |
| GET** /companies/{companySlug}/creditNotes/drafts                                                               |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 GetCreditNotes**](docs/CreditNotesApi.md#getcreditnotes)                                                        | **     |              |
| GET** /companies/{companySlug}/creditNotes                                                                      |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 SendCreditNote**](docs/CreditNotesApi.md#sendcreditnote)                                                        | **     |              |
| POST** /companies/{companySlug}/creditNotes/send                                                                |        |              |             |
| *CreditNotesApi*                                                                                                | [**
 UpdateCreditNoteDraft**](docs/CreditNotesApi.md#updatecreditnotedraft)                                          | **     |              |
| PUT** /companies/{companySlug}/creditNotes/drafts/{draftId}                                                     |        |              |             |
| *GroupsApi*                                                                                                     | [**
 GetGroups**](docs/GroupsApi.md#getgroups)                                                                       | **
 GET** /companies/{companySlug}/groups                                                                           |        |
| *InboxApi*                                                                                                      | [**
 CreateInboxDocument**](docs/InboxApi.md#createinboxdocument)                                                    | **
 POST** /companies/{companySlug}/inbox                                                                           |        |
| *InboxApi*                                                                                                      | [**
 GetInbox**](docs/InboxApi.md#getinbox)                                                                          | **
 GET** /companies/{companySlug}/inbox                                                                            |        |
| *InboxApi*                                                                                                      | [**
 GetInboxDocument**](docs/InboxApi.md#getinboxdocument)                                                          | **     |              |
| GET** /companies/{companySlug}/inbox/{inboxDocumentId}                                                          |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 AddAttachmentToInvoice**](docs/InvoicesApi.md#addattachmenttoinvoice)                                           | **     |              |
| POST** /companies/{companySlug}/invoices/{invoiceId}/attachments                                                |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 AddAttachmentToInvoiceDraft**](docs/InvoicesApi.md#addattachmenttoinvoicedraft)                                 | **     |              |
| POST** /companies/{companySlug}/invoices/drafts/{draftId}/attachments                                           |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 CreateInvoice**](docs/InvoicesApi.md#createinvoice)                                                             | **
 POST** /companies/{companySlug}/invoices                                                                        |        |
| *InvoicesApi*                                                                                                   | [**
 CreateInvoiceDraft**](docs/InvoicesApi.md#createinvoicedraft)                                                   | **     |              |
| POST** /companies/{companySlug}/invoices/drafts                                                                 |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 CreateInvoiceFromDraft**](docs/InvoicesApi.md#createinvoicefromdraft)                                           | **     |              |
| POST** /companies/{companySlug}/invoices/drafts/{draftId}/createInvoice                                         |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 DeleteInvoiceDraft**](docs/InvoicesApi.md#deleteinvoicedraft)                                                   | **     |              |
| DELETE** /companies/{companySlug}/invoices/drafts/{draftId}                                                     |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoice**](docs/InvoicesApi.md#getinvoice)                                                                   | **     |              |
| GET** /companies/{companySlug}/invoices/{invoiceId}                                                             |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoiceAttachments**](docs/InvoicesApi.md#getinvoiceattachments)                                             | **     |              |
| GET** /companies/{companySlug}/invoices/{invoiceId}/attachments                                                 |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoiceDraft**](docs/InvoicesApi.md#getinvoicedraft)                                                         | **     |              |
| GET** /companies/{companySlug}/invoices/drafts/{draftId}                                                        |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoiceDraftAttachments**](docs/InvoicesApi.md#getinvoicedraftattachments)                                   | **     |              |
| GET** /companies/{companySlug}/invoices/drafts/{draftId}/attachments                                            |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoiceDrafts**](docs/InvoicesApi.md#getinvoicedrafts)                                                       | **     |              |
| GET** /companies/{companySlug}/invoices/drafts                                                                  |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 GetInvoices**](docs/InvoicesApi.md#getinvoices)                                                                 | **
 GET** /companies/{companySlug}/invoices                                                                         |        |
| *InvoicesApi*                                                                                                   | [**
 SendInvoice**](docs/InvoicesApi.md#sendinvoice)                                                                 | **
 POST** /companies/{companySlug}/invoices/send                                                                   |        |
| *InvoicesApi*                                                                                                   | [**
 UpdateInvoice**](docs/InvoicesApi.md#updateinvoice)                                                             | **     |              |
| PATCH** /companies/{companySlug}/invoices/{invoiceId}                                                           |        |              |             |
| *InvoicesApi*                                                                                                   | [**
 UpdateInvoiceDraft**](docs/InvoicesApi.md#updateinvoicedraft)                                                   | **     |              |
| PUT** /companies/{companySlug}/invoices/drafts/{draftId}                                                        |        |              |             |
| *JournalEntriesApi*                                                                                             | [**
 AddAttachmentToJournalEntry**](docs/JournalEntriesApi.md#addattachmenttojournalentry)                           | **     |              |
| POST** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments                                     |        |              |             |
| *JournalEntriesApi*                                                                                             | [**
 CreateGeneralJournalEntry**](docs/JournalEntriesApi.md#creategeneraljournalentry)                               | **     |              |
| POST** /companies/{companySlug}/generalJournalEntries                                                           |        |              |             |
| *JournalEntriesApi*                                                                                             | [**
 GetJournalEntries**](docs/JournalEntriesApi.md#getjournalentries)                                               | **     |              |
| GET** /companies/{companySlug}/journalEntries                                                                   |        |              |             |
| *JournalEntriesApi*                                                                                             | [**
 GetJournalEntry**](docs/JournalEntriesApi.md#getjournalentry)                                                   | **     |              |
| GET** /companies/{companySlug}/journalEntries/{journalEntryId}                                                  |        |              |             |
| *JournalEntriesApi*                                                                                             | [**
 GetJournalEntryAttachments**](docs/JournalEntriesApi.md#getjournalentryattachments)                             | **     |              |
| GET** /companies/{companySlug}/journalEntries/{journalEntryId}/attachments                                      |        |              |             |
| *OffersApi*                                                                                                     | [**
 AddAttachmentToOfferDraft**](docs/OffersApi.md#addattachmenttoofferdraft)                                       | **     |              |
| POST** /companies/{companySlug}/offers/drafts/{draftId}/attachments                                             |        |              |             |
| *OffersApi*                                                                                                     | [**
 CreateOfferDraft**](docs/OffersApi.md#createofferdraft)                                                         | **     |              |
| POST** /companies/{companySlug}/offers/drafts                                                                   |        |              |             |
| *OffersApi*                                                                                                     | [**
 CreateOfferFromDraft**](docs/OffersApi.md#createofferfromdraft)                                                 | **     |              |
| POST** /companies/{companySlug}/offers/drafts/{draftId}/createOffer                                             |        |              |             |
| *OffersApi*                                                                                                     | [**
 DeleteOfferDraft**](docs/OffersApi.md#deleteofferdraft)                                                         | **     |              |
| DELETE** /companies/{companySlug}/offers/drafts/{draftId}                                                       |        |              |             |
| *OffersApi*                                                                                                     | [**
 GetOffer**](docs/OffersApi.md#getoffer)                                                                         | **
 GET** /companies/{companySlug}/offers/{offerId}                                                                 |        |
| *OffersApi*                                                                                                     | [**
 GetOfferDraft**](docs/OffersApi.md#getofferdraft)                                                               | **     |              |
| GET** /companies/{companySlug}/offers/drafts/{draftId}                                                          |        |              |             |
| *OffersApi*                                                                                                     | [**
 GetOfferDraftAttachments**](docs/OffersApi.md#getofferdraftattachments)                                         | **     |              |
| GET** /companies/{companySlug}/offers/drafts/{draftId}/attachments                                              |        |              |             |
| *OffersApi*                                                                                                     | [**
 GetOfferDrafts**](docs/OffersApi.md#getofferdrafts)                                                             | **
 GET** /companies/{companySlug}/offers/drafts                                                                    |        |
| *OffersApi*                                                                                                     | [**
 GetOffers**](docs/OffersApi.md#getoffers)                                                                       | **
 GET** /companies/{companySlug}/offers                                                                           |        |
| *OffersApi*                                                                                                     | [**
 UpdateOfferDraft**](docs/OffersApi.md#updateofferdraft)                                                         | **     |              |
| PUT** /companies/{companySlug}/offers/drafts/{draftId}                                                          |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| AddAttachmentToOrderConfirmationDraft**](docs/OrderConfirmationsApi.md#addattachmenttoorderconfirmationdraft)   | **     |              |             |
| POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments                                 |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| CreateInvoicDraftFromOrderConfirmation**](docs/OrderConfirmationsApi.md#createinvoicdraftfromorderconfirmation) | **     |              |             |
| POST** /companies/{companySlug}/orderConfirmations/{confirmationId}/createInvoiceDraft                          |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| CreateOrderConfirmationDraft**](docs/OrderConfirmationsApi.md#createorderconfirmationdraft)                     | **     |              |             |
| POST** /companies/{companySlug}/orderConfirmations/drafts                                                       |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| CreateOrderConfirmationFromDraft**](docs/OrderConfirmationsApi.md#createorderconfirmationfromdraft)             | **     |              |             |
| POST** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/createOrderConfirmation                     |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| DeleteOrderConfirmationDraft**](docs/OrderConfirmationsApi.md#deleteorderconfirmationdraft)                     | **     |              |             |
| DELETE** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                           |        |              |             |
| *OrderConfirmationsApi*                                                                                         | [**
 GetOrderConfirmation**](docs/OrderConfirmationsApi.md#getorderconfirmation)                                     | **     |              |
| GET** /companies/{companySlug}/orderConfirmations/{confirmationId}                                              |        |              |             |
| *OrderConfirmationsApi*                                                                                         | [**
 GetOrderConfirmationDraft**](docs/OrderConfirmationsApi.md#getorderconfirmationdraft)                           | **     |              |
| GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                              |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| GetOrderConfirmationDraftAttachments**](docs/OrderConfirmationsApi.md#getorderconfirmationdraftattachments)     | **     |              |             |
| GET** /companies/{companySlug}/orderConfirmations/drafts/{draftId}/attachments                                  |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| GetOrderConfirmationDrafts**](docs/OrderConfirmationsApi.md#getorderconfirmationdrafts)                         | **     |              |             |
| GET** /companies/{companySlug}/orderConfirmations/drafts                                                        |        |              |             |
| *OrderConfirmationsApi*                                                                                         | [**
 GetOrderConfirmations**](docs/OrderConfirmationsApi.md#getorderconfirmations)                                   | **     |              |
| GET** /companies/{companySlug}/orderConfirmations                                                               |        |              |             |
| *
 OrderConfirmationsApi*                                                                                          | [**    |              |             |
| UpdateOrderConfirmationDraft**](docs/OrderConfirmationsApi.md#updateorderconfirmationdraft)                     | **     |              |             |
| PUT** /companies/{companySlug}/orderConfirmations/drafts/{draftId}                                              |        |              |             |
| *ProductsApi*                                                                                                   | [**
 CreateProduct**](docs/ProductsApi.md#createproduct)                                                             | **
 POST** /companies/{companySlug}/products                                                                        |        |
| *ProductsApi*                                                                                                   | [**
 CreateProductSalesReport**](docs/ProductsApi.md#createproductsalesreport)                                       | **     |              |
| POST** /companies/{companySlug}/products/salesReport                                                            |        |              |             |
| *ProductsApi*                                                                                                   | [**
 DeleteProduct**](docs/ProductsApi.md#deleteproduct)                                                             | **     |              |
| DELETE** /companies/{companySlug}/products/{productId}                                                          |        |              |             |
| *ProductsApi*                                                                                                   | [**
 GetProduct**](docs/ProductsApi.md#getproduct)                                                                   | **     |              |
| GET** /companies/{companySlug}/products/{productId}                                                             |        |              |             |
| *ProductsApi*                                                                                                   | [**
 GetProducts**](docs/ProductsApi.md#getproducts)                                                                 | **
 GET** /companies/{companySlug}/products                                                                         |        |
| *ProductsApi*                                                                                                   | [**
 UpdateProduct**](docs/ProductsApi.md#updateproduct)                                                             | **     |              |
| PUT** /companies/{companySlug}/products/{productId}                                                             |        |              |             |
| *ProjectsApi*                                                                                                   | [**
 CreateProject**](docs/ProjectsApi.md#createproject)                                                             | **
 POST** /companies/{companySlug}/projects                                                                        |        |
| *ProjectsApi*                                                                                                   | [**
 DeleteProject**](docs/ProjectsApi.md#deleteproject)                                                             | **     |              |
| DELETE** /companies/{companySlug}/projects/{projectId}                                                          |        |              |             |
| *ProjectsApi*                                                                                                   | [**
 GetProject**](docs/ProjectsApi.md#getproject)                                                                   | **     |              |
| GET** /companies/{companySlug}/projects/{projectId}                                                             |        |              |             |
| *ProjectsApi*                                                                                                   | [**
 GetProjects**](docs/ProjectsApi.md#getprojects)                                                                 | **
 GET** /companies/{companySlug}/projects                                                                         |        |
| *ProjectsApi*                                                                                                   | [**
 UpdateProject**](docs/ProjectsApi.md#updateproject)                                                             | **     |              |
| PATCH** /companies/{companySlug}/projects/{projectId}                                                           |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 AddAttachmentToPurchase**](docs/PurchasesApi.md#addattachmenttopurchase)                                        | **     |              |
| POST** /companies/{companySlug}/purchases/{purchaseId}/attachments                                              |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 AddAttachmentToPurchaseDraft**](docs/PurchasesApi.md#addattachmenttopurchasedraft)                              | **     |              |
| POST** /companies/{companySlug}/purchases/drafts/{draftId}/attachments                                          |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 CreatePurchase**](docs/PurchasesApi.md#createpurchase)                                                          | **     |              |
| POST** /companies/{companySlug}/purchases                                                                       |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 CreatePurchaseDraft**](docs/PurchasesApi.md#createpurchasedraft)                                                | **     |              |
| POST** /companies/{companySlug}/purchases/drafts                                                                |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 CreatePurchaseFromDraft**](docs/PurchasesApi.md#createpurchasefromdraft)                                        | **     |              |
| POST** /companies/{companySlug}/purchases/drafts/{draftId}/createPurchase                                       |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 CreatePurchasePayment**](docs/PurchasesApi.md#createpurchasepayment)                                            | **     |              |
| POST** /companies/{companySlug}/purchases/{purchaseId}/payments                                                 |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 DeletePurchase**](docs/PurchasesApi.md#deletepurchase)                                                          | **     |              |
| PATCH** /companies/{companySlug}/purchases/{purchaseId}/delete                                                  |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 DeletePurchaseDraft**](docs/PurchasesApi.md#deletepurchasedraft)                                                | **     |              |
| DELETE** /companies/{companySlug}/purchases/drafts/{draftId}                                                    |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchase**](docs/PurchasesApi.md#getpurchase)                                                                | **     |              |
| GET** /companies/{companySlug}/purchases/{purchaseId}                                                           |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchaseAttachments**](docs/PurchasesApi.md#getpurchaseattachments)                                          | **     |              |
| GET** /companies/{companySlug}/purchases/{purchaseId}/attachments                                               |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchaseDraft**](docs/PurchasesApi.md#getpurchasedraft)                                                      | **     |              |
| GET** /companies/{companySlug}/purchases/drafts/{draftId}                                                       |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchaseDraftAttachments**](docs/PurchasesApi.md#getpurchasedraftattachments)                                | **     |              |
| GET** /companies/{companySlug}/purchases/drafts/{draftId}/attachments                                           |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchaseDrafts**](docs/PurchasesApi.md#getpurchasedrafts)                                                    | **     |              |
| GET** /companies/{companySlug}/purchases/drafts                                                                 |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchasePayment**](docs/PurchasesApi.md#getpurchasepayment)                                                  | **     |              |
| GET** /companies/{companySlug}/purchases/{purchaseId}/payments/{paymentId}                                      |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchasePayments**](docs/PurchasesApi.md#getpurchasepayments)                                                | **     |              |
| GET** /companies/{companySlug}/purchases/{purchaseId}/payments                                                  |        |              |             |
| *PurchasesApi*                                                                                                  | [**
 GetPurchases**](docs/PurchasesApi.md#getpurchases)                                                              | **
 GET** /companies/{companySlug}/purchases                                                                        |        |
| *PurchasesApi*                                                                                                  | [**
 UpdatePurchaseDraft**](docs/PurchasesApi.md#updatepurchasedraft)                                                | **     |              |
| PUT** /companies/{companySlug}/purchases/drafts/{draftId}                                                       |        |              |             |
| *SalesApi*                                                                                                      | [**
 AddAttachmentToSale**](docs/SalesApi.md#addattachmenttosale)                                                    | **     |              |
| POST** /companies/{companySlug}/sales/{saleId}/attachments                                                      |        |              |             |
| *SalesApi*                                                                                                      | [**
 AddAttachmentToSaleDraft**](docs/SalesApi.md#addattachmenttosaledraft)                                          | **     |              |
| POST** /companies/{companySlug}/sales/drafts/{draftId}/attachments                                              |        |              |             |
| *SalesApi*                                                                                                      | [**
 CreateSale**](docs/SalesApi.md#createsale)                                                                      | **
 POST** /companies/{companySlug}/sales                                                                           |        |
| *SalesApi*                                                                                                      | [**
 CreateSaleDraft**](docs/SalesApi.md#createsaledraft)                                                            | **
 POST** /companies/{companySlug}/sales/drafts                                                                    |        |
| *SalesApi*                                                                                                      | [**
 CreateSaleFromDraft**](docs/SalesApi.md#createsalefromdraft)                                                    | **     |              |
| POST** /companies/{companySlug}/sales/drafts/{draftId}/createSale                                               |        |              |             |
| *SalesApi*                                                                                                      | [**
 CreateSalePayment**](docs/SalesApi.md#createsalepayment)                                                        | **     |              |
| POST** /companies/{companySlug}/sales/{saleId}/payments                                                         |        |              |             |
| *SalesApi*                                                                                                      | [**
 DeleteSale**](docs/SalesApi.md#deletesale)                                                                      | **
 PATCH** /companies/{companySlug}/sales/{saleId}/delete                                                          |        |
| *SalesApi*                                                                                                      | [**
 DeleteSaleDraft**](docs/SalesApi.md#deletesaledraft)                                                            | **     |              |
| DELETE** /companies/{companySlug}/sales/drafts/{draftId}                                                        |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSale**](docs/SalesApi.md#getsale)                                                                            | **
 GET** /companies/{companySlug}/sales/{saleId}                                                                   |        |
| *SalesApi*                                                                                                      | [**
 GetSaleAttachments**](docs/SalesApi.md#getsaleattachments)                                                      | **     |              |
| GET** /companies/{companySlug}/sales/{saleId}/attachments                                                       |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSaleDraft**](docs/SalesApi.md#getsaledraft)                                                                  | **     |              |
| GET** /companies/{companySlug}/sales/drafts/{draftId}                                                           |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSaleDraftAttachments**](docs/SalesApi.md#getsaledraftattachments)                                            | **     |              |
| GET** /companies/{companySlug}/sales/drafts/{draftId}/attachments                                               |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSaleDrafts**](docs/SalesApi.md#getsaledrafts)                                                                | **
 GET** /companies/{companySlug}/sales/drafts                                                                     |        |
| *SalesApi*                                                                                                      | [**
 GetSalePayment**](docs/SalesApi.md#getsalepayment)                                                              | **     |              |
| GET** /companies/{companySlug}/sales/{saleId}/payments/{paymentId}                                              |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSalePayments**](docs/SalesApi.md#getsalepayments)                                                            | **     |              |
| GET** /companies/{companySlug}/sales/{saleId}/payments                                                          |        |              |             |
| *SalesApi*                                                                                                      | [**
 GetSales**](docs/SalesApi.md#getsales)                                                                          | **
 GET** /companies/{companySlug}/sales                                                                            |        |
| *SalesApi*                                                                                                      | [**
 UpdateSaleDraft**](docs/SalesApi.md#updatesaledraft)                                                            | **     |              |
| PUT** /companies/{companySlug}/sales/drafts/{draftId}                                                           |        |              |             |
| *TransactionsApi*                                                                                               | [**
 GetTransaction**](docs/TransactionsApi.md#gettransaction)                                                       | **     |              |
| GET** /companies/{companySlug}/transactions/{transactionId}                                                     |        |              |             |
| *UserApi*                                                                                                       | [**
 GetUser**](docs/UserApi.md#getuser)                                                                             | **
 GET** /user                                                                                                     |        |

<a name="documentation-for-models"></a>

## Documentation for Models

- [IO.Swagger.Model.Account](docs/Account.md)
- [IO.Swagger.Model.AccountBalance](docs/AccountBalance.md)
- [IO.Swagger.Model.Address](docs/Address.md)
- [IO.Swagger.Model.Attachment](docs/Attachment.md)
- [IO.Swagger.Model.BankAccountRequest](docs/BankAccountRequest.md)
- [IO.Swagger.Model.BankAccountResult](docs/BankAccountResult.md)
- [IO.Swagger.Model.Company](docs/Company.md)
- [IO.Swagger.Model.CompanySlugInboxBody](docs/CompanySlugInboxBody.md)
- [IO.Swagger.Model.Contact](docs/Contact.md)
- [IO.Swagger.Model.ContactIdAttachmentsBody](docs/ContactIdAttachmentsBody.md)
- [IO.Swagger.Model.ContactNote](docs/ContactNote.md)
- [IO.Swagger.Model.ContactPerson](docs/ContactPerson.md)
- [IO.Swagger.Model.CreditNoteLineResult](docs/CreditNoteLineResult.md)
- [IO.Swagger.Model.CreditNoteResult](docs/CreditNoteResult.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody](docs/DraftIdAttachmentsBody.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody1](docs/DraftIdAttachmentsBody1.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody2](docs/DraftIdAttachmentsBody2.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody3](docs/DraftIdAttachmentsBody3.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody4](docs/DraftIdAttachmentsBody4.md)
- [IO.Swagger.Model.DraftIdAttachmentsBody5](docs/DraftIdAttachmentsBody5.md)
- [IO.Swagger.Model.DraftLineRequest](docs/DraftLineRequest.md)
- [IO.Swagger.Model.DraftLineResult](docs/DraftLineResult.md)
- [IO.Swagger.Model.DraftRequest](docs/DraftRequest.md)
- [IO.Swagger.Model.DraftResult](docs/DraftResult.md)
- [IO.Swagger.Model.FullCreditNoteRequest](docs/FullCreditNoteRequest.md)
- [IO.Swagger.Model.GeneralJournalEntryRequest](docs/GeneralJournalEntryRequest.md)
- [IO.Swagger.Model.InboxResult](docs/InboxResult.md)
- [IO.Swagger.Model.InvoiceIdAttachmentsBody](docs/InvoiceIdAttachmentsBody.md)
- [IO.Swagger.Model.InvoiceLineRequest](docs/InvoiceLineRequest.md)
- [IO.Swagger.Model.InvoiceLineResult](docs/InvoiceLineResult.md)
- [IO.Swagger.Model.InvoiceRequest](docs/InvoiceRequest.md)
- [IO.Swagger.Model.InvoiceResult](docs/InvoiceResult.md)
- [IO.Swagger.Model.InvoiceishDraftLine](docs/InvoiceishDraftLine.md)
- [IO.Swagger.Model.InvoiceishDraftRequest](docs/InvoiceishDraftRequest.md)
- [IO.Swagger.Model.InvoiceishDraftResult](docs/InvoiceishDraftResult.md)
- [IO.Swagger.Model.JournalEntry](docs/JournalEntry.md)
- [IO.Swagger.Model.JournalEntryIdAttachmentsBody](docs/JournalEntryIdAttachmentsBody.md)
- [IO.Swagger.Model.JournalEntryLine](docs/JournalEntryLine.md)
- [IO.Swagger.Model.Offer](docs/Offer.md)
- [IO.Swagger.Model.OrderConfirmation](docs/OrderConfirmation.md)
- [IO.Swagger.Model.OrderLine](docs/OrderLine.md)
- [IO.Swagger.Model.PartialCreditNoteRequest](docs/PartialCreditNoteRequest.md)
- [IO.Swagger.Model.Payment](docs/Payment.md)
- [IO.Swagger.Model.Product](docs/Product.md)
- [IO.Swagger.Model.ProductSalesLineInfo](docs/ProductSalesLineInfo.md)
- [IO.Swagger.Model.ProductSalesReportRequest](docs/ProductSalesReportRequest.md)
- [IO.Swagger.Model.ProductSalesReportResult](docs/ProductSalesReportResult.md)
- [IO.Swagger.Model.ProjectRequest](docs/ProjectRequest.md)
- [IO.Swagger.Model.ProjectResult](docs/ProjectResult.md)
- [IO.Swagger.Model.PurchaseIdAttachmentsBody](docs/PurchaseIdAttachmentsBody.md)
- [IO.Swagger.Model.PurchaseRequest](docs/PurchaseRequest.md)
- [IO.Swagger.Model.PurchaseResult](docs/PurchaseResult.md)
- [IO.Swagger.Model.SaleIdAttachmentsBody](docs/SaleIdAttachmentsBody.md)
- [IO.Swagger.Model.SaleRequest](docs/SaleRequest.md)
- [IO.Swagger.Model.SaleResult](docs/SaleResult.md)
- [IO.Swagger.Model.SendCreditNoteRequest](docs/SendCreditNoteRequest.md)
- [IO.Swagger.Model.SendFakturaisjRequest](docs/SendFakturaisjRequest.md)
- [IO.Swagger.Model.SendInvoiceRequest](docs/SendInvoiceRequest.md)
- [IO.Swagger.Model.Transaction](docs/Transaction.md)
- [IO.Swagger.Model.UpdateInvoiceRequest](docs/UpdateInvoiceRequest.md)
- [IO.Swagger.Model.UpdateProjectRequest](docs/UpdateProjectRequest.md)
- [IO.Swagger.Model.Userinfo](docs/Userinfo.md)

<a name="documentation-for-authorization"></a>

## Documentation for Authorization

<a name="fiken_api_oauth"></a>

### fiken_api_oauth

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://fiken.no/oauth/authorize
- **Scopes**:

