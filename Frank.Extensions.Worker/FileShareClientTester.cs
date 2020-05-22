using Frank.Extensions.AzureStorage.FileShare;
using Frank.Extensions.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Extensions.Worker
{
    public class FileShareClientTester : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var fileShareClient = new FileShareClient(Options.Create(
                new FileShareConfiguration()
                {
                    ConnectionString = "",
                    ShareName = ""
                }));

            var items = fileShareClient.FileItems;

            Console.WriteLine(items.Select(x => x.Name).ToJson());
        }
    }
}