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
[XmlRoot("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SubscriberConsumptionType
{
    private ConsumptionType consumptionField;

    private ConsumptionIDType consumptionIDField;

    private NoteType[] noteField;

    private OnAccountPaymentType[] onAccountPaymentField;

    private SpecificationTypeCodeType specificationTypeCodeField;

    private PartyType subscriberPartyField;

    private SupplierConsumptionType[] supplierConsumptionField;

    private TotalMeteredQuantityType totalMeteredQuantityField;

    private ConsumptionPointType utilityConsumptionPointField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumptionIDType ConsumptionID
    {
        get => consumptionIDField;
        set => consumptionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecificationTypeCodeType SpecificationTypeCode
    {
        get => specificationTypeCodeField;
        set => specificationTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalMeteredQuantityType TotalMeteredQuantity
    {
        get => totalMeteredQuantityField;
        set => totalMeteredQuantityField = value;
    }

    /// <remarks />
    public PartyType SubscriberParty
    {
        get => subscriberPartyField;
        set => subscriberPartyField = value;
    }

    /// <remarks />
    public ConsumptionPointType UtilityConsumptionPoint
    {
        get => utilityConsumptionPointField;
        set => utilityConsumptionPointField = value;
    }

    /// <remarks />
    [XmlElement("OnAccountPayment")]
    public OnAccountPaymentType[] OnAccountPayment
    {
        get => onAccountPaymentField;
        set => onAccountPaymentField = value;
    }

    /// <remarks />
    public ConsumptionType Consumption
    {
        get => consumptionField;
        set => consumptionField = value;
    }

    /// <remarks />
    [XmlElement("SupplierConsumption")]
    public SupplierConsumptionType[] SupplierConsumption
    {
        get => supplierConsumptionField;
        set => supplierConsumptionField = value;
    }
}