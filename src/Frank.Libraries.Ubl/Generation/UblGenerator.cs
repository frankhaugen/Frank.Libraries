using System.CodeDom;
using System.CodeDom.Compiler;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.Generation;

public class CSharpGenerator
{
    private readonly XmlSchemas _xmlSchemas;

    public CSharpGenerator(XmlSchemas xmlSchemas)
    {
        _xmlSchemas = xmlSchemas;
    }

    public string Generate(XmlQualifiedName name)
    {
        var importer = new XmlSchemaImporter(_xmlSchemas);
        var mapping = importer.ImportTypeMapping(name);
        var codeTypeDeclaration = new CodeTypeDeclaration(name.Name);

        codeTypeDeclaration.BaseTypes.Add(mapping.TypeName);

        codeTypeDeclaration.IsClass = true;

        var codeNamespace = new CodeNamespace(name.Namespace);
        var codeCompileUnit = new CodeCompileUnit();
        codeCompileUnit.Namespaces.Add(codeNamespace);

        var codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

        // codeDomProvider.GenerateCodeFromExpression();
        var stringBuilder = new StringBuilder();
        using (var streamWriter = new StringWriter(stringBuilder))
        {
            codeDomProvider.GenerateCodeFromCompileUnit(codeCompileUnit, streamWriter, new CodeGeneratorOptions());
        }

        return stringBuilder.ToString();
    }

}

