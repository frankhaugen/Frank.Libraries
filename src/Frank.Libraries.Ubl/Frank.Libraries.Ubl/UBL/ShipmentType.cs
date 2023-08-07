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
[XmlRoot("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ShipmentType
{
    private ConsignmentType[] consignmentField;

    private ConsignmentQuantityType consignmentQuantityField;

    private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

    private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

    private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

    private DeliveryType deliveryField;

    private DeliveryInstructionsType[] deliveryInstructionsField;

    private CountryType exportCountryField;

    private LocationType1 firstArrivalPortLocationField;

    private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private GoodsItemType[] goodsItemField;

    private GrossVolumeMeasureType grossVolumeMeasureField;

    private GrossWeightMeasureType grossWeightMeasureField;

    private HandlingCodeType handlingCodeField;

    private HandlingInstructionsType[] handlingInstructionsField;

    private IDType idField;

    private InformationType[] informationField;

    private InsuranceValueAmountType insuranceValueAmountField;

    private LocationType1 lastExitPortLocationField;

    private NetNetWeightMeasureType netNetWeightMeasureField;

    private NetVolumeMeasureType netVolumeMeasureField;

    private NetWeightMeasureType netWeightMeasureField;

    private AddressType originAddressField;

    private AddressType returnAddressField;

    private ShipmentStageType[] shipmentStageField;

    private ShippingPriorityLevelCodeType shippingPriorityLevelCodeField;

    private SpecialInstructionsType[] specialInstructionsField;

    private SplitConsignmentIndicatorType splitConsignmentIndicatorField;

    private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

    private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

    private TransportHandlingUnitType[] transportHandlingUnitField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
    {
        get => shippingPriorityLevelCodeField;
        set => shippingPriorityLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode
    {
        get => handlingCodeField;
        set => handlingCodeField = value;
    }

    /// <remarks />
    [XmlElement("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions
    {
        get => handlingInstructionsField;
        set => handlingInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information
    {
        get => informationField;
        set => informationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossWeightMeasureType GrossWeightMeasure
    {
        get => grossWeightMeasureField;
        set => grossWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure
    {
        get => netWeightMeasureField;
        set => netWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetNetWeightMeasureType NetNetWeightMeasure
    {
        get => netNetWeightMeasureField;
        set => netNetWeightMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossVolumeMeasureType GrossVolumeMeasure
    {
        get => grossVolumeMeasureField;
        set => grossVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure
    {
        get => netVolumeMeasureField;
        set => netVolumeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity
    {
        get => totalGoodsItemQuantityField;
        set => totalGoodsItemQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
    {
        get => totalTransportHandlingUnitQuantityField;
        set => totalTransportHandlingUnitQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount
    {
        get => insuranceValueAmountField;
        set => insuranceValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
    {
        get => declaredCustomsValueAmountField;
        set => declaredCustomsValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
    {
        get => declaredForCarriageValueAmountField;
        set => declaredForCarriageValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
    {
        get => declaredStatisticsValueAmountField;
        set => declaredStatisticsValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOnBoardValueAmountType FreeOnBoardValueAmount
    {
        get => freeOnBoardValueAmountField;
        set => freeOnBoardValueAmountField = value;
    }

    /// <remarks />
    [XmlElement("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialInstructionsType[] SpecialInstructions
    {
        get => specialInstructionsField;
        set => specialInstructionsField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveryInstructionsType[] DeliveryInstructions
    {
        get => deliveryInstructionsField;
        set => deliveryInstructionsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SplitConsignmentIndicatorType SplitConsignmentIndicator
    {
        get => splitConsignmentIndicatorField;
        set => splitConsignmentIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignmentQuantityType ConsignmentQuantity
    {
        get => consignmentQuantityField;
        set => consignmentQuantityField = value;
    }

    /// <remarks />
    [XmlElement("Consignment")]
    public ConsignmentType[] Consignment
    {
        get => consignmentField;
        set => consignmentField = value;
    }

    /// <remarks />
    [XmlElement("GoodsItem")]
    public GoodsItemType[] GoodsItem
    {
        get => goodsItemField;
        set => goodsItemField = value;
    }

    /// <remarks />
    [XmlElement("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage
    {
        get => shipmentStageField;
        set => shipmentStageField = value;
    }

    /// <remarks />
    public DeliveryType Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    [XmlElement("TransportHandlingUnit")]
    public TransportHandlingUnitType[] TransportHandlingUnit
    {
        get => transportHandlingUnitField;
        set => transportHandlingUnitField = value;
    }

    /// <remarks />
    public AddressType ReturnAddress
    {
        get => returnAddressField;
        set => returnAddressField = value;
    }

    /// <remarks />
    public AddressType OriginAddress
    {
        get => originAddressField;
        set => originAddressField = value;
    }

    /// <remarks />
    public LocationType1 FirstArrivalPortLocation
    {
        get => firstArrivalPortLocationField;
        set => firstArrivalPortLocationField = value;
    }

    /// <remarks />
    public LocationType1 LastExitPortLocation
    {
        get => lastExitPortLocationField;
        set => lastExitPortLocationField = value;
    }

    /// <remarks />
    public CountryType ExportCountry
    {
        get => exportCountryField;
        set => exportCountryField = value;
    }

    /// <remarks />
    [XmlElement("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get => freightAllowanceChargeField;
        set => freightAllowanceChargeField = value;
    }
}