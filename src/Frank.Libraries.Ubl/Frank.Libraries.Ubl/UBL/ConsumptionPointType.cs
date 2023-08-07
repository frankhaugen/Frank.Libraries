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
[XmlRoot("ConsumptionPoint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ConsumptionPointType
{
    private AddressType addressField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private SubscriberIDType subscriberIDField;

    private SubscriberTypeCodeType subscriberTypeCodeField;

    private SubscriberTypeType subscriberTypeField;

    private TotalDeliveredQuantityType totalDeliveredQuantityField;

    private MeterType[] utilityMeterField;

    private WebSiteAccessType webSiteAccessField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
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
    public SubscriberIDType SubscriberID
    {
        get => subscriberIDField;
        set => subscriberIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeType SubscriberType
    {
        get => subscriberTypeField;
        set => subscriberTypeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubscriberTypeCodeType SubscriberTypeCode
    {
        get => subscriberTypeCodeField;
        set => subscriberTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalDeliveredQuantityType TotalDeliveredQuantity
    {
        get => totalDeliveredQuantityField;
        set => totalDeliveredQuantityField = value;
    }

    /// <remarks />
    public AddressType Address
    {
        get => addressField;
        set => addressField = value;
    }

    /// <remarks />
    public WebSiteAccessType WebSiteAccess
    {
        get => webSiteAccessField;
        set => webSiteAccessField = value;
    }

    /// <remarks />
    [XmlElement("UtilityMeter")]
    public MeterType[] UtilityMeter
    {
        get => utilityMeterField;
        set => utilityMeterField = value;
    }
}