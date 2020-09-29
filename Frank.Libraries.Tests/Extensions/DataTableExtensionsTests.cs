using AutoBogus;
using Bogus;
using ConsoleTableExt;
using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Testing.Models.Cars;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Extensions
{
    public class DataTableExtensionsTests
    {
        private readonly Faker _faker;
        private ITestOutputHelper _outputHelper;

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
            result.Should().BeEquivalentTo(items);
            result.Should().HaveSameCount(items);
        }

        [Fact]
        public void Pivot()
        {
            // Arrange
            var items = CreateTestModels<Engine>();
            var dataTable = items.ToDataTable();

            // Act
            var result = dataTable.Pivot(dataTable.Columns[1], dataTable.Columns[2]);
            var consoleTable = ConsoleTableBuilder.From(result);
            _outputHelper.WriteLine(consoleTable.Export().ToString());

            // Assert
        }

        private TestDocument CreateTestModel() => new AutoFaker<TestDocument>().Generate();
        private List<T> CreateTestModels<T>(int count = 10) where T : class => new AutoFaker<T>().Generate(count);
    }
}
