using System.Globalization;
using Frank.Libraries.CodeGeneration.SyntaxFactories;

namespace Frank.Libraries.CodeGeneration.Generators.Enums;

public class CultureEnumGenerator : IEnumGenerator
{
    private readonly IEnumMemberGenerator _memeberGenerator;

    public CultureEnumGenerator()
    {
        _memeberGenerator = new EnumMemberGenerator();
    }

    public EnumDeclarationSyntax Generate(string enumName)
    {
        var cultures = GetCultures();
        var members = cultures.Select(x => _memeberGenerator.Generate(x.TwoLetterISOLanguageName, GetAttributes(x), GetXmlComments(x)));
        var enumDeclaration = SyntaxFactory.EnumDeclaration(enumName)
                                           .WithMembers(SyntaxFactory.SeparatedList(members));
        return enumDeclaration;
    }

    private IEnumerable<SyntaxTrivia> GetXmlComments(CultureInfo cultureInfo)
    {
        var xmlComments = new List<SyntaxTrivia>
        {
            XmlDocSyntaxFactory.SingleLineSummaryComment(cultureInfo.EnglishName)
        };

        return xmlComments;
    }


    private static IEnumerable<AttributeSyntax> GetAttributes(CultureInfo cultureInfo)
    {
        var attributes = new List<AttributeSyntax>
        {
            SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Flags"))
        };
        return attributes;
    }

    private static IEnumerable<CultureInfo> GetCultures()
    {
        var cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                                  .DistinctBy(x => x.TwoLetterISOLanguageName);
        return cultures;
    }
}