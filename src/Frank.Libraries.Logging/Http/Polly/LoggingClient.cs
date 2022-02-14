using System;
using RestSharp;

namespace Frank.Libraries.Logging.Http.Polly;

public class LoggingClient : RestClient
{
    public LoggingClient(Uri url) : base(url)
    {
        
    }
}