using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation.Validators;

internal class XDocumentValidator : BaseValidator<XDocument>
{
    private static readonly XmlWriterSettings _xmlWriterSettings = new()
    {
        CloseOutput = false,
        Indent = false,
        CheckCharacters = false,
        NewLineHandling = NewLineHandling.None,
        NamespaceHandling = NamespaceHandling.OmitDuplicates,
        Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)
    };

    public override bool IsValid(XDocument document, in ICollection<ValidationError> errors,
        bool suppressWarnings = false)
    {
        if (document == null) throw new ArgumentNullException(nameof(document));
        if (document.Root == null)
            errors.Add(new ValidationError(null, "Document root is null.", XmlSeverityType.Error, null));

        using (var memStream = new MemoryStream())
        using (var writer = XmlWriter.Create(memStream, _xmlWriterSettings))
        {
            document.Save(writer);
            writer.Flush();
            memStream.Seek(0, SeekOrigin.Begin);
            Validate(errors, memStream, suppressWarnings);
        }

        return !errors.Any();
    }
}