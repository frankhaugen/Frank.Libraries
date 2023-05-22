using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TelecommunicationsSupplyType
{
    private DescriptionType[] descriptionField;

    private PrivacyCodeType privacyCodeField;

    private TelecommunicationsSupplyLineType[] telecommunicationsSupplyLineField;

    private TelecommunicationsSupplyTypeType telecommunicationsSupplyType1Field;

    private TelecommunicationsSupplyTypeCodeType telecommunicationsSupplyTypeCodeField;

    private TotalAmountType totalAmountField;

    /// <remarks />
    [XmlElement("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
    {
        get => telecommunicationsSupplyType1Field;
        set => telecommunicationsSupplyType1Field = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
    {
        get => telecommunicationsSupplyTypeCodeField;
        set => telecommunicationsSupplyTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrivacyCodeType PrivacyCode
    {
        get => privacyCodeField;
        set => privacyCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalAmountType TotalAmount
    {
        get => totalAmountField;
        set => totalAmountField = value;
    }

    /// <remarks />
    [XmlElement("TelecommunicationsSupplyLine")]
    public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
    {
        get => telecommunicationsSupplyLineField;
        set => telecommunicationsSupplyLineField = value;
    }
}