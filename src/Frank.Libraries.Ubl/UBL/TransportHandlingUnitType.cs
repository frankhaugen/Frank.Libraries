using System;
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
[XmlRoot("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportHandlingUnitType
{
    private PackageType[] actualPackageField;

    private CustomsDeclarationType[] customsDeclarationField;

    private DamageRemarksType[] damageRemarksField;

    private DimensionType floorSpaceMeasurementDimensionField;

    private GoodsItemType[] goodsItemField;

    private HandlingCodeType handlingCodeField;

    private HandlingInstructionsType[] handlingInstructionsField;

    private DespatchLineType[] handlingUnitDespatchLineField;

    private HazardousGoodsTransitType[] hazardousGoodsTransitField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private IDType idField;

    private TemperatureType maximumTemperatureField;

    private DimensionType[] measurementDimensionField;

    private TemperatureType minimumTemperatureField;

    private PackageType[] packageField;

    private DimensionType palletSpaceMeasurementDimensionField;

    private ReceiptLineType[] receivedHandlingUnitReceiptLineField;

    private ShipmentType[] referencedShipmentField;

    private DocumentReferenceType[] shipmentDocumentReferenceField;

    private ShippingMarksType[] shippingMarksField;

    private StatusType[] statusField;

    private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

    private TotalPackageQuantityType totalPackageQuantityField;

    private TraceIDType traceIDField;

    private TransportEquipmentType[] transportEquipmentField;

    private TransportHandlingUnitTypeCodeType transportHandlingUnitTypeCodeField;

    private TransportMeansType[] transportMeansField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
    {
        get => transportHandlingUnitTypeCodeField;
        set => transportHandlingUnitTypeCodeField = value;
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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get => hazardousRiskIndicatorField;
        set => hazardousRiskIndicatorField = value;
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
    public TotalPackageQuantityType TotalPackageQuantity
    {
        get => totalPackageQuantityField;
        set => totalPackageQuantityField = value;
    }

    /// <remarks />
    [XmlElement("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DamageRemarksType[] DamageRemarks
    {
        get => damageRemarksField;
        set => damageRemarksField = value;
    }

    /// <remarks />
    [XmlElement("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingMarksType[] ShippingMarks
    {
        get => shippingMarksField;
        set => shippingMarksField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID
    {
        get => traceIDField;
        set => traceIDField = value;
    }

    /// <remarks />
    [XmlElement("HandlingUnitDespatchLine")]
    public DespatchLineType[] HandlingUnitDespatchLine
    {
        get => handlingUnitDespatchLineField;
        set => handlingUnitDespatchLineField = value;
    }

    /// <remarks />
    [XmlElement("ActualPackage")]
    public PackageType[] ActualPackage
    {
        get => actualPackageField;
        set => actualPackageField = value;
    }

    /// <remarks />
    [XmlElement("ReceivedHandlingUnitReceiptLine")]
    public ReceiptLineType[] ReceivedHandlingUnitReceiptLine
    {
        get => receivedHandlingUnitReceiptLineField;
        set => receivedHandlingUnitReceiptLineField = value;
    }

    /// <remarks />
    [XmlElement("TransportEquipment")]
    public TransportEquipmentType[] TransportEquipment
    {
        get => transportEquipmentField;
        set => transportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("TransportMeans")]
    public TransportMeansType[] TransportMeans
    {
        get => transportMeansField;
        set => transportMeansField = value;
    }

    /// <remarks />
    [XmlElement("HazardousGoodsTransit")]
    public HazardousGoodsTransitType[] HazardousGoodsTransit
    {
        get => hazardousGoodsTransitField;
        set => hazardousGoodsTransitField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
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

    /// <remarks />
    [XmlElement("GoodsItem")]
    public GoodsItemType[] GoodsItem
    {
        get => goodsItemField;
        set => goodsItemField = value;
    }

    /// <remarks />
    public DimensionType FloorSpaceMeasurementDimension
    {
        get => floorSpaceMeasurementDimensionField;
        set => floorSpaceMeasurementDimensionField = value;
    }

    /// <remarks />
    public DimensionType PalletSpaceMeasurementDimension
    {
        get => palletSpaceMeasurementDimensionField;
        set => palletSpaceMeasurementDimensionField = value;
    }

    /// <remarks />
    [XmlElement("ShipmentDocumentReference")]
    public DocumentReferenceType[] ShipmentDocumentReference
    {
        get => shipmentDocumentReferenceField;
        set => shipmentDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("Status")]
    public StatusType[] Status
    {
        get => statusField;
        set => statusField = value;
    }

    /// <remarks />
    [XmlElement("CustomsDeclaration")]
    public CustomsDeclarationType[] CustomsDeclaration
    {
        get => customsDeclarationField;
        set => customsDeclarationField = value;
    }

    /// <remarks />
    [XmlElement("ReferencedShipment")]
    public ShipmentType[] ReferencedShipment
    {
        get => referencedShipmentField;
        set => referencedShipmentField = value;
    }

    /// <remarks />
    [XmlElement("Package")]
    public PackageType[] Package
    {
        get => packageField;
        set => packageField = value;
    }
}