using System;
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

        public async Task<PaginatedResponse<CustomerBrregResponse>> SearchForLegalEntityAsync(PaginatedBrregSearch queryString)
        {

            var url = new Url(BrregSearchUrl(queryString.Name, queryString.Town, queryString.CurrentPage - 1, queryString.PageSize));
            var response = await url.GetJsonAsync<LegalEntityPaginated>();

            var paginated = new PaginatedResponse<CustomerBrregResponse>();

            //Mapp to CustomerBrregResponse
            var legalEntities = new List<CustomerBrregResponse>();
            if (response.Data != null)
            {
                foreach (var legalEntity in response.Data.LegalEntities)
                {
                    legalEntities.Add(new CustomerBrregResponse(legalEntity));
                }
            }

            paginated.Data = legalEntities;
            var meta = new PaginatedMeta();

            meta.PageSize = response.Page.size;
            meta.CurrentPage = response.Page.number + 1;
            meta.TotalCount = response.Page.totalElements;
            meta.TotalPages = response.Page.totalPages;

            paginated.Meta = meta;


            return paginated;
        }
    }
}
