using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInboxClient
{
    /// <summary>
    ///     Upload a document to the inbox
    /// </summary>
    /// <param name="name"></param>
    /// <param name="filename"></param>
    /// <param name="description"></param>
    /// <param name="file"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateInboxDocument(string name, string filename, string description, byte[] file, string companySlug);

    /// <summary>
    ///     Returns the contents of the inbox for given company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">
    ///     Returns the number of the page to return. Valid page values are integers from 0 to the total number
    ///     of pages. Default value is 0.
    /// </param>
    /// <param name="pageSize">
    ///     Defines the number of entries to return on each page. Maximum number of results that can be
    ///     returned at one time are 100. Default value is 25.
    /// </param>
    /// <param name="sortBy">Sorts results in either ascending (asc) or descending (desc) order based on the parameter value.</param>
    /// <param name="status"></param>
    /// <param name="name">Filter documents based on their name, case-insensitive substring match.</param>
    /// <returns>List&lt;InboxResult&gt;</returns>
    List<InboxResult> GetInbox(int? page, int? pageSize, string sortBy, string status, string name);

    /// <summary>
    ///     Returns the inbox document with specified id
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="inboxDocumentId"></param>
    /// <returns>InboxResult</returns>
    InboxResult GetInboxDocument(long? inboxDocumentId);
}