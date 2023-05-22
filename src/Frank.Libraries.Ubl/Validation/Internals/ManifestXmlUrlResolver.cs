using System.Reflection;
using System.Xml;

namespace Frank.Libraries.Ubl.Validation.Internals;

public class ManifestXmlUrlResolver : XmlUrlResolver
{
    private readonly Assembly _assembly;
    private readonly IEnumerable<string> _fileNames;

    public ManifestXmlUrlResolver()
    {
        _assembly = typeof(XsdMetadata).Assembly;
        _fileNames = _assembly.GetManifestResourceNames();
    }

    public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
    {
        var resourceName =
            _fileNames.FirstOrDefault(x => x.EndsWith(absoluteUri.Segments[^1].Trim('/'), StringComparison.Ordinal));

        using var stream = _assembly.GetManifestResourceStream(resourceName);

        if (stream == null)
            throw new FileNotFoundException($"Resource {resourceName} not found in assembly {_assembly.FullName}");

        if (ofObjectToReturn == typeof(Stream))
            return stream;

        if (ofObjectToReturn == typeof(XmlReader))
            return XmlReader.Create(stream);


        var memoryStream = new MemoryStream();

        stream.CopyTo(memoryStream);

        return memoryStream;
    }
}