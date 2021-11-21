using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoBogus;
using FluentAssertions;
using Frank.Libraries.MongoDb;
using Frank.Libraries.Tests.TestingInfrastructure.Configuration;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Microsoft.Extensions.Options;
using Mongo2Go;
using MongoDB.Bson;
using MongoDB.Driver;
using Xunit;

namespace Frank.Libraries.Tests.MongoDb
{
    public class MongoDbRepositoryTests
    {
        private MongoDbRepository<MongoTestModel> SetupRepository(MongoDbRunner runner)
        {
            MongoClient client = new MongoClient(runner.ConnectionString);
            var database = client.GetDatabase(nameof(MongoDbRepositoryTests));

            var dbContext = new MongoDbContext<TestMongoConfiguration>(Options.Create(new TestMongoConfiguration() { ConnectionString = runner.ConnectionString, DatabaseName = nameof(MongoDbRepositoryTests) }));
            var mongoDbRepository = new MongoDbRepository<MongoTestModel>(dbContext);
            return mongoDbRepository;
        }

        [Fact]
        public async Task AsQueryable()
        {
            // Arrange
            using var runner = MongoDbRunner.Start();
            var repository = SetupRepository(runner);
            var newItems = CreateTestDocuments();
            await repository.InsertManyAsync(newItems);
            var firstItem = newItems.First();

            // Act
            var result = repository.AsQueryable();

            // Assert
            result.Should()
                  .NotBeNullOrEmpty();
            result.Should()
                  .HaveSameCount(newItems);
            result.FirstOrDefault(x => x.Name == firstItem.Name)
                  .Should()
                  .BeEquivalentTo(firstItem, options => options.Excluding(x => x.DateOfBirth));
        }

        [Fact]
        public async Task FindById_OneValue_ReturnsCorrectValue()
        {
            // Arrange
            using var runner = MongoDbRunner.Start();
            var repository = SetupRepository(runner);
            var newItem = CreateTestDocument();
            await repository.InsertOneAsync(newItem);

            // Act
            var result = await repository.FindByIdAsync(newItem.Id);

            // Assert
            result.Should()
                  .NotBeNull();
            result.Name.Should()
                  .Be(newItem.Name);
            result.DateOfBirth.Should()
                  .BeCloseTo(newItem.DateOfBirth, TimeSpan.FromHours(13));
            result.YearlySalary.Should()
                  .Be(newItem.YearlySalary);
        }

        [Fact]
        public async Task Insert()
        {
            // Arrange
            using var runner = MongoDbRunner.Start();
            var repository = SetupRepository(runner);
            var newItem = CreateTestDocument();

            // Act
            await repository.InsertOneAsync(newItem);

            // Assert
            (await repository.FindByIdAsync(newItem.Id)).Should()
                                                        .NotBeNull();
        }

        [Fact]
        public async Task FilterBy()
        {
            // Arrange
            using var runner = MongoDbRunner.Start();
            var repository = SetupRepository(runner);
            var newItem = CreateTestDocument();

            // Act
            await repository.InsertOneAsync(newItem);

            // Assert
            repository.FilterBy(x => x.Name.Contains(newItem.Name, StringComparison.InvariantCultureIgnoreCase))
                      .Should()
                      .NotBeNull();
        }

        private MongoTestModel CreateTestDocument() => new AutoFaker<MongoTestModel>().RuleFor(x => x.Id, ObjectId.GenerateNewId())
                                                                                      .Generate();

        private List<MongoTestModel> CreateTestDocuments(int count = 10)
        {
            var documents = new List<MongoTestModel>();
            for (var i = 0; i < count; i++)
            {
                documents.Add(CreateTestDocument());
            }

            return documents;
        }
    }
}