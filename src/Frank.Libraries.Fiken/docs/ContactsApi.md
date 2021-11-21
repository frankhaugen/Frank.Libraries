# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://api.fiken.no/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAttachmentToContact**](ContactsApi.md#addattachmenttocontact) | **
POST** /companies/{companySlug}/contacts/{contactId}/attachments |
[**AddContactPersonToContact**](ContactsApi.md#addcontactpersontocontact) | **
POST** /companies/{companySlug}/contacts/{contactId}/contactPerson |
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /companies/{companySlug}/contacts |
[**DeleteContactContactPerson**](ContactsApi.md#deletecontactcontactperson) | **
DELETE** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |
[**GetContact**](ContactsApi.md#getcontact) | **GET** /companies/{companySlug}/contacts/{contactId} |
[**GetContactContactPerson**](ContactsApi.md#getcontactcontactperson) | **
GET** /companies/{companySlug}/contacts/{contactId}/contactPerson |
[**GetContactPerson**](ContactsApi.md#getcontactperson) | **
GET** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |
[**GetContacts**](ContactsApi.md#getcontacts) | **GET** /companies/{companySlug}/contacts |
[**UpdateContact**](ContactsApi.md#updatecontact) | **PUT** /companies/{companySlug}/contacts/{contactId} |
[**UpdateContactContactPerson**](ContactsApi.md#updatecontactcontactperson) | **
PUT** /companies/{companySlug}/contacts/{contactId}/contactPerson/{contactPersonId} |

<a name="addattachmenttocontact"></a>

# **AddAttachmentToContact**

> void AddAttachmentToContact (string companySlug, long? contactId, string filename, string comment, byte[] file)



Creates and adds a new attachment/document to a contact

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAttachmentToContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |
            var filename = filename_example;  // string |  (optional)
            var comment = comment_example;  // string |  (optional)
            var file = file_example;  // byte[] |  (optional)

            try
            {
                apiInstance.AddAttachmentToContact(companySlug, contactId, filename, comment, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddAttachmentToContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |
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

<a name="addcontactpersontocontact"></a>

# **AddContactPersonToContact**

> void AddContactPersonToContact (ContactPerson body, string companySlug, long? contactId)



Adds a new contact person to a contact

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddContactPersonToContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactPerson(); // ContactPerson |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |

            try
            {
                apiInstance.AddContactPersonToContact(body, companySlug, contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactPersonToContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**ContactPerson**](ContactPerson.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontact"></a>

# **CreateContact**

> void CreateContact (Contact body, string companySlug)



Creates a new contact. The Location response header returns the URL of the newly created contact.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new Contact(); // Contact |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve

            try
            {
                apiInstance.CreateContact(body, companySlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**Contact**](Contact.md)|  |
**companySlug** | **string**| Slug of company to retrieve |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactcontactperson"></a>

# **DeleteContactContactPerson**

> void DeleteContactContactPerson (string companySlug, long? contactId, long? contactPersonId)



Delete a contact's contact person.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteContactContactPersonExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |
            var contactPersonId = 789;  // long? |

            try
            {
                apiInstance.DeleteContactContactPerson(companySlug, contactId, contactPersonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContactContactPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |
**contactPersonId** | **long?**|  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontact"></a>

# **GetContact**

> Contact GetContact (string companySlug, long? contactId)



Retrieves specified contact. ContactId is returned with a GET contacts call as the first returned field. ContactId is
returned in the Location response header for POST contact.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |

            try
            {
                Contact result = apiInstance.GetContact(companySlug, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |

### Return type

[**Contact**](Contact.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactcontactperson"></a>

# **GetContactContactPerson**

> List<ContactPerson> GetContactContactPerson (string companySlug, long? contactId)



Retrieves contact person(s) for a specified contact.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactContactPersonExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |

            try
            {
                List&lt;ContactPerson&gt; result = apiInstance.GetContactContactPerson(companySlug, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactContactPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |

### Return type

[**List<ContactPerson>**](ContactPerson.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactperson"></a>

# **GetContactPerson**

> ContactPerson GetContactPerson (string companySlug, long? contactId, long? contactPersonId)



Retrieves specified contact person

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactPersonExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |
            var contactPersonId = 789;  // long? |

            try
            {
                ContactPerson result = apiInstance.GetContactPerson(companySlug, contactId, contactPersonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |
**contactPersonId** | **long?**|  |

### Return type

[**ContactPerson**](ContactPerson.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontacts"></a>

# **GetContacts**

> List<Contact> GetContacts (string companySlug, int? page, int? pageSize, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, int? supplierNumber, int? customerNumber, int? memberNumber, string name, string organizationNumber, string email, bool? customer, bool? supplier, bool? inactive, string group, string sortBy)



Retrieves all contacts for the specified company.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var page = 56;  // int? | Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0.  (optional)  (default to 0)
            var pageSize = 56;  // int? | Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25.  (optional)  (default to 25)
            var lastModified = 2013-10-20;  // DateTime? | Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLe = 2013-10-20;  // DateTime? | Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedLt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGe = 2013-10-20;  // DateTime? | Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var lastModifiedGt = 2013-10-20;  // DateTime? | Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \"1970-01-01\"  (optional)
            var supplierNumber = 56;  // int? | Find all results with the supplier number equal to the specified parameter. (optional)
            var customerNumber = 56;  // int? | Find all results with the customer number equal to the specified parameter. (optional)
            var memberNumber = 56;  // int? | Find all results with the member number equal to the specified parameter. (optional)
            var name = name_example;  // string | Find all results with the name equal to the specified parameter. (optional)
            var organizationNumber = organizationNumber_example;  // string | Find all results with the organization number equal to the specified parameter. (optional)
            var email = email_example;  // string | Find all results with the email equal to the specified parameter. (optional)
            var customer = true;  // bool? | Returns all contacts that are customers. If filter is set for both supplier and customer = true, only contacts that are both supplier and customer will be returned. (optional)
            var supplier = true;  // bool? | Returns all contacts that are suppliers. If filter is set for both supplier and customer = true, only contacts that are both supplier and customer will be returned. (optional)
            var inactive = true;  // bool? | Return all active contacts (false) or all inactive contacts (true). (optional)
            var group = group_example;  // string | Return contacts in contact group, exact match only. Groups are only used for customers, not suppliers. (optional)
            var sortBy = sortBy_example;  // string |  (optional)  (default to createdDate asc)

            try
            {
                List&lt;Contact&gt; result = apiInstance.GetContacts(companySlug, page, pageSize, lastModified, lastModifiedLe, lastModifiedLt, lastModifiedGe, lastModifiedGt, supplierNumber, customerNumber, memberNumber, name, organizationNumber, email, customer, supplier, inactive, group, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContacts: " + e.Message );
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
**supplierNumber** | **int?**| Find all results with the supplier number equal to the specified parameter. | [optional]
**customerNumber** | **int?**| Find all results with the customer number equal to the specified parameter. | [optional]
**memberNumber** | **int?**| Find all results with the member number equal to the specified parameter. | [optional]
**name** | **string**| Find all results with the name equal to the specified parameter. | [optional]
**organizationNumber** | **
string**| Find all results with the organization number equal to the specified parameter. | [optional]
**email** | **string**| Find all results with the email equal to the specified parameter. | [optional]
**customer** | **
bool?**| Returns all contacts that are customers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned. | [optional]
**supplier** | **
bool?**| Returns all contacts that are suppliers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned. | [optional]
**inactive** | **bool?**| Return all active contacts (false) or all inactive contacts (true). | [optional]
**group** | **
string**| Return contacts in contact group, exact match only. Groups are only used for customers, not suppliers. | [optional]
**sortBy** | **string**|  | [optional] [default to createdDate asc]

### Return type

[**List<Contact>**](Contact.md)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontact"></a>

# **UpdateContact**

> void UpdateContact (Contact body, string companySlug, long? contactId)



Updates an existing contact.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new Contact(); // Contact |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |

            try
            {
                apiInstance.UpdateContact(body, companySlug, contactId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**Contact**](Contact.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontactcontactperson"></a>

# **UpdateContactContactPerson**

> void UpdateContactContactPerson (ContactPerson body, string companySlug, long? contactId, long? contactPersonId)



Updates an existing contact person.

### Example

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateContactContactPersonExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: fiken_api_oauth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactPerson(); // ContactPerson |
            var companySlug = companySlug_example;  // string | Slug of company to retrieve
            var contactId = 789;  // long? |
            var contactPersonId = 789;  // long? |

            try
            {
                apiInstance.UpdateContactContactPerson(body, companySlug, contactId, contactPersonId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContactContactPerson: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**body** | [**ContactPerson**](ContactPerson.md)|  |
**companySlug** | **string**| Slug of company to retrieve |
**contactId** | **long?**|  |
**contactPersonId** | **long?**|  |

### Return type

void (empty response body)

### Authorization

[fiken_api_oauth](../README.md#fiken_api_oauth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

