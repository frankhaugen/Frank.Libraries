using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOffersClient
{
    /// <summary>
    ///  Creates and adds a new attachment to an offer draft
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <param name="filename"></param>
    /// <param name="comment"></param>
    /// <param name="file"></param>
    /// <returns></returns>
    void AddAttachmentToOfferDraft(long? draftId, string filename, string comment, byte[] file);

    /// <summary>
    ///  Creates an offer draft.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateOfferDraft(InvoiceishDraftRequest body, string companySlug);

    /// <summary>
    ///  Creates an offer from an already created draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void CreateOfferFromDraft(long? draftId);

    /// <summary>
    ///  Delete offer draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void DeleteOfferDraft(long? draftId);

    /// <summary>
    ///  Returns offer with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="offerId">The offerId (primary key of the returned object) is returned as the first field in the GET all offers call </param>
    /// <returns>Offer</returns>
    Offer GetOffer(string offerId);

    /// <summary>
    ///  Returns offer draft with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>InvoiceishDraftResult</returns>
    InvoiceishDraftResult GetOfferDraft(long? draftId);

    /// <summary>
    ///  Returns all attachments for specified draft.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns>List&lt;Attachment&gt;</returns>
    List<Attachment> GetOfferDraftAttachments(long? draftId);

    /// <summary>
    ///  Returns all offer drafts for given company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;InvoiceishDraftResult&gt;</returns>
    List<InvoiceishDraftResult> GetOfferDrafts(int? page, int? pageSize);

    /// <summary>
    ///  Returns all offers for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;Offer&gt;</returns>
    List<Offer> GetOffers(int? page, int? pageSize);

    /// <summary>
    ///  Updates offer draft with provided id.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="draftId">The draftId (primary key of the returned object) is returned in the GET all drafts call. </param>
    /// <returns></returns>
    void UpdateOfferDraft(InvoiceishDraftRequest body, string companySlug, long? draftId);
}