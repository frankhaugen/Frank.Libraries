using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Frank.Extensions.WebApi.Controllers
{
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/test")]
        public async Task<IActionResult> Get()
        {
            for (int i = 0; i < 100; i++)
            {
                _logger.LogInformation(new ArithmeticException(), "This is a logging test");
                await Task.Delay(TimeSpan.FromSeconds(5));
            }

            return Ok();
        }
    }
}