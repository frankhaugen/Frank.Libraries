using System.IO;
using System.Linq;
using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Internet.Xkcd;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using NJsonSchema.CodeGeneration.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NSwag;
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
    public async Task Something2()
    {
        var document = await OpenApiDocument.FromUrlAsync("https://esi.evetech.net/latest/swagger.json");
        var @namespace = "EveOnlineApi";
        var settings = new CSharpClientGeneratorSettings()
        {
	        ClassName = "Test",
	        WrapResponses = false,
	        GenerateDtoTypes = true,
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

        var outputDirectory = new DirectoryInfo(Path.Combine(@"C:\repos\frankhaugen\Frank.Libraries\src\Frank.Libraries.Gaming\Engine", @namespace));
        if (!outputDirectory.Exists)
        {
	        outputDirectory.Create();
        }

        var generator = new CSharpClientGenerator(document, settings);
        var text = generator.GenerateFile();
        //var text = File.ReadAllText(@"C:\temp\SwaggerGeneratedCode.txt");

        var syntaxTree = CSharpSyntaxTree.ParseText(text);
        var root = syntaxTree.GetRoot() as CompilationUnitSyntax;
        var namespaceSyntax = root.Members.OfType<NamespaceDeclarationSyntax>().First();
        var classes = namespaceSyntax.Members.OfType<ClassDeclarationSyntax>();
        var records = namespaceSyntax.Members.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax>();
        var enums = namespaceSyntax.Members.OfType<EnumDeclarationSyntax>();

        //var classesDictionary = classes.ToDictionary(x => x.Identifier.ToString(), x => x);
        //var recordsDictionary = records.ToDictionary(x => x.Identifier.ToString(), x => x);
        //var enumsDictionary = enums.ToDictionary(x => x.Identifier.ToString(), x => x);

        foreach (var element in classes)
        {
	        var outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + ".cs");
	        var outputFile = new FileInfo(outputPath);

	        if (outputFile.Exists)
	        {
		        outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + "X" + ".cs");
		        outputFile = new FileInfo(outputPath);
	        }

            _outputHelper.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");
	        if (outputFile.Exists) continue;

        //	Console.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");
        //	File.WriteAllText(outputFile.FullName, $"namespace {namespaceSyntax.Name};\n" + element.ToFullString().Replace(" partial ", " "));
        }
        foreach (var element in records)
        {
	        var outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + ".cs");
	        var outputFile = new FileInfo(outputPath);

	        if (outputFile.Exists)
	        {
		        outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + "X" + ".cs");
		        outputFile = new FileInfo(outputPath);
	        }
            _outputHelper.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");

	        if (outputFile.Exists) continue;

        //	Console.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");
        //	File.WriteAllText(outputFile.FullName, $"namespace {namespaceSyntax.Name};\n" + element.ToFullString().Replace(" partial ", " "));
        }
        foreach (var element in enums)
        {
	        var outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + ".cs");
	        var outputFile = new FileInfo(outputPath);

	        if (outputFile.Exists)
	        {
		        outputPath = Path.Combine(outputDirectory.FullName, element.Identifier.ToString() + "X" + ".cs");
		        outputFile = new FileInfo(outputPath);
	        }

            _outputHelper.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");
	        if (outputFile.Exists) continue;
        //	Console.WriteLine($"{element.Identifier.ToString()}\t=>\t{outputFile.Name}");
        //	File.WriteAllText(outputFile.FullName, $"namespace {namespaceSyntax.Name};\n" + element.ToFullString().Replace(" partial ", " "));
        }
    }

    // [Fact]
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

    // [Fact]
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
