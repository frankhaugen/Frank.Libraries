using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrderConfirmationsClient
{
    /// <summary>
    ///     Creates and adds a new attachment to an order confirmation draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="comment"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToOrderConfirmationDraft(long? draftId, string filename, string comment, byte[] file);

    /// <summary>
    ///     Creates an invoice draft from an order confirmation
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="confirmationId">
    ///     The confirmationId (primary key of the returned object) is returned as the first field in
    ///     the GET all order confirmations call
    /// </param>
    /// <returns></returns>
    void CreateInvoicDraftFromOrderConfirmation(string confirmationId);

    /// <summary>
    ///     Creates an order confirmation draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateOrderConfirmationDraft(InvoiceishDraftRequest body, string companySlug);

    /// <summary>
    ///     Creates an order confirmation from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreateOrderConfirmationFromDraft(long? draftId);

    /// <summary>
    ///     Delete order confirmation draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeleteOrderConfirmationDraft(long? draftId);

    /// <summary>
    ///     Returns order confirmation with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="confirmationId">
    ///     The confirmationId (primary key of the returned object) is returned as the first field in
    ///     the GET all order confirmations call
    /// </param>
    /// <returns>OrderConfirmation</returns>
    OrderConfirmation GetOrderConfirmation(string confirmationId);

    /// <summary>
    ///     Returns order confirmation draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>InvoiceishDraftResult</returns>
    InvoiceishDraftResult GetOrderConfirmationDraft(long? draftId);

    /// <summary>
    ///     Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetOrderConfirmationDraftAttachments(long? draftId);

    /// <summary>
    ///     Returns all order confirmation drafts for given company.
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
    List<InvoiceishDraftResult> GetOrderConfirmationDrafts(int? page, int? pageSize);

    /// <summary>
    ///     Returns all order confirmations for given company
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
    /// <returns>List&lt;OrderConfirmation&gt;</returns>
    List<OrderConfirmation> GetOrderConfirmations(int? page, int? pageSize);

    /// <summary>
    ///     Updates order confirmation draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdateOrderConfirmationDraft(InvoiceishDraftRequest body, string companySlug, long? draftId);
}