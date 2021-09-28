using Newtonsoft.Json;
using System.Collections.Generic;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList
{
    public class Embedded
    {
        [JsonProperty("enheter")]
        public List<Company.Company>? Companies { get; set; }
    }
}
