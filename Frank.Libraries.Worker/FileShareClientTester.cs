using Frank.Libraries.AzureStorage.FileShare;
using Frank.Libraries.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Libraries.Worker
{
    public class FileShareClientTester : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var fileShareClient = new FileShareClient(Options.Create(
                new FileShareConfiguration()
                {
                    ConnectionString =
                        "",
                    ShareName = ""
                }));

            var items = fileShareClient.FileItems;

            var first = items.FirstOrDefault();
            var download = await fileShareClient.DownloadAsync(first);

            await File.WriteAllBytesAsync($"C:/temp/downloadtest{first.Extension}", download, stoppingToken);

            Console.WriteLine(fileShareClient.DirectoryItems.ToJson());
        }
    }
}