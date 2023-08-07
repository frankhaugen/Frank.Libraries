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
[XmlRoot("TransportEquipmentSeal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportEquipmentSealType
{
    private ConditionType conditionField;

    private IDType idField;

    private SealingPartyTypeType sealingPartyTypeField;

    private SealIssuerTypeCodeType sealIssuerTypeCodeField;

    private SealStatusCodeType sealStatusCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SealIssuerTypeCodeType SealIssuerTypeCode
    {
        get => sealIssuerTypeCodeField;
        set => sealIssuerTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionType Condition
    {
        get => conditionField;
        set => conditionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SealStatusCodeType SealStatusCode
    {
        get => sealStatusCodeField;
        set => sealStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SealingPartyTypeType SealingPartyType
    {
        get => sealingPartyTypeField;
        set => sealingPartyTypeField = value;
    }
}