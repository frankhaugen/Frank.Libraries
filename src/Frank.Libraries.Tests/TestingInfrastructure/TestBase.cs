using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ConsoleTableExt;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.TestingInfrastructure;

public abstract class TestBase
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly DirectoryInfo _solutionDirectory;

    protected TestBase(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;

        var currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
        _solutionDirectory = currentDirectory.Parent?.Parent?.Parent?.Parent ?? currentDirectory;
    }

    protected void Output(FileInfo fileInfo, string text) => File.WriteAllText(fileInfo.FullName, text);

    protected DirectoryInfo SolutionDirectory() => _solutionDirectory;

    protected void Output(string text) => _outputHelper.WriteLine(text);

    protected void Output<T>(IEnumerable<T> values) where T : class
    {
        var list = new List<T>();
        if (values != null && values.Any())
        {
            list.AddRange(values);
        }

        var table = ConsoleTableBuilder.From(list)
                                       .WithFormat(ConsoleTableBuilderFormat.Minimal)
                                       .Export()
                                       .ToString();

        _outputHelper.WriteLine(table);
    }

    protected void Output(object value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions { WriteIndented = true }));

    protected void Output<T>(T value) => _outputHelper.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions { WriteIndented = true }));
}