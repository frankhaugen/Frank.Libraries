using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IProductsClient
{
    /// <summary>
    ///  Creates a new product.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns></returns>
    void CreateProduct(Product body, string companySlug);

    /// <summary>
    ///  Creates a report based on provided specifications.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <returns>List&lt;ProductSalesReportResult&gt;</returns>
    List<ProductSalesReportResult> CreateProductSalesReport(ProductSalesReportRequest body, string companySlug);

    /// <summary>
    ///  Delete product with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="productId">The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. </param>
    /// <returns></returns>
    void DeleteProduct(long? productId);

    /// <summary>
    ///  Returns product with specified id.
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="productId">The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. </param>
    /// <returns>Product</returns>
    Product GetProduct(long? productId);

    /// <summary>
    ///  Returns all products for given company
    /// </summary>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="page">Returns the number of the page to return. Valid page values are integers from 0 to the total number of pages. Default value is 0. </param>
    /// <param name="pageSize">Defines the number of entries to return on each page. Maximum number of results that can be returned at one time are 100. Default value is 25. </param>
    /// <param name="createdDate">Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="lastModified">Filter based on date of last modification. Returns results that were last modified on the date provided as a parameter value. Dates are represented as strings formatted as YYYY-MM-DD. Example: January 1st, 1970: \&quot;1970-01-01\&quot; </param>
    /// <param name="name">Find all results with product name equal to the specified parameter.</param>
    /// <param name="productNumber">Find all results with product number (varenummer) equal to the specified parameter.</param>
    /// <param name="active">Returns active (true) or inactive (false) products.</param>
    /// <returns>List&lt;Product&gt;</returns>
    List<Product> GetProducts(int? page, int? pageSize, DateTime? createdDate, DateTime? lastModified, string name, string productNumber, bool? active);

    /// <summary>
    ///  Updates an existing product.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="companySlug">Slug of company to retrieve</param>
    /// <param name="productId">The productId (primary key of the returned object) is returned in the GET all products call; not to be confused with productNumber. </param>
    /// <returns></returns>
    void UpdateProduct(Product body, string companySlug, long? productId);
}