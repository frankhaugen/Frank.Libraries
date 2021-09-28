using System;
using System.IO;
using System.IO.Abstractions;
using AutoBogus;
using FluentAssertions;
using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Microsoft.Extensions.Options;
using Xunit;

namespace Frank.Libraries.Tests.Json
{
    public class JsonContextTests
    {
        private const string TestFolder = "c:/tests";
        //private readonly MockFileSystem _mockFileSystem;
        private readonly IFileSystem _mockFileSystem;

        public JsonContextTests()
        {
            _mockFileSystem = new FileSystem();

            if (!Directory.Exists(TestFolder))
            {
                Directory.CreateDirectory(TestFolder);
            }
        }

        private JsonContext<JsonTestModel> Setup(Guid sessionId)
        {
            return new JsonContext<JsonTestModel>(Options.Create(new JsonConfiguration() { Folder = Path.Combine(TestFolder, sessionId.ToString()) }), _mockFileSystem);
        }

        void Teardown(Guid sessionId)
        {
            var directory = new DirectoryInfo(Path.Combine(TestFolder, sessionId.ToString()));

            var files = directory.EnumerateFiles();

            foreach (var fileInfo in files)
            {
                fileInfo.Delete();
            }

            if (directory.Exists)
            {
                directory.Delete();
            }
        }

        [Fact]
        public void GetCollection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);
            var entities = new AutoFaker<JsonTestModel>().Generate(10);
            jsonContext.Add(entities);
            jsonContext.SaveChanges();

            // Act
            var result = jsonContext.GetCollection();

            // Assert
            result.Should().NotBeNullOrEmpty();
            Teardown(sessionId);
        }

        [Fact]
        public void GetQueryable_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);
            var entities = new AutoFaker<JsonTestModel>().Generate(10);
            jsonContext.Add(entities);
            jsonContext.SaveChanges();

            // Act
            var result = jsonContext.GetQueryable();

            // Assert
            result.Should().NotBeNullOrEmpty();
            Teardown(sessionId);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);
            var entity = new AutoFaker<JsonTestModel>().Generate();

            // Act
            jsonContext.Add(entity);

            // Assert
            Teardown(sessionId);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);
            var entities = new AutoFaker<JsonTestModel>().Generate(10);

            // Act
            jsonContext.Add(entities);

            // Assert
            Teardown(sessionId);
        }

        [Fact]
        public void SaveChanges_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);

            // Act
            var result = jsonContext.SaveChanges();

            // Assert
            result.Should().BeTrue();
            Teardown(sessionId);
        }

        [Fact]
        public void DiscardChanges_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionId = Guid.NewGuid();
            var jsonContext = Setup(sessionId);

            // Act
            jsonContext.DiscardChanges();

            // Assert
            Teardown(sessionId);
        }

        //[Fact]
        //public async Task GetJsonDataAsync_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var jsonContext = new JsonContext(TODO);
        //    string? folderName = null;

        //    // Act
        //    var result = await jsonContext.GetJsonDataAsync(
        //        folderName);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public async Task SaveJsonDataAsync_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var jsonContext = new JsonContext(TODO);
        //    IEnumerable records = null;
        //    string folderName = null;
        //    bool indented = false;

        //    // Act
        //    await jsonContext.SaveJsonDataAsync(
        //        records,
        //        folderName,
        //        indented);

        //    // Assert
        //    Assert.True(false);
        //}
    }
}
