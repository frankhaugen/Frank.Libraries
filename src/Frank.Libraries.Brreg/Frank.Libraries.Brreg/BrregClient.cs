using Flurl;
using Flurl.Http;
using Frank.Libraries.Brreg.Models.Company;
using Frank.Libraries.Brreg.Models.Responses.CompanyList;

namespace Frank.Libraries.Brreg;

public class BrregClient
{
    private readonly string _baseUrl = "https://data.brreg.no/enhetsregisteret/api";

    private string BrregUnitsUrl() => $"{_baseUrl}/enheter";

    public async Task<Company> GetCompanyAsync(long registrationNumber)
    {
        var url = new Url(BrregUnitsUrl());

        url.AppendPathSegment(registrationNumber);

        if (registrationNumber <= 0)
        {
            throw new ArgumentException("Invalid value: 'organizationNumber'", nameof(registrationNumber));
        }

        if (url is null)
        {
            throw new ArgumentException($"Bad url: '{url}'", nameof(url));
        }

        return await url.GetJsonAsync<Company>();
    }

    public async Task<CompaniesList> SearchForLegalEntityAsync(string? companyName = null, string? town = null, int currentPage = 0, int pageSize = 20)
    {
        var url = new Url(BrregUnitsUrl());

        if (!string.IsNullOrWhiteSpace(companyName))
        {
            url.QueryParams.Add("navn", companyName);
        }

        if (!string.IsNullOrWhiteSpace(town))
        {
            url.QueryParams.Add("postadresse.poststed", town);
        }

        url.QueryParams.Add("page", currentPage);
        url.QueryParams.Add("size", pageSize);

        if (url is null)
        {
            throw new ArgumentException($"Bad url: '{url}'", nameof(url));
        }

        return await url.GetJsonAsync<CompaniesList>();
    }
}