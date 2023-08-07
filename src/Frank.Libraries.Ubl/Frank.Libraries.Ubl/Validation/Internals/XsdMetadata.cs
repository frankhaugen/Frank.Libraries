using System.Xml;
using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation.Internals;

public class XsdMetadata
{
    public XsdMetadata(AssemblyResourceFile resourceFile)
    {
        if (Path.GetExtension(resourceFile.Name) != ".xsd")
            throw new ArgumentException($"File must be an XSD file: {resourceFile.Name}", nameof(resourceFile));
        ResourceFile = resourceFile;

        // var xsdResolver = new XsdResolver();
        var xsdResolver = new ManifestXmlUrlResolver();
        var xmlReaderSettings = new XmlReaderSettings()
            { XmlResolver = xsdResolver, DtdProcessing = DtdProcessing.Parse };

        using var reader = XmlReader.Create(ResourceFile.Stream, xmlReaderSettings);
        var schema = XmlSchema.Read(reader, (s, e) => throw new XsdException(s, e));

        Schema = schema ?? throw new InvalidOperationException($"Could not read XSD file: {resourceFile.Name}");

        Namespace = XmlSchema.Namespace;
    }

    public AssemblyResourceFile ResourceFile { get; }

    public string Namespace { get; }

    public XmlSchema Schema { get; }
}