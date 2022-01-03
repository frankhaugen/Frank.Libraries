using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FluentAssertions;
using Frank.Libraries.Csv;
using Frank.Libraries.Extensions;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Csv;

public class CsvContextTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CsvContextTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _sutCsvContext = new CsvContext();
    }

    private readonly CsvContext _sutCsvContext;


    [Fact]
    public async Task HasHeaderTest()
    {
        // Arrange
        var file = default(FileInfo);
        var delimiter = "";
        var newline = "";
        var hasheaderrecord = true;

        // Act
        var result = _sutCsvContext.HasHeader<Person, PersonClassMap>(file, delimiter, newline, hasheaderrecord);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task ReadTest1()
    {
        // Arrange
        var file = default(FileInfo);
        var delimiter = default(String);
        var newLine = default(String);
        var hasHeaderRecord = default(Boolean);

        // Act
        var result = _sutCsvContext.Read<Person, PersonClassMap>(file, delimiter, newLine, hasHeaderRecord);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task ReadTest2()
    {
        // Arrange
        var text = default(String);
        var delimiter = default(String);
        var newLine = default(String);
        var hasHeaderRecord = default(Boolean);

        // Act
        var result = _sutCsvContext.Read<Person, PersonClassMap>(text, delimiter, newLine, hasHeaderRecord);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task WriteTest()
    {
        // Arrange
        var file = default(FileInfo);
        var records = new List<Person>();
        var delimiter = "default(String)";
        var newLine = "default(String)";
        var hasHeaderRecord = true;

        // Act
        _sutCsvContext.Write<Person, PersonClassMap>(file, records, delimiter, newLine, hasHeaderRecord);

        // Assert
        //_outputHelper.WriteLine(result);
        //result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task AppendTest()
    {
        // Arrange
        var file = default(FileInfo);
        var records = default(List<Person>);
        var delimiter = default(String);
        var newLine = default(String);
        var hasHeaderRecord = default(Boolean);

        // Act
        _sutCsvContext.Append<Person, PersonClassMap>(file, records, delimiter, newLine, hasHeaderRecord);

        // Assert
        //_outputHelper.WriteLine(result);
        //result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task GetTemplateTest()
    {
        // Arrange
        var delimiter = "default(String)";
        var newLine = "default(String)";
        var hasHeaderRecord = true;

        // Act
        var result = _sutCsvContext.GetTemplate<Person, PersonClassMap>(delimiter, newLine, hasHeaderRecord);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    // [Fact]
    public async Task GetTypeTest()
    {
        // Arrange

        // Act
        var result = _sutCsvContext.GetType();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
