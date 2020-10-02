using Newtonsoft.Json;
using System;

namespace Frank.Libraries.Brreg.Models.Company
{
    public class Self
    {
        [JsonProperty("href")]
        public Uri? Href { get; set; }
    }
}
