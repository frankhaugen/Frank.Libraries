using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation.SchemaSets;

public class UblSchemaSet : XmlSchemaSet
{
    public UblSchemaSet()
    {
        var assembly = typeof(UblSchemaSet).Assembly;
        var ublXsdNames = assembly.GetManifestResourceNames()
                                  .Where(x =>
                                             (x.StartsWith("Semine.Common.Ubl.xsd.common.") || x.StartsWith("Semine.Common.Ubl.xsd.maindoc.")) && x.EndsWith(".xsd"))
                                  .Distinct(StringComparer.InvariantCultureIgnoreCase);
        foreach (var manifestResourceName in ublXsdNames)
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