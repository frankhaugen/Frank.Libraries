namespace Frank.Libraries.Xml;

public interface IXmlValidator
{
    bool IsValid(string xml, bool ignoreWarnings, out IEnumerable<XmlValidationError>? errors);
}