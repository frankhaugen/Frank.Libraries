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
[XmlRoot("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class GoodsItemType
{
    private ChargeableQuantityType chargeableQuantityField;

    private ChargeableWeightMeasureType chargeableWeightMeasureField;

    private GoodsItemType[] containedGoodsItemField;

    private PackageType[] containingPackageField;

    private CustomsImportClassifiedIndicatorType customsImportClassifiedIndicatorField;

    private CustomsStatusCodeType customsStatusCodeField;

    private CustomsTariffQuantityType customsTariffQuantityField;

    private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

    private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

    private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

    private DeliveryType deliveryField;

    private DescriptionType[] descriptionField;

    private DespatchType despatchField;

    private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

    private AllowanceChargeType[] freightAllowanceChargeField;

    private GoodsItemContainerType[] goodsItemContainerField;

    private GrossVolumeMeasureType grossVolumeMeasureField;

    private GrossWeightMeasureType grossWeightMeasureField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private IDType idField;

    private InsuranceValueAmountType insuranceValueAmountField;

    private InvoiceLineType[] invoiceLineField;

    private ItemType[] itemField;

    private TemperatureType maximumTemperatureField;

    private DimensionType[] measurementDimensionField;

    private TemperatureType minimumTemperatureField;

    private NetNetWeightMeasureType netNetWeightMeasureField;

    private NetVolumeMeasureType netVolumeMeasureField;

    private NetWeightMeasureType netWeightMeasureField;

    private AddressType originAddressField;

    private PickupType pickupField;

    private PreferenceCriterionCodeType preferenceCriterionCodeField;

    private QuantityType2 quantityField;

    private RequiredCustomsIDType requiredCustomsIDField;

    private ReturnableQuantityType returnableQuantityField;

    private SequenceNumberIDType sequenceNumberIDField;

    private DocumentReferenceType shipmentDocumentReferenceField;

    private TemperatureType[] temperatureField;

    private TraceIDType traceIDField;

    private ValueAmountType valueAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumberIDType SequenceNumberID
    {
        get => sequenceNumberIDField;
        set => sequenceNumberIDField = value;
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
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get => hazardousRiskIndicatorField;
        set => hazardousRiskIndicatorField = value;
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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount
    {
        get => insuranceValueAmountField;
        set => insuranceValueAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueAmountType ValueAmount
    {
        get => valueAmountField;
        set => valueAmountField = value;
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
    public ChargeableWeightMeasureType ChargeableWeightMeasure
    {
        get => chargeableWeightMeasureField;
        set => chargeableWeightMeasureField = value;
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
    public QuantityType2 Quantity
    {
        get => quantityField;
        set => quantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreferenceCriterionCodeType PreferenceCriterionCode
    {
        get => preferenceCriterionCodeField;
        set => preferenceCriterionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredCustomsIDType RequiredCustomsID
    {
        get => requiredCustomsIDField;
        set => requiredCustomsIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsStatusCodeType CustomsStatusCode
    {
        get => customsStatusCodeField;
        set => customsStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsTariffQuantityType CustomsTariffQuantity
    {
        get => customsTariffQuantityField;
        set => customsTariffQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
    {
        get => customsImportClassifiedIndicatorField;
        set => customsImportClassifiedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableQuantityType ChargeableQuantity
    {
        get => chargeableQuantityField;
        set => chargeableQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReturnableQuantityType ReturnableQuantity
    {
        get => returnableQuantityField;
        set => returnableQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID
    {
        get => traceIDField;
        set => traceIDField = value;
    }

    /// <remarks />
    [XmlElement("Item")]
    public ItemType[] Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlElement("GoodsItemContainer")]
    public GoodsItemContainerType[] GoodsItemContainer
    {
        get => goodsItemContainerField;
        set => goodsItemContainerField = value;
    }

    /// <remarks />
    [XmlElement("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get => freightAllowanceChargeField;
        set => freightAllowanceChargeField = value;
    }

    /// <remarks />
    [XmlElement("InvoiceLine")]
    public InvoiceLineType[] InvoiceLine
    {
        get => invoiceLineField;
        set => invoiceLineField = value;
    }

    /// <remarks />
    [XmlElement("Temperature")]
    public TemperatureType[] Temperature
    {
        get => temperatureField;
        set => temperatureField = value;
    }

    /// <remarks />
    [XmlElement("ContainedGoodsItem")]
    public GoodsItemType[] ContainedGoodsItem
    {
        get => containedGoodsItemField;
        set => containedGoodsItemField = value;
    }

    /// <remarks />
    public AddressType OriginAddress
    {
        get => originAddressField;
        set => originAddressField = value;
    }

    /// <remarks />
    public DeliveryType Delivery
    {
        get => deliveryField;
        set => deliveryField = value;
    }

    /// <remarks />
    public PickupType Pickup
    {
        get => pickupField;
        set => pickupField = value;
    }

    /// <remarks />
    public DespatchType Despatch
    {
        get => despatchField;
        set => despatchField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }

    /// <remarks />
    [XmlElement("ContainingPackage")]
    public PackageType[] ContainingPackage
    {
        get => containingPackageField;
        set => containingPackageField = value;
    }

    /// <remarks />
    public DocumentReferenceType ShipmentDocumentReference
    {
        get => shipmentDocumentReferenceField;
        set => shipmentDocumentReferenceField = value;
    }

    /// <remarks />
    public TemperatureType MinimumTemperature
    {
        get => minimumTemperatureField;
        set => minimumTemperatureField = value;
    }

    /// <remarks />
    public TemperatureType MaximumTemperature
    {
        get => maximumTemperatureField;
        set => maximumTemperatureField = value;
    }
}