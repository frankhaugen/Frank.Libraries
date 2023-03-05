using System.Collections.Generic;
using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList;

public class Embedded
{
    [JsonProperty("enheter")] public List<Company.Company>? Companies { get; set; }
}