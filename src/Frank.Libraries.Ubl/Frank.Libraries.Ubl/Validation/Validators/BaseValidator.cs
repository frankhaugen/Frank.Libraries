using System.Xml;
using System.Xml.Schema;
using Frank.Libraries.Ubl.Validation.Internals;

namespace Frank.Libraries.Ubl.Validation.Validators;

internal abstract class BaseValidator<T>
{
    protected static void Validate(ICollection<ValidationError> errors, MemoryStream memStream, bool suppressWarnings, string? documentName = null)
    {
        var manifest = new XsdManifest();
        var schemaSet = manifest.XsdMetadata.Values.ToSchemaSet();
        var xsdResolver = new ManifestXmlUrlResolver();
        var xmlReaderSettings = new XmlReaderSettings()
        {
            ValidationType = ValidationType.Schema,
            ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.ProcessSchemaLocation | XmlSchemaValidationFlags.ReportValidationWarnings,
            Schemas = schemaSet,
            XmlResolver = xsdResolver
        };
        xmlReaderSettings.ValidationEventHandler += (s, e) => ValidationHandler(errors, suppressWarnings, e, documentName);

        try
        {
            using var xmlReader = XmlReader.Create(memStream, xmlReaderSettings);
            while (xmlReader.Read())
            {
                // Read all XML content
            }
        }
        catch (Exception e)
        {
            errors.Add(new ValidationError(null, e.Message, XmlSeverityType.Error, documentName));
        }
    }

    private static void ValidationHandler(ICollection<ValidationError> errors, bool suppressWarnings,
                                          ValidationEventArgs e, string? documentName = null)
    {
        if (suppressWarnings && e.Severity == XmlSeverityType.Warning)
            return;

        errors.Add(new ValidationError(e.Exception, e.Message, e.Severity, documentName));
    }

    public abstract bool IsValid(T document, in ICollection<ValidationError> errors, bool suppressWarnings = false);
}