using System;
using Frank.Libraries.Logging.Shared;

namespace Frank.Libraries.Logging.Http;

public class HttpLoggerConfiguration : LoggerConfigurationBase
{
    public Uri Endpoint { get; set; }
}