using System.Xml;
using Frank.Libraries.Ubl.Generation;
using Frank.Libraries.Ubl.Validation.Internals;
using TestingInfrastructure;
using Xunit.Abstractions;

namespace Frank.Libraries.Ubl.Tests.CodeGeneration;

public class CSharpGeneratorTests : TestBase
{
    private readonly CSharpGenerator Generator;
    private readonly XsdManifest Manifest = new();

    public CSharpGeneratorTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
        var schemas = Manifest.XsdMetadata.Values.ToSchemas();
        Generator = new CSharpGenerator(schemas);
    }

    [Fact]
    public void Generate()
    {
        var qualifiedName = new XmlQualifiedName("Invoice", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
        var result = Generator.Generate(qualifiedName);

        Output(result);

        Assert.NotNull(result);
    }
}