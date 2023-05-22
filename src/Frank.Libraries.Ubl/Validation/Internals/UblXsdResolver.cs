using System.Reflection;
using System.Xml;

namespace Frank.Libraries.Ubl.Validation.Internals;

internal class UblXsdResolver : XmlUrlResolver
{
    private readonly Assembly _assembly;
    private readonly IEnumerable<string> _fileNames;

    public UblXsdResolver()
    {
        _assembly = typeof(XsdMetadata).Assembly;
        _fileNames = _assembly.GetManifestResourceNames();
    }

    public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
    {
        var xsdResourceAssembly = typeof(UblXsdResolver).Assembly;

        if (absoluteUri.IsFile && absoluteUri.Segments.Length >= 2)
        {
            var resourceName = _fileNames.FirstOrDefault(x =>
                                                             x.EndsWith(absoluteUri.Segments[^1]
                                                                                   .Trim('/'), StringComparison.Ordinal));

            var manifestStream = xsdResourceAssembly.GetManifestResourceStream(resourceName);
            if (manifestStream == null)
            {
                return base.GetEntity(absoluteUri, role, ofObjectToReturn);
            }

            return manifestStream;
        }

        return base.GetEntity(absoluteUri, role, ofObjectToReturn);
    }
}