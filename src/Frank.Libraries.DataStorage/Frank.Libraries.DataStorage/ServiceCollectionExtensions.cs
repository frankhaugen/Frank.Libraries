using Frank.Libraries.DataStorage.Csv;
using Frank.Libraries.DataStorage.Json;
using Frank.Libraries.DataStorage.LiteDb;
using Frank.Libraries.DataStorage.MongoDb;
using Frank.Libraries.DataStorage.Sqlite;
using Frank.Libraries.DataStorage.Xml;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.DataStorage;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJsonDataStorage<T>(this IServiceCollection services, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(JsonConnection));
        connectionString ??= Path.Combine(AppContext.BaseDirectory, "JsonData");
        services.AddSingleton<IOptions<JsonConnection>>(Options.Create(new JsonConnection { JsonDataFolder = connectionString }));
        services.AddSingleton<JsonContext>();
        services.AddSingleton<IRepository<T>, JsonRepository<T>>();
        return services;
    }

    public static IServiceCollection AddSqliteDataStorage<T>(this IServiceCollection services, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(SqliteConnection));
        connectionString ??= "Data Source=Frank.Libraries.DataStorage.db;";
        services.AddSingleton<IOptions<SqliteConnection>>(Options.Create<SqliteConnection>(new SqliteConnection { ConnectionString = connectionString }));
        services.AddSingleton<ISqliteClient, SqliteClient>();
        services.AddSingleton<IRepository<T>, SqliteRepository<T>>();
        return services;
    }

    public static IServiceCollection AddXmlDataStorage<T>(this IServiceCollection services, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(XmlConnection));
        connectionString ??= Path.Combine(AppContext.BaseDirectory, "XmlData");
        services.AddSingleton<IOptions<XmlConnection>>(Options.Create(new XmlConnection { XmlDataFile = connectionString }));
        services.AddSingleton<XmlDataContext>();
        services.AddSingleton<IRepository<T>, XmlRepository<T>>();
        return services;
    }

    public static IServiceCollection AddLiteDbDataStorage<T>(this IServiceCollection services, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(LiteDbConnection));
        connectionString ??= Path.Combine(AppContext.BaseDirectory, "LiteDbData", "Storage.db");
        services.AddSingleton<IOptions<LiteDbConnection>>(Options.Create(new LiteDbConnection { LiteDbDataFile = connectionString }));
        services.AddSingleton<LiteDbDataContext>();
        services.AddSingleton<IRepository<T>, LiteDbRepository<T>>();
        return services;
    }

    public static IServiceCollection AddCsvDataStorage<T>(this IServiceCollection services, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(CsvConnection));
        connectionString ??= Path.Combine(AppContext.BaseDirectory, "CsvData");
        services.AddSingleton<IOptions<CsvConnection>>(Options.Create(new CsvConnection { CsvDataFolder = connectionString }));
        services.AddSingleton<CsvDocument<T>>();
        services.AddSingleton<IRepository<T>, CsvRepository<T>>();
        return services;
    }

    public static IServiceCollection AddMongoDbDataStorage<T>(this IServiceCollection services, string databaseName, IConfiguration configuration) where T : class, IKeyed, new()
    {
        var connectionString = configuration.GetConnectionString(nameof(MongoDbConnection));
        connectionString ??= "mongodb://localhost:27017";
        services.AddSingleton<IOptions<MongoDbConnection>>(Options.Create(new MongoDbConnection { ConnectionString = connectionString, DatabaseName = databaseName }));
        services.AddSingleton<MongoDbContext>();
        services.AddSingleton<IRepository<T>, MongoDbRepository<T>>();
        return services;
    }
}