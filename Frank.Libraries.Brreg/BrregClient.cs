using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Frank.Libraries.Brreg
{
    public class BrregClient
    {
        private string BrregUrl(long organizationNumber) => $"https://data.brreg.no/enhetsregisteret/api/enheter/{organizationNumber}";

        public async Task<Company> GetCompanyAsync(long organizationNumber)
        {
            var url = new Url(BrregUrl(organizationNumber));

            if (!url.IsValid())
            {
                throw new ArgumentException("Invalid value: 'organizationNumber'");
            }

            return await url.GetJsonAsync<Company>();
        }
    }
}
