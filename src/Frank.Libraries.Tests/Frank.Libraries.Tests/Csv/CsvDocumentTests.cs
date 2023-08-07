using System.Data;
using Frank.Libraries.Csv;
using Frank.Libraries.Extensions;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Csv;

public class CsvDocumentTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CsvDocumentTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void ParseCsv_ValidInput_CorrectOutput()
    {
        // Arrange
        var csvOptions = new CsvOptions()
        {
            HasHeader = true,
            ColumnCount = 3,
        };
        string csvString =
            """"
            Id;Name;Age
            1;"Frank R.
            Haugen";30
            2;"John";40
            """";

        var parser = new CsvParser(csvOptions);

        // Act
        var result = parser.Parse("Test", csvString);

        // Assert
        _outputHelper.WriteLine("Source:");
        _outputHelper.WriteLine(csvString);
        _outputHelper.WriteLine("");
        _outputHelper.WriteLine("Result:");
        foreach (var row in result)
        {
            _outputHelper.WriteLine(row.ConcatWith(csvOptions.Delimiter).ReplaceLineEndings(""));
        }
        _outputHelper.WriteLine(result.ToString());
    }
}