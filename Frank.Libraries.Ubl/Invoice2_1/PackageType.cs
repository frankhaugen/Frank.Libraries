namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PackageType
    {

        private IDType idField;

        private QuantityType2 quantityField;

        private ReturnableMaterialIndicatorType returnableMaterialIndicatorField;

        private PackageLevelCodeType packageLevelCodeField;

        private PackagingTypeCodeType packagingTypeCodeField;

        private PackingMaterialType[] packingMaterialField;

        private TraceIDType traceIDField;

        private PackageType[] containedPackageField;

        private TransportEquipmentType containingTransportEquipmentField;

        private GoodsItemType[] goodsItemField;

        private DimensionType[] measurementDimensionField;

        private DeliveryUnitType[] deliveryUnitField;

        private DeliveryType deliveryField;

        private PickupType pickupField;

        private DespatchType despatchField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return quantityField;
            }
            set
            {
                quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return returnableMaterialIndicatorField;
            }
            set
            {
                returnableMaterialIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackageLevelCodeType PackageLevelCode
        {
            get
            {
                return packageLevelCodeField;
            }
            set
            {
                packageLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return packagingTypeCodeField;
            }
            set
            {
                packagingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingMaterialType[] PackingMaterial
        {
            get
            {
                return packingMaterialField;
            }
            set
            {
                packingMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIDType TraceID
        {
            get
            {
                return traceIDField;
            }
            set
            {
                traceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
        public PackageType[] ContainedPackage
        {
            get
            {
                return containedPackageField;
            }
            set
            {
                containedPackageField = value;
            }
        }

        /// <remarks/>
        public TransportEquipmentType ContainingTransportEquipment
        {
            get
            {
                return containingTransportEquipmentField;
            }
            set
            {
                containingTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return goodsItemField;
            }
            set
            {
                goodsItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return measurementDimensionField;
            }
            set
            {
                measurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return deliveryUnitField;
            }
            set
            {
                deliveryUnitField = value;
            }
        }

        /// <remarks/>
        public DeliveryType Delivery
        {
            get
            {
                return deliveryField;
            }
            set
            {
                deliveryField = value;
            }
        }

        /// <remarks/>
        public PickupType Pickup
        {
            get
            {
                return pickupField;
            }
            set
            {
                pickupField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return despatchField;
            }
            set
            {
                despatchField = value;
            }
        }
    }
}