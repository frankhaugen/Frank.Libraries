using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation;

public class ValidationError
{
    public ValidationError(XmlSchemaException? exception, string message, XmlSeverityType severity,
                           string? documentName)
    {
        Severity = severity;
        DocumentName = documentName;
        Message = message;
        Exception = exception;
    }

    public XmlSchemaException? Exception { get; }

    public string Message { get; }

    public XmlSeverityType Severity { get; }

    public int? LineNumber => Exception?.LineNumber;

    public int? LinePosition => Exception?.LinePosition;

    public string? DocumentName { get; }

    public override string ToString() => $"[{Severity}]: {Message} - {Exception}";
}