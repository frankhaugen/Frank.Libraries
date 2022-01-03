using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IContactsClient
{
    /// <summary>
    ///  Creates and adds a new attachment/document to a contact
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <param name="filename"></param>
    /// <param name="comment"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToContact(long? contactId, string filename, string comment, byte[] file);

    /// <summary>
    ///  Adds a new contact person to a contact
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <returns></returns>
    void AddContactPersonToContact(ContactPerson body, string companySlug, long? contactId);

    /// <summary>
    ///  Creates a new contact. The Location response header returns the URL of the newly created contact.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateContact(Contact body, string companySlug);

    /// <summary>
    ///  Delete a contact&#x27;s contact person.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <param name="contactPersonId"></param>
    /// <returns></returns>
    void DeleteContactContactPerson(long? contactId, long? contactPersonId);

    /// <summary>
    ///  Retrieves specified contact. ContactId is returned with a GET contacts call as the first returned field. ContactId is returned in the Location response header for POST contact.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <returns>Contact</returns>
    Contact GetContact(long? contactId);

    /// <summary>
    ///  Retrieves contact person(s) for a specified contact.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <returns>List&lt;ContactPerson&gt;</returns>
    List<ContactPerson> GetContactContactPerson(long? contactId);

    /// <summary>
    ///  Retrieves specified contact person
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <param name="contactPersonId"></param>
    /// <returns>ContactPerson</returns>
    ContactPerson GetContactPerson(long? contactId, long? contactPersonId);

    /// <summary>
    ///  Retrieves all contacts for the specified company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="lastModified">Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedLe">Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedLt">Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedGe">Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedGt">Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="supplierNumber">Find all results with the supplier number equal to the specified parameter.</param>
    /// <param name="customerNumber">Find all results with the customer number equal to the specified parameter.</param>
    /// <param name="memberNumber">Find all results with the member number equal to the specified parameter.</param>
    /// <param name="name">Find all results with the name equal to the specified parameter.</param>
    /// <param name="organizationNumber">Find all results with the organization number equal to the specified parameter.</param>
    /// <param name="email">Find all results with the email equal to the specified parameter.</param>
    /// <param name="customer">Returns all contacts that are customers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned.</param>
    /// <param name="supplier">Returns all contacts that are suppliers. If filter is set for both supplier and customer &#x3D; true, only contacts that are both supplier and customer will be returned.</param>
    /// <param name="inactive">Return all active contacts (false) or all inactive contacts (true).</param>
    /// <param name="group">Return contacts in contact group, exact match only. Groups are only used for customers, not suppliers.</param>
    /// <param name="sortBy"></param>
    /// <returns>List&lt;Contact&gt;</returns>
    List<Contact> GetContacts(int? page, int? pageSize, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, int? supplierNumber, int? customerNumber, int? memberNumber, string name, string organizationNumber, string email, bool? customer, bool? supplier, bool? inactive, string group, string sortBy);

    /// <summary>
    ///  Updates an existing contact.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <returns></returns>
    void UpdateContact(Contact body, string companySlug, long? contactId);

    /// <summary>
    ///  Updates an existing contact person.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="contactId"></param>
    /// <param name="contactPersonId"></param>
    /// <returns></returns>
    void UpdateContactContactPerson(ContactPerson body, string companySlug, long? contactId, long? contactPersonId);
}