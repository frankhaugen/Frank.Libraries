using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISalesClient
{
    /// <summary>
    ///     Creates and adds a new attachment to a Sale
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <param name="filename"></param>
    /// <param name="attachToPayment"></param>
    /// <param name="attachToSale"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToSale(long? saleId, string filename, bool? attachToPayment, bool? attachToSale, byte[] file);

    /// <summary>
    ///     Creates and adds a new attachment to a draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToSaleDraft(long? draftId, string filename, byte[] file);

    /// <summary>
    ///     Creates a new sale.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateSale(SaleRequest body, string companySlug);

    /// <summary>
    ///     Creates a sale draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateSaleDraft(DraftRequest body, string companySlug);

    /// <summary>
    ///     Creates a sale from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreateSaleFromDraft(long? draftId);

    /// <summary>
    ///     Creates a new payment for a given sale.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <returns></returns>
    void CreateSalePayment(Payment body, string companySlug, long? saleId);

    /// <summary>
    ///     Sets the deleted flag for a sale. The sale is not deleted, but a reverse transaction is created and the \&quot;
    ///     deleted\&quot; property is set to true.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <param name="description">Required description for deleting the sale</param>
    /// <returns>SaleResult</returns>
    SaleResult DeleteSale(long? saleId, string description);

    /// <summary>
    ///     Delete draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeleteSaleDraft(long? draftId);

    /// <summary>
    ///     Returns sale with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <returns>SaleResult</returns>
    SaleResult GetSale(long? saleId);

    /// <summary>
    ///     Returns all attachments for specified sale.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetSaleAttachments(long? saleId);

    /// <summary>
    ///     Returns draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>DraftResult</returns>
    DraftResult GetSaleDraft(long? draftId);

    /// <summary>
    ///     Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetSaleDraftAttachments(long? draftId);

    /// <summary>
    ///     Returns all sale drafts for given company.
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
    /// <returns>List&lt;DraftResult&gt;</returns>
    List<DraftResult> GetSaleDrafts(int? page, int? pageSize);

    /// <summary>
    ///     Returns payment with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <param name="paymentId"></param>
    /// <returns>Payment</returns>
    Payment GetSalePayment(long? saleId, long? paymentId);

    /// <summary>
    ///     Returns all payments for given sale
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="saleId"></param>
    /// <returns>List&lt;Payment&gt;</returns>
    List<Payment> GetSalePayments(long? saleId);

    /// <summary>
    ///     Returns all sales for given company
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
    /// <param name="lastModified">
    ///     Filter based on date of last modification. Returns results that were last modified on the
    ///     date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st,
    ///     1970: \&quot;1970-01-01\&quot;
    /// </param>
    /// <param name="lastModifiedLe">
    ///     Returns results that have been last modified before or on the date provided as a parameter
    ///     value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\
    ///     &quot;
    /// </param>
    /// <param name="lastModifiedLt">
    ///     Returns results that have been last modified strictly before the date provided as a
    ///     parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;
    ///     1970-01-01\&quot;
    /// </param>
    /// <param name="lastModifiedGe">
    ///     Returns results that have been last modified after or on the date provided as a parameter
    ///     value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\
    ///     &quot;
    /// </param>
    /// <param name="lastModifiedGt">
    ///     Returns results that have been last modified strictly after the date provided as a
    ///     parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;
    ///     1970-01-01\&quot;
    /// </param>
    /// <param name="saleNumber">Find all results with the sale number equal to the specified parameter.</param>
    /// <returns>List&lt;SaleResult&gt;</returns>
    List<SaleResult> GetSales(int? page, int? pageSize, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, string saleNumber);

    /// <summary>
    ///     Updates draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdateSaleDraft(DraftRequest body, string companySlug, long? draftId);
}