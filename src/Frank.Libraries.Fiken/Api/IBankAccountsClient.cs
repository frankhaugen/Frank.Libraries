using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBankAccountsClient
{
    /// <summary>
    ///  Creates a new bank account. The Location response header returns the URL of the newly created bank account. Possible types of bank accounts are NORMAL, TAX_DEDUCTION, FOREIGN, and CREDIT_CARD. The field \&quot;foreignService\&quot; should only be filled out for accounts of type FOREIGN.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateBankAccount(BankAccountRequest body, string companySlug);

    /// <summary>
    ///  Retrieves specified bank account.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="bankAccountId"></param>
    /// <returns>BankAccountResult</returns>
    BankAccountResult GetBankAccount(string companySlug, long? bankAccountId);

    /// <summary>
    ///  Retrieves all bank accounts associated with the company.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;BankAccountResult&gt;</returns>
    List<BankAccountResult> GetBankAccounts(string companySlug, int? page, int? pageSize);
}