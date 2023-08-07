using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICreditNotesClient
{
    /// <summary>
    ///     Creates and adds a new attachment to a credit note draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="comment"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToCreditNoteDraft(long? draftId, string filename, string comment, byte[] file);

    /// <summary>
    ///     Creates a credit note draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateCreditNoteDraft(InvoiceishDraftRequest body, string companySlug);

    /// <summary>
    ///     Creates a credit note from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreateCreditNoteFromDraft(long? draftId);

    /// <summary>
    ///     Creates a new credit note.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateFullCreditNote(FullCreditNoteRequest body, string companySlug);

    /// <summary>
    ///     Creates a new credit note.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreatePartialCreditNote(PartialCreditNoteRequest body, string companySlug);

    /// <summary>
    ///     Delete credit note draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeleteCreditNoteDraft(long? draftId);

    /// <summary>
    ///     Returns credit note with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="creditNoteId">
    ///     The creditNoteId (primary key of the returned object) is returned as the first field in the
    ///     GET all credit notes call; not to be confused with creditNoteNumber
    /// </param>
    /// <returns>CreditNoteResult</returns>
    CreditNoteResult GetCreditNote(string creditNoteId);

    /// <summary>
    ///     Returns credit note draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>InvoiceishDraftResult</returns>
    InvoiceishDraftResult GetCreditNoteDraft(long? draftId);

    /// <summary>
    ///     Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetCreditNoteDraftAttachments(long? draftId);

    /// <summary>
    ///     Returns all credit note drafts for given company.
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
    /// <returns>List&lt;InvoiceishDraftResult&gt;</returns>
    List<InvoiceishDraftResult> GetCreditNoteDrafts(int? page, int? pageSize);

    /// <summary>
    ///     Returns all credit notes for given company
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
    /// <param name="issueDate">
    ///     Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;
    ///     1970-01-01\&quot;
    /// </param>
    /// <param name="issueDateLe">
    ///     Filter based on date less than or equal to parameter value. Dates are represented as strings
    ///     formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;
    /// </param>
    /// <param name="issueDateLt">
    ///     Filter based on date strictly less than parameter value. Dates are represented as strings
    ///     formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;
    /// </param>
    /// <param name="issueDateGe">
    ///     Filter based on date greater than or equal to parameter value. Dates are represented as
    ///     strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;
    /// </param>
    /// <param name="issueDateGt">
    ///     Filter based on date strictly greater than parameter value Dates are represented as strings
    ///     formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot;
    /// </param>
    /// <param name="customerId">
    ///     Returns only credit notes sent to specified customer. Must be the contactId provided by a GET
    ///     contacts call.
    /// </param>
    /// <param name="settled">
    ///     When set to true, returns only credit notes that have been settled. Otherwise false returns all
    ///     credit notes that have not been fully settled.
    /// </param>
    /// <returns>List&lt;CreditNoteResult&gt;</returns>
    List<CreditNoteResult> GetCreditNotes(int? page, int? pageSize, DateTime? issueDate, DateTime? issueDateLe, DateTime? issueDateLt, DateTime? issueDateGe, DateTime? issueDateGt, long? customerId, bool? settled);

    /// <summary>
    ///     Sends the specified document
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void SendCreditNote(SendCreditNoteRequest body, string companySlug);

    /// <summary>
    ///     Updates credit note draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdateCreditNoteDraft(InvoiceishDraftRequest body, string companySlug, long? draftId);
}