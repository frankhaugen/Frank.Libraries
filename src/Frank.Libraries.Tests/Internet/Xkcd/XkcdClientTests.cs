using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Internet.Xkcd;
using System.Threading.Tasks;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration;
using NSwag.CodeGeneration.CSharp;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Internet.Xkcd;

public class XkcdClientTests
{
    private readonly ITestOutputHelper _outputHelper;

    public XkcdClientTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public async Task Something()
    {
        // Arrange
        var @namespace = "EveOnlineApi";
        var document = await OpenApiDocument.FromUrlAsync("https://esi.evetech.net/latest/swagger.json");
        var settings = new CSharpClientGeneratorSettings()
        {
            ClassName = "Test",
            WrapResponses = false,
            GenerateDtoTypes = false,
            GenerateExceptionClasses = false,
            WrapDtoExceptions = false,
            GenerateClientClasses = false,
            GenerateOptionalParameters = true,
            CSharpGeneratorSettings =
            {
                Namespace = @namespace,
                ClassStyle = CSharpClassStyle.Record,
                ArrayType = "IList",
                JsonLibrary = CSharpJsonLibrary.SystemTextJson,
                GenerateNativeRecords = true,
                GenerateDefaultValues = false,
                GenerateNullableReferenceTypes = true,
                GenerateDataAnnotations = false
            }
        };
        var generator = new CSharpClientGenerator(document, settings);

        // Act
        var result = generator.GenerateFile();

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task GetComicTest()
    {
        // Arrange
        const int id = 0;

        // Act
        var result = await XkcdClient.GetComicAsync(id);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task GetComicImageTest()
    {
        // Arrange
        const int id = 0;

        // Act
        var result = await XkcdClient.GetComicImageAsync(id);

        // Assert
        _outputHelper.WriteLine(result);
        result.ToString().Should().NotBeNullOrEmpty();
    }
}
