using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ResultOfVerificationType
{
    private PartyType signatoryPartyField;

    private ValidateProcessType validateProcessField;

    private ValidateToolType validateToolField;

    private ValidateToolVersionType validateToolVersionField;

    private ValidationDateType validationDateField;

    private ValidationResultCodeType validationResultCodeField;

    private ValidationTimeType validationTimeField;

    private ValidatorIDType validatorIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidatorIDType ValidatorID
    {
        get => validatorIDField;
        set => validatorIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidationResultCodeType ValidationResultCode
    {
        get => validationResultCodeField;
        set => validationResultCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidationDateType ValidationDate
    {
        get => validationDateField;
        set => validationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidationTimeType ValidationTime
    {
        get => validationTimeField;
        set => validationTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidateProcessType ValidateProcess
    {
        get => validateProcessField;
        set => validateProcessField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidateToolType ValidateTool
    {
        get => validateToolField;
        set => validateToolField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidateToolVersionType ValidateToolVersion
    {
        get => validateToolVersionField;
        set => validateToolVersionField = value;
    }

    /// <remarks />
    public PartyType SignatoryParty
    {
        get => signatoryPartyField;
        set => signatoryPartyField = value;
    }
}