using AutoBogus;
using FluentAssertions;
using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Frank.Libraries.Tests.Json
{
    public class JsonRepositoryTests
    {
        private const string TestFolder = "c:/tests";

        private JsonRepository<JsonTestModel> SetupRepository(Guid sessionId)
        {
            var context = new JsonContext<JsonTestModel>(Options.Create(new JsonConfiguration() { Folder = Path.Combine(TestFolder, sessionId.ToString()) }));
            var jsonRepository = new JsonRepository<JsonTestModel>(context);

            return jsonRepository;
        }

        void Teardown(Guid sessionId)
        {
            var directory = new DirectoryInfo(Path.Combine(TestFolder, sessionId.ToString()));

            var files = directory.EnumerateFiles();

            foreach (var fileInfo in files)
            {
                fileInfo.Delete();
            }

            directory.Delete();
        }

        [Fact]
        public async Task DiscardChangesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();
            await jsonRepository.AddAsync(entity);
            jsonRepository.PendingChanges.Should().BeTrue();

            // Act
            await jsonRepository.DiscardChangesAsync();

            // Assert
            jsonRepository.PendingChanges.Should().BeFalse();
            Teardown(sessionId);
        }

        [Fact]
        public async Task SaveChangesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();
            await jsonRepository.AddAsync(entity);
            jsonRepository.PendingChanges.Should().BeTrue();

            // Act
            await jsonRepository.SaveChangesAsync();
            var result = await jsonRepository.GetAsync();

            // Assert
            jsonRepository.PendingChanges.Should().BeFalse();
            result.Should().NotBeNullOrEmpty();
            Teardown(sessionId);
        }

        [Fact]
        public async Task GetAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();
            await jsonRepository.AddAsync(entity);
            jsonRepository.PendingChanges.Should().BeTrue();
            await jsonRepository.SaveChangesAsync();
            jsonRepository.PendingChanges.Should().BeFalse();

            // Act
            var result = await jsonRepository.GetAsync();

            // Assert
            result.Should().Contain(entity);
            Teardown(sessionId);
        }

        [Fact]
        public async Task AddAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();

            // Act
            await jsonRepository.AddAsync(entity);
            await jsonRepository.SaveChangesAsync();
            var result = await jsonRepository.GetByIdAsync(entity.Id);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(entity);
            Teardown(sessionId);
        }

        [Fact]
        public async Task AddAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entities = new AutoFaker<JsonTestModel>().Generate(5);

            // Act
            await jsonRepository.AddAsync(entities);
            await jsonRepository.SaveChangesAsync();
            var result = await jsonRepository.GetAsync();

            // Assert
            result.Should().HaveSameCount(entities);
            result.Should().Contain(entities);
            Teardown(sessionId);
        }

        [Fact]
        public async Task UpdateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entityId = Guid.NewGuid();
            var original = new AutoFaker<JsonTestModel>().RuleFor(x => x.Id, entityId).Generate();
            var entity = new AutoFaker<JsonTestModel>().RuleFor(x => x.Id, entityId).Generate();
            await jsonRepository.AddAsync(original);
            await jsonRepository.SaveChangesAsync();

            // Act
            await jsonRepository.UpdateAsync(entityId, entity);

            // Assert
            Assert.True(true);
            Teardown(sessionId);
        }

        [Fact]
        public async Task RemoveAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();
            await jsonRepository.AddAsync(entity);
            await jsonRepository.SaveChangesAsync();

            // Act
            await jsonRepository.RemoveAsync(entity.Id);

            // Assert
            Assert.True(true);
            Teardown(sessionId);
        }

        [Fact]
        public async Task RemoveAsync_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonRepository = SetupRepository(sessionId);
            var entities = new AutoFaker<JsonTestModel>().Generate(10); ;

            // Act
            await jsonRepository.RemoveAsync(entities);

            // Assert
            Assert.True(true);
            Teardown(sessionId);
        }
    }
}
