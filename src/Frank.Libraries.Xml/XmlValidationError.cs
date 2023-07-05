using System.Xml.Schema;

namespace Frank.Libraries.Xml;

/// <summary>
/// Represents a validation error that occurred while validating an XML document.
/// </summary>
public class XmlValidationError
{
    /// <summary>
    /// Gets or sets the severity level of the validation error.
    /// </summary>
    public XmlSeverityType Severity { get; set; }

    /// <summary>
    /// Gets or sets the error message describing the validation error.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets the line number in the file to which the error applies.
    /// </summary>
    public int LineNumber { get; set; }

    /// <summary>
    /// Gets or sets the line position in the file to which the error applies.
    /// </summary>
    public int LinePosition { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Exception"/> that caused the current <see cref="XmlValidationError"/> instance.
    /// </summary>
    public Exception? Exception { get; set; }

    /// <summary>
    /// Creates a string representation of the current <see cref="XmlValidationError"/> instance.
    /// </summary>
    /// <returns> Severity|({LineNumber}, {LinePosition}): {Message}</returns>
    public override string ToString() => $"{Severity}|({LineNumber}, {LinePosition}): {Message}";
}