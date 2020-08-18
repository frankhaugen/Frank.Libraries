using Frank.Libraries.Json;
using Frank.Libraries.MongoDb;
using Frank.Libraries.Worker.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.Worker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddLogging();
                    services.AddJsonRepository<User, JsonSettings>(hostContext.Configuration);
                    services.AddMongoDbRepository<Car, MongoSettings>(hostContext.Configuration);
                    services.AddHostedService<FileShareClientTester>();
                });
    }
}