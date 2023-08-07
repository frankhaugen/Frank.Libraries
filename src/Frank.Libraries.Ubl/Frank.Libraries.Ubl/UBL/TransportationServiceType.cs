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
[XmlRoot("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportationServiceType
{
    private CommodityClassificationType[] commodityClassificationField;

    private EnvironmentalEmissionType[] environmentalEmissionField;

    private PeriodType estimatedDurationPeriodField;

    private FreightRateClassCodeType freightRateClassCodeField;

    private NameType1 nameField;

    private NominationDateType nominationDateField;

    private NominationTimeType nominationTimeField;

    private PriorityType priorityField;

    private PartyType responsibleTransportServiceProviderPartyField;

    private ServiceFrequencyType[] scheduledServiceFrequencyField;

    private SequenceNumericType sequenceNumericField;

    private ShipmentStageType[] shipmentStageField;

    private CommodityClassificationType[] supportedCommodityClassificationField;

    private TransportEquipmentType[] supportedTransportEquipmentField;

    private TariffClassCodeType tariffClassCodeField;

    private DimensionType totalCapacityDimensionField;

    private TransportationServiceDescriptionType[] transportationServiceDescriptionField;

    private TransportationServiceDetailsURIType transportationServiceDetailsURIField;

    private TransportEquipmentType[] transportEquipmentField;

    private TransportEventType[] transportEventField;

    private TransportServiceCodeType transportServiceCodeField;

    private CommodityClassificationType[] unsupportedCommodityClassificationField;

    private TransportEquipmentType[] unsupportedTransportEquipmentField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportServiceCodeType TransportServiceCode
    {
        get => transportServiceCodeField;
        set => transportServiceCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffClassCodeType TariffClassCode
    {
        get => tariffClassCodeField;
        set => tariffClassCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriorityType Priority
    {
        get => priorityField;
        set => priorityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreightRateClassCodeType FreightRateClassCode
    {
        get => freightRateClassCodeField;
        set => freightRateClassCodeField = value;
    }

    /// <remarks />
    [XmlElement("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportationServiceDescriptionType[] TransportationServiceDescription
    {
        get => transportationServiceDescriptionField;
        set => transportationServiceDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportationServiceDetailsURIType TransportationServiceDetailsURI
    {
        get => transportationServiceDetailsURIField;
        set => transportationServiceDetailsURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationDateType NominationDate
    {
        get => nominationDateField;
        set => nominationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationTimeType NominationTime
    {
        get => nominationTimeField;
        set => nominationTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric
    {
        get => sequenceNumericField;
        set => sequenceNumericField = value;
    }

    /// <remarks />
    [XmlElement("TransportEquipment")]
    public TransportEquipmentType[] TransportEquipment
    {
        get => transportEquipmentField;
        set => transportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("SupportedTransportEquipment")]
    public TransportEquipmentType[] SupportedTransportEquipment
    {
        get => supportedTransportEquipmentField;
        set => supportedTransportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("UnsupportedTransportEquipment")]
    public TransportEquipmentType[] UnsupportedTransportEquipment
    {
        get => unsupportedTransportEquipmentField;
        set => unsupportedTransportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("CommodityClassification")]
    public CommodityClassificationType[] CommodityClassification
    {
        get => commodityClassificationField;
        set => commodityClassificationField = value;
    }

    /// <remarks />
    [XmlElement("SupportedCommodityClassification")]
    public CommodityClassificationType[] SupportedCommodityClassification
    {
        get => supportedCommodityClassificationField;
        set => supportedCommodityClassificationField = value;
    }

    /// <remarks />
    [XmlElement("UnsupportedCommodityClassification")]
    public CommodityClassificationType[] UnsupportedCommodityClassification
    {
        get => unsupportedCommodityClassificationField;
        set => unsupportedCommodityClassificationField = value;
    }

    /// <remarks />
    public DimensionType TotalCapacityDimension
    {
        get => totalCapacityDimensionField;
        set => totalCapacityDimensionField = value;
    }

    /// <remarks />
    [XmlElement("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage
    {
        get => shipmentStageField;
        set => shipmentStageField = value;
    }

    /// <remarks />
    [XmlElement("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get => transportEventField;
        set => transportEventField = value;
    }

    /// <remarks />
    public PartyType ResponsibleTransportServiceProviderParty
    {
        get => responsibleTransportServiceProviderPartyField;
        set => responsibleTransportServiceProviderPartyField = value;
    }

    /// <remarks />
    [XmlElement("EnvironmentalEmission")]
    public EnvironmentalEmissionType[] EnvironmentalEmission
    {
        get => environmentalEmissionField;
        set => environmentalEmissionField = value;
    }

    /// <remarks />
    public PeriodType EstimatedDurationPeriod
    {
        get => estimatedDurationPeriodField;
        set => estimatedDurationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("ScheduledServiceFrequency")]
    public ServiceFrequencyType[] ScheduledServiceFrequency
    {
        get => scheduledServiceFrequencyField;
        set => scheduledServiceFrequencyField = value;
    }
}