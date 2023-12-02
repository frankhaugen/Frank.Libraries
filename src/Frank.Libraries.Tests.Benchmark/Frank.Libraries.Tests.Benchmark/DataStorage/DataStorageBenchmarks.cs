using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using Frank.Libraries.DataStorage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Tests.Benchmark.DataStorage;

[ShortRunJob]
[MinColumn, MaxColumn, MeanColumn, MedianColumn]
[MemoryDiagnoser]
[ThreadingDiagnoser]
[ExceptionDiagnoser]
[EventPipeProfiler(EventPipeProfile.Jit | EventPipeProfile.CpuSampling | EventPipeProfile.GcVerbose)]
[EtwProfiler]
[NativeMemoryProfiler]
[InliningDiagnoser(true, true)]
[IterationCount(100)]
public class DataStorageBenchmarks
{
    private readonly IRepository<CsvExampleClass> _csvRepository;
    private readonly IRepository<JsonExampleClass> _jsonRepository;
    private readonly IRepository<XmlExampleClass> _xmlRepository;
    private readonly IRepository<SqliteExampleClass> _sqliteRepository;
    private readonly IRepository<LiteDbExampleClass> _liteDbRepository;

    public DataStorageBenchmarks()
    {
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("ConnectionStrings:SqliteConnection", "Data Source=Frank.Libraries.Tests.Benchmark.db;"),
                new KeyValuePair<string, string>("ConnectionStrings:JsonConnection", Path.Combine(AppContext.BaseDirectory, "JsonData")),
                new KeyValuePair<string, string>("ConnectionStrings:XmlConnection", Path.Combine(AppContext.BaseDirectory, "XmlData", "Storage.xml")),
                // new KeyValuePair<string, string>("ConnectionStrings:LiteDbConnection", Path.Combine(AppContext.BaseDirectory, "LiteDbData", "Storage.db")),
                new KeyValuePair<string, string>("ConnectionStrings:CsvConnection", Path.Combine(AppContext.BaseDirectory, "CsvData")),
            }!)
            .Build();

        var serviceCollection = new ServiceCollection()
            .AddSqliteDataStorage<SqliteExampleClass>(configuration)
            .AddLiteDbDataStorage<LiteDbExampleClass>(configuration)
            .AddJsonDataStorage<JsonExampleClass>(configuration)
            .AddXmlDataStorage<XmlExampleClass>(configuration)
            .AddCsvDataStorage<CsvExampleClass>(configuration);

        var serviceProvider = serviceCollection.BuildServiceProvider(new ServiceProviderOptions() { ValidateOnBuild = true, ValidateScopes = true });

        _csvRepository = serviceProvider.GetRequiredService<IRepository<CsvExampleClass>>();
        _jsonRepository = serviceProvider.GetRequiredService<IRepository<JsonExampleClass>>();
        _xmlRepository = serviceProvider.GetRequiredService<IRepository<XmlExampleClass>>();
        _sqliteRepository = serviceProvider.GetRequiredService<IRepository<SqliteExampleClass>>();
        _liteDbRepository = serviceProvider.GetRequiredService<IRepository<LiteDbExampleClass>>();
    }

    [GlobalSetup]
    public void Setup()
    {
    }

    // [Benchmark] public void AddSqliteItems() => AddItems(_sqliteRepository);

    // [Benchmark] public void AddCsvItems() => AddItems(_csvRepository);

    // [Benchmark] public void AddJsonItems() => AddItems(_jsonRepository);

    [Benchmark] public void AddXmlItems() => AddItems(_xmlRepository);

    // [Benchmark] public void AddLiteDbItems() => AddItems(_liteDbRepository);

    // [Benchmark] public void GetSqliteItems() => _sqliteRepository.GetAll().ToList();

    // [Benchmark] public void GetCsvItems() => _csvRepository.GetAll().ToList();

    // [Benchmark] public void GetJsonItems() => _jsonRepository.GetAll().ToList();

    [Benchmark] public void GetXmlItems() => _xmlRepository.GetAll().ToList();

    // [Benchmark] public void GetLiteDbItems() => _liteDbRepository.GetAll().ToList();

    private void AddItems<T>(IRepository<T> repository) where T : ExampleClass, new()
    {
        var testData1 = new T { Id = Guid.NewGuid(), SomeData = "Test1", DateTime = new DateTime(2021, 1, 1), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };
        var testData2 = new T { Id = Guid.NewGuid(), SomeData = "Test2", DateTime = new DateTime(2021, 1, 1), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };
        var testData3 = new T { Id = Guid.NewGuid(), SomeData = "Test3", DateTime = new DateTime(2021, 1, 1), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };
        var testData4 = new T { Id = Guid.NewGuid(), SomeData = "Test4", DateTime = new DateTime(2021, 1, 1), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };
        var testData5 = new T { Id = Guid.NewGuid(), SomeData = "Test5", DateTime = new DateTime(2021, 1, 1), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };

        repository.Add(testData1);
        repository.Add(testData2);
        repository.Add(testData3);
        repository.Add(testData4);
        repository.Add(testData5);
        repository.SaveChanges();
    }
}

public class JsonExampleClass : ExampleClass { }

public class SqliteExampleClass : ExampleClass { }

public class XmlExampleClass : ExampleClass { }

public class LiteDbExampleClass : ExampleClass { }

public class CsvExampleClass : ExampleClass { }

public class ExampleClass : IKeyed
{
    public Guid Id { get; set; }
    public string SomeData { get; set; }
    public int Int { get; set; }
    public long Long { get; set; }
    public float Float { get; set; }
    public double Double { get; set; }
    public decimal Decimal { get; set; }
    public DateTime DateTime { get; set; }
    public DateTimeOffset DateTimeOffset { get; set; }
    public TimeSpan TimeSpan { get; set; }
    public bool Boolean { get; set; }
}