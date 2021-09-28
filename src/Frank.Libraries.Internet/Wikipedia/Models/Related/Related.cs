using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class Related
    {
        [JsonPropertyName("pages")]
        public List<Page> Pages { get; set; }
    }
}