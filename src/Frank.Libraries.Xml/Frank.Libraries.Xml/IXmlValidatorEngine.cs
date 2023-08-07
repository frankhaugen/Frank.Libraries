namespace Frank.Libraries.Xml;

public interface IXmlValidatorEngine
{
    bool IsValid(string xml, out IEnumerable<XmlValidationError>? errors, bool ignoreWarnings = false);
}