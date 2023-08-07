namespace Frank.Libraries.Xml;

public class XmlValidatorEngine : IXmlValidatorEngine
{
    private readonly IEnumerable<IXmlValidator> _xmlValidators;

    public XmlValidatorEngine(IEnumerable<IXmlValidator> xmlValidators)
    {
        _xmlValidators = xmlValidators;
    }

    public bool IsValid(string xml, out IEnumerable<XmlValidationError>? errors, bool ignoreWarnings = false)
    {
        var errorList = new List<XmlValidationError>();
        var isValid = true;

        foreach (var xmlValidator in _xmlValidators)
        {
            var isValidXml = xmlValidator.IsValid(xml, ignoreWarnings, out var validatorErrors);
            if (!isValidXml)
            {
                if (validatorErrors != null) errorList.AddRange(validatorErrors);
                isValid = false;
            }
        }

        errors = errorList.Any()
            ? errorList
            : null;
        return isValid;
    }

}