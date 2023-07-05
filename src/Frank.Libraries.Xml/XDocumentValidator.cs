using System.Xml.Linq;
using System.Xml.Schema;

namespace Frank.Libraries.Xml;

public class XDocumentValidator : IXmlValidator
{
    private readonly XmlSchemaSet _xmlSchemaSet;

    public XDocumentValidator(XmlSchemaSet? xmlSchemaSet = null)
    {
        _xmlSchemaSet = xmlSchemaSet ?? new XmlSchemaSet();
    }

    public bool IsValid(string xml, bool ignoreWarnings, out IEnumerable<XmlValidationError>? errors)
    {
        var errorList = new List<XmlValidationError>();
        var isValid = true;

        try
        {
            var xDocument = XDocument.Parse(xml);
            xDocument.Validate(_xmlSchemaSet, (sender, args) =>
            {
                var xmlValidationError = new XmlValidationError
                {
                    Severity = args.Severity,
                    Message = args.Message,
                    Exception = args.Exception,
                    LineNumber = args.Exception?.LineNumber ?? -1,
                    LinePosition = args.Exception?.LinePosition ?? -1
                };

                if (args.Severity == XmlSeverityType.Error)
                {
                    errorList.Add(xmlValidationError);
                    isValid = false;
                }
                else if (!ignoreWarnings)
                {
                    errorList.Add(xmlValidationError);
                    isValid = false;
                }
            });
        }
        catch (Exception e)
        {
            errorList.Add(new XmlValidationError
            {
                Severity = XmlSeverityType.Error,
                Message = e.Message,
                Exception = e,
                LineNumber = -1,
                LinePosition = -1
            });
            isValid = false;
        }

        errors = errorList;
        return isValid;
    }
}