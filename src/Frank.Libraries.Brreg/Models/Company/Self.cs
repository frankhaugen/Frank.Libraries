using System;
using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Company;

public class Self
{
    [JsonProperty("href")] public Uri? Href { get; set; }
}