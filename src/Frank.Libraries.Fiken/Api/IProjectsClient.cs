using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IProjectsClient
{
    /// <summary>
    ///  Creates a new project
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateProject(ProjectRequest body, string companySlug);

    /// <summary>
    ///  Delete project with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="projectId"></param>
    /// <returns></returns>
    void DeleteProject(long? projectId);

    /// <summary>
    ///  Returns project with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="projectId"></param>
    /// <returns>ProjectResult</returns>
    ProjectResult GetProject(long? projectId);

    /// <summary>
    ///  Returns all projects for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="completed">Filter results based on completed / not completed.</param>
    /// <returns>List&lt;ProjectResult&gt;</returns>
    List<ProjectResult> GetProjects(int? page, int? pageSize, bool? completed);

    /// <summary>
    ///  Updates project with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="projectId"></param>
    /// <returns></returns>
    void UpdateProject(UpdateProjectRequest body, string companySlug, long? projectId);
}