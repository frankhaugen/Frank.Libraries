using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInvoicesClient
{
    /// <summary>
    ///  Creates and adds a new attachment to an Invoice
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="invoiceId">The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber </param>
    /// <param name="filename"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToInvoice(long? invoiceId, string filename, byte[] file);

    /// <summary>
    ///  Creates and adds a new attachment to an invoice draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="comment"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToInvoiceDraft(long? draftId, string filename, string comment, byte[] file);

    /// <summary>
    ///  Creates an invoice. There are two types of invoice lines that can be added to an invoice line: product line or free text line. Provide a product Id if you are invoicing a product. All information regarding the price and VAT for this product will be added to the invoice. It is however also possible to override the unit amount by sending information in both fields \&quot;productId\&quot; and \&quot;unitAmount\&quot;. An invoice line can also be a free text line meaning that no existing product will be associated with the invoiced line. In this case all information regarding the price and VAT of the product or service to be invoiced must be provided.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateInvoice(InvoiceRequest body, string companySlug);

    /// <summary>
    ///  Creates an invoice draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateInvoiceDraft(InvoiceishDraftRequest body, string companySlug);

    /// <summary>
    ///  Creates an invoice from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreateInvoiceFromDraft(long? draftId);

    /// <summary>
    ///  Delete invoice draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeleteInvoiceDraft(long? draftId);

    /// <summary>
    ///  Returns invoice with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="invoiceId">The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber </param>
    /// <returns>InvoiceResult</returns>
    InvoiceResult GetInvoice(long? invoiceId);

    /// <summary>
    ///  Returns all attachments for a given Invoice
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="invoiceId">The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetInvoiceAttachments(long? invoiceId);

    /// <summary>
    ///  Returns invoice draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>InvoiceishDraftResult</returns>
    InvoiceishDraftResult GetInvoiceDraft(long? draftId);

    /// <summary>
    ///  Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetInvoiceDraftAttachments(long? draftId);

    /// <summary>
    ///  Returns all invoice drafts for given company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="orderReference">Filter based on order reference for a given invoice</param>
    /// <returns>List&lt;InvoiceishDraftResult&gt;</returns>
    List<InvoiceishDraftResult> GetInvoiceDrafts(int? page, int? pageSize, string orderReference);

    /// <summary>
    ///  Returns all invoices for given company. You can filter based on issue date, last modified date, customer ID, and if the invoice is settled or not.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="issueDate">Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="issueDateLe">Filter based on date less than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="issueDateLt">Filter based on date strictly less than parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="issueDateGe">Filter based on date greater than or equal to parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="issueDateGt">Filter based on date strictly greater than parameter value Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModified">Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedLe">Returns results that have been last modified before or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedLt">Returns results that have been last modified strictly before the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedGe">Returns results that have been last modified after or on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModifiedGt">Returns results that have been last modified strictly after the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="customerId">Returns only invoices sent to specified customer. Must be the contactId provided by a GET contacts call. </param>
    /// <param name="settled">When set to true, returns only invoices that have been settled. Otherwise false returns all invoices that have not been fully settled. </param>
    /// <param name="orderReference">Filter based on order reference for a given invoice</param>
    /// <param name="invoiceDraftUuid">Filter based on the UUID of the invoice draft that was used to create a given invoice</param>
    /// <returns>List&lt;InvoiceResult&gt;</returns>
    List<InvoiceResult> GetInvoices(int? page, int? pageSize, DateTime? issueDate, DateTime? issueDateLe, DateTime? issueDateLt, DateTime? issueDateGe, DateTime? issueDateGt, DateTime? lastModified, DateTime? lastModifiedLe, DateTime? lastModifiedLt, DateTime? lastModifiedGe, DateTime? lastModifiedGt, long? customerId, bool? settled, string orderReference, Guid? invoiceDraftUuid);

    /// <summary>
    ///  Sends the specified document
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void SendInvoice(SendInvoiceRequest body, string companySlug);

    /// <summary>
    ///  Updates invoice with provided id. It is possible to update the due date of an invoice as well as if the invoice was sent manually, outside of Fiken.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="invoiceId">The invoiceId (primary key of the returned object) is returned in the GET all invoices call; not to be confused with invoiceNumber </param>
    /// <returns></returns>
    void UpdateInvoice(UpdateInvoiceRequest body, string companySlug, long? invoiceId);

    /// <summary>
    ///  Updates invoice draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdateInvoiceDraft(InvoiceishDraftRequest body, string companySlug, long? draftId);
}