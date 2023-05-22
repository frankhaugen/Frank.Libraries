using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation.SchemaSets;

/// <summary>
/// A <see cref="XmlSchemaSet"/> containing the XSDs for the Standard Business Document Header
/// </summary>
public class StandardBusinessDocumentHeaderSchemaSet : XmlSchemaSet
{
    public StandardBusinessDocumentHeaderSchemaSet()
    {
        var assembly = typeof(StandardBusinessDocumentHeaderSchemaSet).Assembly;
        var standardBusinessDocumentHeaderXsdNames = assembly.GetManifestResourceNames()
            .Where(x => x.StartsWith("Semine.Common.Ubl.xsd.sbdh.") && x.EndsWith(".xsd"))
            .Distinct(StringComparer.InvariantCultureIgnoreCase);
        foreach (var manifestResourceName in standardBusinessDocumentHeaderXsdNames)
        {
            using var stream = assembly.GetManifestResourceStream(manifestResourceName);
            if (stream == null) continue;
            var schema = XmlSchema.Read(stream,
                (sender, args) =>
                    Errors.Add(new ValidationError(args.Exception, args.Message, args.Severity, manifestResourceName)));
            if (schema != null) Add(schema);
        }

        Compile();
    }

    public List<ValidationError> Errors { get; } = new();
}