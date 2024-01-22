using Frank.Libraries.Xml.Internals;
using TestingInfrastructure.Models;
using Xunit.Abstractions;

namespace Frank.Libraries.Xml.Tests;

public class InternalXmlSerializerTests
{
    private readonly ITestOutputHelper _outputHelper;

    public InternalXmlSerializerTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void SerializeTest()
    {
        // Arrange
        var xmlTestModel = new XmlTestModel
        {
            Name = "Frank",
            DateOfBirth = new DateTime(1990, 1, 1),
            Salary = 1000,
            Id = Guid.NewGuid()
        };

        // Act
        var xml = InternalSerializer.Serialize(xmlTestModel);
        _outputHelper.WriteLine(xml);

        var deserializedXmlTestModel = InternalSerializer.Deserialize<XmlTestModel>(xml);

        // Assert
        Assert.NotNull(xml);
        Assert.NotNull(deserializedXmlTestModel);
        Assert.Equal(xmlTestModel.Name, deserializedXmlTestModel.Name);
        Assert.Equal(xmlTestModel.DateOfBirth, deserializedXmlTestModel.DateOfBirth);
    }

    public class XmlTestModel
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public Guid Id { get; set; }
    }
}