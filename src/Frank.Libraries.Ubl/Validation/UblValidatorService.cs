using System.Xml.Linq;
using Frank.Libraries.Ubl.Validation.Validators;

namespace Frank.Libraries.Ubl.Validation;

public class UblValidatorService
{
    private readonly XDocumentValidator _xDocumentValidator;

    public UblValidatorService()
    {
        _xDocumentValidator = new XDocumentValidator();
    }

    public bool IsValid(XDocument document, in ICollection<ValidationError> errors, bool suppressWarnings = false)
        => _xDocumentValidator.IsValid(document, in errors, suppressWarnings);
}