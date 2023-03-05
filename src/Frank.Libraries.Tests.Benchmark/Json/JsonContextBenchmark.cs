using System;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using AutoBogus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using Frank.Libraries.Json;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Tests.Benchmark.Json;

[MemoryDiagnoser]
[ShortRunJob]
[RPlotExporter]
public class JsonContextBenchmark
{
    private const string TestFolder = "c:/tests";
    private readonly IFileSystem _fileSystem;
    private readonly Guid _guid = Guid.NewGuid();
    private JsonContext<JsonTestModel> _jsonContext;

    public JsonContextBenchmark()
    {
        _fileSystem = new FileSystem();

        if (!Directory.Exists(TestFolder))
        {
            Directory.CreateDirectory(TestFolder);
        }
    }

    [Params(100000)] public int Records { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var entities = new AutoFaker<JsonTestModel>().Generate(Records);

        _jsonContext = new JsonContext<JsonTestModel>(Options.Create(new JsonConfiguration { Folder = Path.Combine(TestFolder, _guid.ToString()) }), _fileSystem);
        _jsonContext.Add(entities);
        _jsonContext.SaveChanges();
    }

    [Benchmark]
    public void GetList()
    {
        var result = _jsonContext.GetList();
    }

    [Benchmark]
    public void GetCollection()
    {
        var result = _jsonContext.GetCollection();
        var list = result.ToList();
    }

    [Benchmark]
    public void GetQueryable()
    {
        var result = _jsonContext.GetQueryable();
        var list = result.ToList();
    }

    [GlobalCleanup]
    public void Teardown()
    {
        var directory = new DirectoryInfo(Path.Combine(TestFolder, _guid.ToString()));

        var files = directory.EnumerateFiles();

        ConsoleLogger.Default.WriteLine(LogKind.Default, "Filesize:"
                                                         + files.Select(x => x.Length)
                                                                .Sum()
                                                                .ToString("N"));

        foreach (var fileInfo in files)
        {
            fileInfo.Delete();
        }

        if (directory.Exists)
        {
            directory.Delete();
        }
    }
}