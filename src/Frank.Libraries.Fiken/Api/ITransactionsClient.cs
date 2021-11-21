using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ITransactionsClient
{
    /// <summary>
    ///  Returns given transaction with associated id. Transaction id is returned in GET calls for sales, purchases, and journal entries.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="transactionId"></param>
    /// <returns>Transaction</returns>
    Transaction GetTransaction(string companySlug, long? transactionId);
}