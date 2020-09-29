using AutoBogus;
using FluentAssertions;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Frank.Libraries.Xml;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Xml
{
    public class XmlContextTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public XmlContextTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void GetCollection()
        {
            // Arrange
            var xmlContext = new XmlContext<XmlTestModel>(Options.Create(new XmlConfiguration()));
            var testModel = CreateTestModel();

            // Act
            xmlContext.Add(testModel);
            xmlContext.SaveChanges();
            var result = xmlContext.GetCollection();

            // Assert
            result.FirstOrDefault(x => x.Name == testModel.Name).Should().NotBeNull();
        }

        [Fact]
        public void Add_AddingMany_ManyAdded()
        {
            // Arrange
            var xmlContext = new XmlContext<XmlTestModel>(Options.Create(new XmlConfiguration()));
            var testModel = CreateTestModel();

            // Act
            xmlContext.Add(testModel);
            xmlContext.SaveChanges();
            var result = xmlContext.GetCollection();

            // Assert
            result.FirstOrDefault(x => x.Name == testModel.Name).Should().NotBeNull();
        }

        private XmlTestModel CreateTestModel() => new AutoFaker<XmlTestModel>().Generate();
        private List<XmlTestModel> CreateTestModels(int count = 10) => new AutoFaker<XmlTestModel>().Generate(count);
    }
}
