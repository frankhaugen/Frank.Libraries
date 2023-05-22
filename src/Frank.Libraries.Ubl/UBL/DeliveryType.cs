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
[XmlRoot("ContractualDelivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DeliveryType
{
    private ActualDeliveryDateType actualDeliveryDateField;

    private ActualDeliveryTimeType actualDeliveryTimeField;

    private LocationType1 alternativeDeliveryLocationField;

    private PartyType carrierPartyField;

    private AddressType deliveryAddressField;

    private LocationType1 deliveryLocationField;

    private PartyType deliveryPartyField;

    private DeliveryTermsType[] deliveryTermsField;

    private DespatchType despatchField;

    private PeriodType estimatedDeliveryPeriodField;

    private IDType idField;

    private LatestDeliveryDateType latestDeliveryDateField;

    private LatestDeliveryTimeType latestDeliveryTimeField;

    private DeliveryUnitType maximumDeliveryUnitField;

    private MaximumQuantityType maximumQuantityField;

    private DeliveryUnitType minimumDeliveryUnitField;

    private MinimumQuantityType minimumQuantityField;

    private PartyType[] notifyPartyField;

    private PeriodType promisedDeliveryPeriodField;

    private QuantityType2 quantityField;

    private ReleaseIDType releaseIDField;

    private PeriodType requestedDeliveryPeriodField;

    private ShipmentType shipmentField;

    private TrackingIDType trackingIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity
    {
        get => minimumQuantityField;
        set => minimumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity
    {
        get => maximumQuantityField;
        set => maximumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDeliveryDateType ActualDeliveryDate
    {
        get => actualDeliveryDateField;
        set => actualDeliveryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDeliveryTimeType ActualDeliveryTime
    {
        get => actualDeliveryTimeField;
        set => actualDeliveryTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestDeliveryDateType LatestDeliveryDate
    {
        get => latestDeliveryDateField;
        set => latestDeliveryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestDeliveryTimeType LatestDeliveryTime
    {
        get => latestDeliveryTimeField;
        set => latestDeliveryTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReleaseIDType ReleaseID
    {
        get => releaseIDField;
        set => releaseIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TrackingIDType TrackingID
    {
        get => trackingIDField;
        set => trackingIDField = value;
    }

    /// <remarks />
    public AddressType DeliveryAddress
    {
        get => deliveryAddressField;
        set => deliveryAddressField = value;
    }

    /// <remarks />
    public LocationType1 DeliveryLocation
    {
        get => deliveryLocationField;
        set => deliveryLocationField = value;
    }

    /// <remarks />
    public LocationType1 AlternativeDeliveryLocation
    {
        get => alternativeDeliveryLocationField;
        set => alternativeDeliveryLocationField = value;
    }

    /// <remarks />
    public PeriodType RequestedDeliveryPeriod
    {
        get => requestedDeliveryPeriodField;
        set => requestedDeliveryPeriodField = value;
    }

    /// <remarks />
    public PeriodType PromisedDeliveryPeriod
    {
        get => promisedDeliveryPeriodField;
        set => promisedDeliveryPeriodField = value;
    }

    /// <remarks />
    public PeriodType EstimatedDeliveryPeriod
    {
        get => estimatedDeliveryPeriodField;
        set => estimatedDeliveryPeriodField = value;
    }

    /// <remarks />
    public PartyType CarrierParty
    {
        get => carrierPartyField;
        set => carrierPartyField = value;
    }

    /// <remarks />
    public PartyType DeliveryParty
    {
        get => deliveryPartyField;
        set => deliveryPartyField = value;
    }

    /// <remarks />
    [XmlElement("NotifyParty")]
    public PartyType[] NotifyParty
    {
        get => notifyPartyField;
        set => notifyPartyField = value;
    }

    /// <remarks />
    public DespatchType Despatch
    {
        get => despatchField;
        set => despatchField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryTerms")]
    public DeliveryTermsType[] DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    public DeliveryUnitType MinimumDeliveryUnit
    {
        get => minimumDeliveryUnitField;
        set => minimumDeliveryUnitField = value;
    }

    /// <remarks />
    public DeliveryUnitType MaximumDeliveryUnit
    {
        get => maximumDeliveryUnitField;
        set => maximumDeliveryUnitField = value;
    }

    /// <remarks />
    public ShipmentType Shipment
    {
        get => shipmentField;
        set => shipmentField = value;
    }
}