using Frank.Extensions.Json;
using Frank.Extensions.MongoDb;
using Frank.Extensions.Worker.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Frank.Extensions.Worker
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
                    //services.AddHostedService<MongoDbRepositoryTester>();
                    //services.AddLogging(builder =>
                    //{
                    //    connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LoggingDemo;Integrated Security=SSPI;";
                    //    //builder.AddSqlLogger(connectionString);
                    //});
                    //services.AddHostedService<JsonRepositoryTester>();
                });
    }
}