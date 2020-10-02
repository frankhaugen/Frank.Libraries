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

        private IdType _idField;

        private QuantityType2 _quantityField;

        private ReturnableMaterialIndicatorType _returnableMaterialIndicatorField;

        private PackageLevelCodeType _packageLevelCodeField;

        private PackagingTypeCodeType _packagingTypeCodeField;

        private PackingMaterialType[] _packingMaterialField;

        private TraceIdType _traceIdField;

        private PackageType[] _containedPackageField;

        private TransportEquipmentType _containingTransportEquipmentField;

        private GoodsItemType[] _goodsItemField;

        private DimensionType[] _measurementDimensionField;

        private DeliveryUnitType[] _deliveryUnitField;

        private DeliveryType _deliveryField;

        private PickupType _pickupField;

        private DespatchType _despatchField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity
        {
            get
            {
                return _quantityField;
            }
            set
            {
                _quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return _returnableMaterialIndicatorField;
            }
            set
            {
                _returnableMaterialIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackageLevelCodeType PackageLevelCode
        {
            get
            {
                return _packageLevelCodeField;
            }
            set
            {
                _packageLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return _packagingTypeCodeField;
            }
            set
            {
                _packagingTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PackingMaterialType[] PackingMaterial
        {
            get
            {
                return _packingMaterialField;
            }
            set
            {
                _packingMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TraceIdType TraceId
        {
            get
            {
                return _traceIdField;
            }
            set
            {
                _traceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
        public PackageType[] ContainedPackage
        {
            get
            {
                return _containedPackageField;
            }
            set
            {
                _containedPackageField = value;
            }
        }

        /// <remarks/>
        public TransportEquipmentType ContainingTransportEquipment
        {
            get
            {
                return _containingTransportEquipmentField;
            }
            set
            {
                _containingTransportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return _goodsItemField;
            }
            set
            {
                _goodsItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return _measurementDimensionField;
            }
            set
            {
                _measurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return _deliveryUnitField;
            }
            set
            {
                _deliveryUnitField = value;
            }
        }

        /// <remarks/>
        public DeliveryType Delivery
        {
            get
            {
                return _deliveryField;
            }
            set
            {
                _deliveryField = value;
            }
        }

        /// <remarks/>
        public PickupType Pickup
        {
            get
            {
                return _pickupField;
            }
            set
            {
                _pickupField = value;
            }
        }

        /// <remarks/>
        public DespatchType Despatch
        {
            get
            {
                return _despatchField;
            }
            set
            {
                _despatchField = value;
            }
        }
    }
}