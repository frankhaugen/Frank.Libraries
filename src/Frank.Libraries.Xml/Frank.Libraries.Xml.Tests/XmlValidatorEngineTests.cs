using Frank.Libraries.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace Frank.Libraries.Xml.Tests;

public class XmlValidatorEngineTests
{
    private readonly ITestOutputHelper _outputHelper;

    public XmlValidatorEngineTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void ValidateTest()
    {
        // Arrange
        var xml = """
                  <?xml version="1.0" encoding="utf-8"?>
                  <XmlTestModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                      <Id>00000000-0000-0000-0000-000000000000</Id>
                      <Name>Frank</Name>
                      <DateOfBirth>1990-01-01T00:00:00</DateOfBirth>
                      <Salary>1000</Salary>
                  </XmlTestModel>
                  """;
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IXmlValidatorEngine, XmlValidatorEngine>();
        serviceCollection.AddSingleton<IXmlValidator, XDocumentValidator>();

        var serviceProvider = serviceCollection.BuildServiceProvider(new ServiceProviderOptions() {ValidateOnBuild = true, ValidateScopes = true});
        var service = serviceProvider.GetRequiredService<IXmlValidatorEngine>();

        // Act
        var result = service.IsValid(xml, out var errors);

        // Assert
        if (result != true)
        {
            _outputHelper.WriteTable(errors ?? new List<XmlValidationError>());
        }

        Assert.True(result);
        Assert.Null(errors);
    }
}