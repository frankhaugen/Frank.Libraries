using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Frank.Libraries.Xml;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Xml;

public class XmlSerializerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public XmlSerializerTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void SerializeTest()
    {
        // Arrange
        var xmlSerializer = new XmlSerializer();
        var xmlTestModel = new XmlTestModel
        {
            Name = "Frank",
            DateOfBirth = new DateTime(1990, 1, 1),
            Salary = 1000,
            Id = Guid.NewGuid()
        };

        // Act
        var xml = xmlSerializer.Serialize(xmlTestModel);
        _outputHelper.WriteLine(xml);

        var deserializedXmlTestModel = xmlSerializer.Deserialize<XmlTestModel>(xml);

        // Assert
        Assert.NotNull(xml);
        Assert.NotNull(deserializedXmlTestModel);
        Assert.Equal(xmlTestModel.Name, deserializedXmlTestModel.Name);
        Assert.Equal(xmlTestModel.DateOfBirth, deserializedXmlTestModel.DateOfBirth);
    }
}