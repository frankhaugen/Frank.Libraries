using AutoBogus;
using FluentAssertions;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Frank.Libraries.Xml;
using Microsoft.Extensions.Options;
using Xunit;

namespace Frank.Libraries.Tests.Xml;

public class XmlContextTests
{
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
        result.FirstOrDefault(x => x.Name == testModel.Name)
              .Should()
              .NotBeNull();
    }

    [Fact]
    public void Add_AddingMany_ManyAdded()
    {
        // Arrange
        var xmlContext = new XmlContext<XmlTestModel>(Options.Create(new XmlConfiguration()));
        var testModels = CreateTestModels();

        // Act
        xmlContext.Add(testModels);
        xmlContext.SaveChanges();
        var result = xmlContext.GetCollection();

        // Assert
        result.FirstOrDefault()
              .Should()
              .NotBeNull();
        result.Should()
              .Contain(testModels);
    }

    private XmlTestModel CreateTestModel() => new AutoFaker<XmlTestModel>().Generate();
    private List<XmlTestModel> CreateTestModels(int count = 10) => new AutoFaker<XmlTestModel>().Generate(count);
}