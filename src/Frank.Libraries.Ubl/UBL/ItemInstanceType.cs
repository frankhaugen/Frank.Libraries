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
[XmlRoot("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemInstanceType
{
    private ItemPropertyType[] additionalItemPropertyField;

    private BestBeforeDateType bestBeforeDateField;

    private LotIdentificationType lotIdentificationField;

    private ManufactureDateType manufactureDateField;

    private ManufactureTimeType manufactureTimeField;

    private ProductTraceIDType productTraceIDField;

    private RegistrationIDType registrationIDField;

    private SerialIDType serialIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProductTraceIDType ProductTraceID
    {
        get => productTraceIDField;
        set => productTraceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ManufactureDateType ManufactureDate
    {
        get => manufactureDateField;
        set => manufactureDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ManufactureTimeType ManufactureTime
    {
        get => manufactureTimeField;
        set => manufactureTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BestBeforeDateType BestBeforeDate
    {
        get => bestBeforeDateField;
        set => bestBeforeDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegistrationIDType RegistrationID
    {
        get => registrationIDField;
        set => registrationIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SerialIDType SerialID
    {
        get => serialIDField;
        set => serialIDField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalItemProperty")]
    public ItemPropertyType[] AdditionalItemProperty
    {
        get => additionalItemPropertyField;
        set => additionalItemPropertyField = value;
    }

    /// <remarks />
    public LotIdentificationType LotIdentification
    {
        get => lotIdentificationField;
        set => lotIdentificationField = value;
    }
}