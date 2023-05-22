using System.Reflection;
using System.Xml;

namespace Frank.Libraries.Ubl.Validation.Internals;

internal class XsdResolver : XmlUrlResolver
{
    private readonly Assembly _assembly;
    private readonly IEnumerable<string> _fileNames;

    public XsdResolver()
    {
        _assembly = typeof(XsdMetadata).Assembly;
        _fileNames = _assembly.GetManifestResourceNames();
    }

    public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
    {
        if (!absoluteUri.IsFile || absoluteUri.Segments.Length < 2)
            return base.GetEntity(absoluteUri, role, ofObjectToReturn);

        var documentName = "." + absoluteUri.Segments[^1].Trim('/');

        var fileName = _fileNames.FirstOrDefault(x => x.EndsWith(documentName, StringComparison.Ordinal));

        if (fileName != null)
        {
            var stream = _assembly.GetManifestResourceStream(fileName);
            if (stream != null) return stream;

            var entity = base.GetEntity(absoluteUri, role, ofObjectToReturn);
            if (entity != null) return entity;

            throw new InvalidOperationException();
        }

        return base.GetEntity(absoluteUri, role, ofObjectToReturn);

        // if (fileName != null)
        //     return (_assembly.GetManifestResourceStream(fileName)
        //            ?? base.GetEntity(absoluteUri, role, ofObjectToReturn))
        //            ?? throw new InvalidOperationException();
        //
        // return base.GetEntity(absoluteUri, role, ofObjectToReturn)
        //        ?? throw new InvalidOperationException();
    }
}