using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Frank.Libraries.Brreg
{
    public class BrregClient
    {
        private string BrregUrl(long organizationNumber) => $"https://data.brreg.no/enhetsregisteret/api/enheter/{organizationNumber}";

        private string BrregSearchUrl(string name, string town, int currentPage, int pageSize) => $"https://data.brreg.no/enhetsregisteret/api/enheter?navn={name}&postadresse.poststed={town}&page={currentPage}&size={pageSize}";


        public async Task<Company> GetCompanyAsync(long organizationNumber)
        {
            var url = new Url(BrregUrl(organizationNumber));

            if (!url.IsValid())
            {
                throw new ArgumentException("Invalid value: 'organizationNumber'");
            }

            return await url.GetJsonAsync<Company>();
        }

        public async Task<CompaniesList> SearchForLegalEntityAsync(string companyName, string town, int currentPage = 0, int pageSize = 20)
        {

            var url = new Url(BrregSearchUrl(companyName, town, currentPage, pageSize));

            return await url.GetJsonAsync<CompaniesList>();
        }
    }
}
