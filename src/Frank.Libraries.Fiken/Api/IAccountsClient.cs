using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAccountsClient
{
    /// <summary>
    ///  Retrieves the specified bookkeping account. An account is a string with either four digits, or four digits, a colon and five digits (\&quot;reskontro\&quot;).       Examples:       3020 and 1500:10001
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="accountCode">Code number of the bookkeeping account to retrieve for the current year.</param>
    /// <returns>Account</returns>
    Account GetAccount(string companySlug, string accountCode);

    /// <summary>
    ///  Retrieves the specified bookkeping account and balance for a given date.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="accountCode">Code number of the bookkeeping account to retrieve</param>
    /// <param name="date">Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <returns>AccountBalance</returns>
    AccountBalance GetAccountBalance(string companySlug, string accountCode, DateTime? date);

    /// <summary>
    ///  Retrieves the bookkeeping accounts and balances for a given date. An account is a string with either four digits, or four digits, a colon and five digits (\&quot;reskontro\&quot;). Examples: 3020 and 1500:10001
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="date">Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="fromAccount">Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).</param>
    /// <param name="toAccount">Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;AccountBalance&gt;</returns>
    List<AccountBalance> GetAccountBalances(string companySlug, DateTime? date, long? fromAccount, long? toAccount, int? page, int? pageSize);

    /// <summary>
    ///  Retrieves the bookkeeping accounts for the current year
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="fromAccount">Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).</param>
    /// <param name="toAccount">Filter parameter specifying which account numbers to return. Specify using the from and to parameters (excluding subaccount).</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <returns>List&lt;Account&gt;</returns>
    List<Account> GetAccounts(string companySlug, long? fromAccount, long? toAccount, int? page, int? pageSize);
}