using System.Xml.Schema;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.Validation.Internals;

internal static class XsdMetadataExtensions
{
    public static XmlSchemaSet ToSchemaSet(this IEnumerable<XsdMetadata> xsdMetadata)
    {
        var xsdResolver = new ManifestXmlUrlResolver();
        // var xsdResolver = new XsdResolver();
        var schemaSet = new XmlSchemaSet()
        {
            XmlResolver = xsdResolver,
            CompilationSettings = { EnableUpaCheck = false }
        };

        foreach (var metadata in xsdMetadata)
        {
            schemaSet.Add(metadata.Schema);
        }

        return schemaSet;
    }

    public static XmlSchemas ToSchemas(this IEnumerable<XsdMetadata> xsdMetadata)
    {
        var schemas = new XmlSchemas();

        foreach (var metadata in xsdMetadata)
        {
            schemas.Add(metadata.Schema);
        }

        return schemas;
    }
}