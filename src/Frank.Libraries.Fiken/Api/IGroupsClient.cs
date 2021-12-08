namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IGroupsClient
{
    /// <summary>
    ///  Returns all customer groups for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;string&gt;</returns>
    List<string> GetGroups(int? page, int? pageSize);
}