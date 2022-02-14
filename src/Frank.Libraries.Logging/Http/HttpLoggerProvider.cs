using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Logging.Http
{
    public class HttpLoggerProvider : HttpLoggerProviderBase
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly HttpLoggerConfiguration _configuration;

        public HttpLoggerProvider(IServiceProvider serviceProvider, IOptions<HttpLoggerConfiguration> options)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            // FlurlHttp.Configure(settings => settings.HttpClientFactory = new PollyHttpClientFactory());
            _configuration = options.Value;
        }

        public override ILogger CreateLogger(string categoryName) => new HttpLogger(_serviceProvider, _configuration, categoryName);
    }
}