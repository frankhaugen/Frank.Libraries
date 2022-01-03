using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IJournalEntriesClient
{
    /// <summary>
    ///  Creates and adds a new attachment to a Journal Entry
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="journalEntryId"></param>
    /// <param name="filename"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToJournalEntry(long? journalEntryId, string filename, byte[] file);

    /// <summary>
    ///  Creates a new general journal entry (fri postering).
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateGeneralJournalEntry(GeneralJournalEntryRequest body, string companySlug);

    /// <summary>
    ///  Returns all general journal entries (posteringer) for the specified company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="date">Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="dateLe">Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="dateLt">Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="dateGe">Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="dateGt">Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <returns>List&lt;JournalEntry&gt;</returns>
    List<JournalEntry> GetJournalEntries(int? page, int? pageSize, DateTime? date, DateTime? dateLe, DateTime? dateLt, DateTime? dateGe, DateTime? dateGt);

    /// <summary>
    ///  Returns all journal entries within a given company&#x27;s Journal Entry Service
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="journalEntryId"></param>
    /// <returns>JournalEntry</returns>
    JournalEntry GetJournalEntry(long? journalEntryId);

    /// <summary>
    ///  Returns all attachments for a given Journal Entry
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="journalEntryId"></param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetJournalEntryAttachments(long? journalEntryId);
}