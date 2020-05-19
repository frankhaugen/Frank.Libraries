using Frank.Extensions.Json;
using Frank.Extensions.Logging;
using Frank.Extensions.MongoDb;
using Frank.Extensions.Worker.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Frank.Extensions.Worker
{
    public class Program
    {
        private static string connectionString;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LoggingDemo;Integrated Security=SSPI;";

                    services.AddJsonRepository<User, JsonSettings>(hostContext.Configuration);
                    services.AddMongoDbRepository<Car, MongoSettings>(hostContext.Configuration);
                    //services.AddHostedService<MongoDbRepositoryTester>();
                    //services.AddLogging(builder =>
                    //{
                    //    connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LoggingDemo;Integrated Security=SSPI;";
                    //    //builder.AddSqlLogger(connectionString);
                    //});
                    //services.AddHostedService<JsonRepositoryTester>();
                    services.AddHostedService<LoggingTester>();
                }).ConfigureLogging(builder => builder.AddProvider(new SqlLoggerProvider(connectionString)));
    }
}