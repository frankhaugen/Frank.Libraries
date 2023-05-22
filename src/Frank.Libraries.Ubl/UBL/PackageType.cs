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
[XmlRoot("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PackageType
{
    private PackageType[] containedPackageField;

    private TransportEquipmentType containingTransportEquipmentField;

    private DeliveryType deliveryField;

    private DeliveryUnitType[] deliveryUnitField;

    private DespatchType despatchField;

    private GoodsItemType[] goodsItemField;

    private IDType idField;

    private DimensionType[] measurementDimensionField;

    private PackageLevelCodeType packageLevelCodeField;

    private PackagingTypeCodeType packagingTypeCodeField;

    private PackingMaterialType[] packingMaterialField;

    private PickupType pickupField;

    private QuantityType2 quantityField;

    private ReturnableMaterialIndicatorType returnableMaterialIndicatorField;

    private TraceIDType traceIDField;

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
    public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
    {
        get => returnableMaterialIndicatorField;
        set => returnableMaterialIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackageLevelCodeType PackageLevelCode
    {
        get => packageLevelCodeField;
        set => packageLevelCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackagingTypeCodeType PackagingTypeCode
    {
        get => packagingTypeCodeField;
        set => packagingTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackingMaterialType[] PackingMaterial
    {
        get => packingMaterialField;
        set => packingMaterialField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID
    {
        get => traceIDField;
        set => traceIDField = value;
    }

    /// <remarks />
    [XmlElement("ContainedPackage")]
    public PackageType[] ContainedPackage
    {
        get => containedPackageField;
        set => containedPackageField = value;
    }

    /// <remarks />
    public TransportEquipmentType ContainingTransportEquipment
    {
        get => containingTransportEquipmentField;
        set => containingTransportEquipmentField = value;
    }

    /// <remarks />
    [XmlElement("GoodsItem")]
    public GoodsItemType[] GoodsItem
    {
        get => goodsItemField;
        set => goodsItemField = value;
    }

    /// <remarks />
    [XmlElement("MeasurementDimension")]
    public DimensionType[] MeasurementDimension
    {
        get => measurementDimensionField;
        set => measurementDimensionField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryUnit")]
    public DeliveryUnitType[] DeliveryUnit
    {
        get => deliveryUnitField;
        set => deliveryUnitField = value;
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
}