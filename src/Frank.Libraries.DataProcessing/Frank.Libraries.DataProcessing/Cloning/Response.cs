using System.Net;

namespace Frank.Libraries.DataProcessing.Cloning;

public class Response
{
    public string Content { get; set; }
    public bool IsSuccessStatusCode { get; set; }
    public string ReasonPhrase { get; set; }
    public HttpStatusCode StatusCode { get; set; }
}