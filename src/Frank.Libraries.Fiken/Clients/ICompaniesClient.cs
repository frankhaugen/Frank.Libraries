using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompaniesClient
{
    /// <summary>
    ///     Returns all companies from the system that the user has access to
    /// </summary>
    /// <param name="page">
    ///     Returns the number of the page to return. Valid page values are integers from 0 to the total number
    ///     of pages. Default value is 0.
    /// </param>
    /// <param name="pageSize">
    ///     Defines the number of entries to return on each page. Maximum number of results that can be
    ///     returned at one time are 100. Default value is 25.
    /// </param>
    /// <param name="sortBy"></param>
    /// <returns>List&lt;Company&gt;</returns>
    List<Company> GetCompanies(int? page, int? pageSize, string sortBy);

    /// <summary>
    ///     Returns company associated with slug.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns>Company</returns>
    Company GetCompany(string companySlug);
}