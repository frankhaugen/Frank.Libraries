using AutoBogus;
using Bogus;
using Bogus.DataSets;
using FluentAssertions;
using TestingInfrastructure.Models;
using Xunit.Abstractions;

namespace Frank.Libraries.Extensions.Tests;

public class DataTableExtensionsTests
{
    private readonly Faker _faker;
    private readonly ITestOutputHelper _outputHelper;

    public DataTableExtensionsTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _faker = new Faker();
    }

    [Fact]
    public void ToEnumerable()
    {
        // Arrange
        var items = CreateTestModels<TestDocument>(2);
        var dataTable = items.ToDataTable();

        // Act
        var result = dataTable.ToEnumerable<TestDocument>();

        // Assert
        var testDocuments = result.ToList();
        testDocuments.Should()
                     .BeEquivalentTo(items);
        testDocuments.Should()
                     .HaveSameCount(items);
    }

    [Fact]
    public void Pivot()
    {
        // Arrange
        var items = CreateTestModels<Currency>();
        var dataTable = items.ToDataTable();

        // Act
        var result = dataTable.Pivot(dataTable.Columns[1], dataTable.Columns[2]);
        _outputHelper.WriteTable(result.ToEnumerable<Currency>());

        // Assert
        _faker.Name.Locale.Should()
              .NotBeEmpty();
    }

    private List<T> CreateTestModels<T>(int count = 10) where T : class => new AutoFaker<T>().Generate(count);
}