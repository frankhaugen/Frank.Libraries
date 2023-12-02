using FluentAssertions;
using FluentAssertions.Extensions;
using Frank.Libraries.DataStorage.Csv;
using Frank.Libraries.DataStorage.MongoDb;
using Frank.Libraries.DataStorage.Tests.Shared;
using Microsoft.Extensions.Options;
using Mongo2Go;
using Xunit.Abstractions;

namespace Frank.Libraries.DataStorage.Tests.Repositories;

public class MongoDbRepositoryTests
{
    private readonly ITestOutputHelper _outputHelper;

    public MongoDbRepositoryTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

    [Fact]
    public void Test_CsvRepository_Operations()
    {
        // Arrange
        // Here we are assuming that JsonTable and JsonContext classes are something like this:
        using var runner = MongoDbRunner.Start();
        var context = new MongoDbContext(Options.Create<MongoDbConnection>(new MongoDbConnection() { ConnectionString = runner.ConnectionString, DatabaseName = "ExampleClass" }));
        var repository = new MongoDbRepository<ExampleClass>(context);

        var testData1 = new ExampleClass { Id = Guid.NewGuid(), SomeData = "Test1", DateTime = new DateTime(2021, 1, 1).AsUtc(), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };
        var testData2 = new ExampleClass { Id = Guid.NewGuid(), SomeData = "Test2", DateTime = new DateTime(2021, 1, 1).AsUtc(), DateTimeOffset = new DateTimeOffset(2021, 1, 1, 1, 1, 1, TimeSpan.Zero), TimeSpan = new TimeSpan(1, 2, 3), Boolean = true };

        // Act: Add some items to the repository
        repository.Add(testData1);
        repository.Add(testData2);

        // Assert
        // Check that the items exist in the repository
        var item1 = repository.GetById(testData1.Id);
        item1.Should()
             .NotBeNull();
        item1.Should()
             .BeEquivalentTo(testData1);

        var item2 = repository.GetById(testData2.Id);
        item2.Should()
             .NotBeNull();
        item2.Should()
             .BeEquivalentTo(testData2);

        // Act: Remove an item from the repository
        repository.Delete(testData1.Id);

        // Assert
        // Check that the item does not exist in the repository
        item1 = repository.GetById(testData1.Id);
        item1.Should()
             .BeNull();
    }
}