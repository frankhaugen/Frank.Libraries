using Frank.Libraries.Json;
using Frank.Libraries.Tests.TestInfrastructure.Models;
using Frank.Libraries.Xml;
using Microsoft.Extensions.Options;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class XmlContextTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public XmlContextTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void GetCollection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var xmlContext = new XmlContext<XmlTestModel>(Options.Create(new XmlConfiguration()));

            // Act
            //var result = xmlContext.GetCollection();
            xmlContext.Add(new XmlTestModel()
            {
                Name = "My Name",
                DateOfBirth = DateTime.UtcNow,
                Salary = 100000
            });

            xmlContext.SaveChanges();
            _outputHelper.WriteLine(xmlContext.GetCollection().ToJson());

            // Assert
            Assert.True(true);
        }
    }
}