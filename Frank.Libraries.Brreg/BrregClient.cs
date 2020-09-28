using Flurl;
using Flurl.Http;
using System;
using System.Threading.Tasks;

namespace Frank.Libraries.Brreg
{
    public class BrregClient
    {
        private readonly string _baseUrl = "https://data.brreg.no/enhetsregisteret/api";

        private string BrregUnitsUrl() => $"{_baseUrl}/enheter";

        //private string BrregSearchUrl(string name, string town, int currentPage, int pageSize) => $"{_baseUrl}/enheter?navn={name}&postadresse.poststed={town}&page={currentPage}&size={pageSize}";

        public async Task<Company> GetCompanyAsync(long organizationNumber)
        {
            var url = new Url(BrregUnitsUrl());

            url.AppendPathSegment(organizationNumber);

            if (organizationNumber <= 0 || !url.IsValid())
            {
                throw new ArgumentException("Invalid value: 'organizationNumber'");
            }

            return await url.GetJsonAsync<Company>();
        }

        public async Task<CompaniesList> SearchForLegalEntityAsync(string companyName, string town, int currentPage = 0, int pageSize = 20)
        {

            var url = new Url(BrregUnitsUrl());

            if (!string.IsNullOrWhiteSpace(companyName))
                url.QueryParams.Add("navn", companyName);
            if (!string.IsNullOrWhiteSpace(town))
                url.QueryParams.Add("postadresse.poststed", town);

            url.QueryParams.Add("page", currentPage);
            url.QueryParams.Add("size", pageSize);

            if (!url.IsValid())
            {
                throw new ArgumentException("Bad url");
            }

            return await url.GetJsonAsync<CompaniesList>();
        }
    }
}
