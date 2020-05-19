using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Extensions.Worker
{
    public class LoggingTester : BackgroundService
    {
        private readonly ILogger _logger;

        public LoggingTester(ILogger logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation(new AmbiguousImplementationException(), "A simple message");
                await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
            }
        }
    }
}