using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IPurchasesClient
{
    /// <summary>
    ///  Creates and adds a new attachment to a Purchase
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <param name="filename"></param>
    /// <param name="attachToPayment"></param>
    /// <param name="attachToSale"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToPurchase(long? purchaseId, string filename, bool? attachToPayment, bool? attachToSale, byte[] file);

    /// <summary>
    ///  Creates and adds a new attachment to a draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToPurchaseDraft(long? draftId, string filename, byte[] file);

    /// <summary>
    ///  Creates a new purchase.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreatePurchase(PurchaseRequest body, string companySlug);

    /// <summary>
    ///  Creates a purchase draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreatePurchaseDraft(DraftRequest body, string companySlug);

    /// <summary>
    ///  Creates a purchase from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreatePurchaseFromDraft(long? draftId);

    /// <summary>
    ///  Creates a new payment for a purchase
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <returns></returns>
    void CreatePurchasePayment(Payment body, string companySlug, long? purchaseId);

    /// <summary>
    ///  Sets the deleted flag for a purchase. The purchase is not deleted, but a reverse transaction is created and the \&quot;deleted\&quot; property is set to true.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <param name="description">Required description for deleting the purchase</param>
    /// <returns>PurchaseResult</returns>
    PurchaseResult DeletePurchase(long? purchaseId, string description);

    /// <summary>
    ///  Delete draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeletePurchaseDraft(long? draftId);

    /// <summary>
    ///  Returns purchase with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <returns>PurchaseResult</returns>
    PurchaseResult GetPurchase(long? purchaseId);

    /// <summary>
    ///  Returns all attachments for specified purchase.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetPurchaseAttachments(long? purchaseId);

    /// <summary>
    ///  Returns draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>DraftResult</returns>
    DraftResult GetPurchaseDraft(long? draftId);

    /// <summary>
    ///  Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetPurchaseDraftAttachments(long? draftId);

    /// <summary>
    ///  Returns all purchase drafts for given company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;DraftResult&gt;</returns>
    List<DraftResult> GetPurchaseDrafts(int? page, int? pageSize);

    /// <summary>
    ///  Returns given payment for specified purchase
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <param name="paymentId"></param>
    /// <returns>Payment</returns>
    Payment GetPurchasePayment(long? purchaseId, long? paymentId);

    /// <summary>
    ///  Returns all purchases for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="purchaseId"></param>
    /// <returns>List&lt;Payment&gt;</returns>
    List<Payment> GetPurchasePayments(long? purchaseId);

    /// <summary>
    ///  Returns all purchases for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="sortBy">Sorts results in either ascending (asc) or descending (desc) order based on the parameter value.</param>
    /// <returns>List&lt;PurchaseResult&gt;</returns>
    List<PurchaseResult> GetPurchases(int? page, int? pageSize, string sortBy);

    /// <summary>
    ///  Updates draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdatePurchaseDraft(DraftRequest body, string companySlug, long? draftId);
}