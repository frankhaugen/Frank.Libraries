using System;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Internet.Wikipedia.Models.Related
{
    public class Page
    {
        [JsonPropertyName("pageid")]
        public int Pageid { get; set; }

        [JsonPropertyName("ns")]
        public int Ns { get; set; }

        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("displaytitle")]
        public string Displaytitle { get; set; }

        [JsonPropertyName("namespace")]
        public Namespace Namespace { get; set; }

        [JsonPropertyName("wikibase_item")]
        public string WikibaseItem { get; set; }

        [JsonPropertyName("titles")]
        public Titles Titles { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("originalimage")]
        public Originalimage Originalimage { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("dir")]
        public string Dir { get; set; }

        [JsonPropertyName("revision")]
        public string Revision { get; set; }

        [JsonPropertyName("tid")]
        public string Tid { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("description_source")]
        public string DescriptionSource { get; set; }

        [JsonPropertyName("content_urls")]
        public ContentUrls ContentUrls { get; set; }

        [JsonPropertyName("extract")]
        public string Extract { get; set; }

        [JsonPropertyName("extract_html")]
        public string ExtractHtml { get; set; }

        [JsonPropertyName("normalizedtitle")]
        public string Normalizedtitle { get; set; }

        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}