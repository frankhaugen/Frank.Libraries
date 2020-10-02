namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportHandlingUnitType
    {

        private IdType _idField;

        private TransportHandlingUnitTypeCodeType _transportHandlingUnitTypeCodeField;

        private HandlingCodeType _handlingCodeField;

        private HandlingInstructionsType[] _handlingInstructionsField;

        private HazardousRiskIndicatorType _hazardousRiskIndicatorField;

        private TotalGoodsItemQuantityType _totalGoodsItemQuantityField;

        private TotalPackageQuantityType _totalPackageQuantityField;

        private DamageRemarksType[] _damageRemarksField;

        private ShippingMarksType[] _shippingMarksField;

        private TraceIdType _traceIdField;

        private DespatchLineType[] _handlingUnitDespatchLineField;

        private PackageType[] _actualPackageField;

        private ReceiptLineType[] _receivedHandlingUnitReceiptLineField;

        private TransportEquipmentType[] _transportEquipmentField;

        private TransportMeansType[] _transportMeansField;

        private HazardousGoodsTransitType[] _hazardousGoodsTransitField;

        private DimensionType[] _measurementDimensionField;

        private TemperatureType _minimumTemperatureField;

        private TemperatureType _maximumTemperatureField;

        private GoodsItemType[] _goodsItemField;

        private DimensionType _floorSpaceMeasurementDimensionField;

        private DimensionType _palletSpaceMeasurementDimensionField;

        private DocumentReferenceType[] _shipmentDocumentReferenceField;

        private StatusType[] _statusField;

        private CustomsDeclarationType[] _customsDeclarationField;

        private ShipmentType[] _referencedShipmentField;

        private PackageType[] _packageField;

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
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return _transportHandlingUnitTypeCodeField;
            }
            set
            {
                _transportHandlingUnitTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return _handlingCodeField;
            }
            set
            {
                _handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions
        {
            get
            {
                return _handlingInstructionsField;
            }
            set
            {
                _handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicatorField;
            }
            set
            {
                _hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return _totalGoodsItemQuantityField;
            }
            set
            {
                _totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalPackageQuantityType TotalPackageQuantity
        {
            get
            {
                return _totalPackageQuantityField;
            }
            set
            {
                _totalPackageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks
        {
            get
            {
                return _damageRemarksField;
            }
            set
            {
                _damageRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingMarksType[] ShippingMarks
        {
            get
            {
                return _shippingMarksField;
            }
            set
            {
                _shippingMarksField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine")]
        public DespatchLineType[] HandlingUnitDespatchLine
        {
            get
            {
                return _handlingUnitDespatchLineField;
            }
            set
            {
                _handlingUnitDespatchLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
        public PackageType[] ActualPackage
        {
            get
            {
                return _actualPackageField;
            }
            set
            {
                _actualPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
        public ReceiptLineType[] ReceivedHandlingUnitReceiptLine
        {
            get
            {
                return _receivedHandlingUnitReceiptLineField;
            }
            set
            {
                _receivedHandlingUnitReceiptLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return _transportEquipmentField;
            }
            set
            {
                _transportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportMeans")]
        public TransportMeansType[] TransportMeans
        {
            get
            {
                return _transportMeansField;
            }
            set
            {
                _transportMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransitField;
            }
            set
            {
                _hazardousGoodsTransitField = value;
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
        public TemperatureType MinimumTemperature
        {
            get
            {
                return _minimumTemperatureField;
            }
            set
            {
                _minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return _maximumTemperatureField;
            }
            set
            {
                _maximumTemperatureField = value;
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
        public DimensionType FloorSpaceMeasurementDimension
        {
            get
            {
                return _floorSpaceMeasurementDimensionField;
            }
            set
            {
                _floorSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        public DimensionType PalletSpaceMeasurementDimension
        {
            get
            {
                return _palletSpaceMeasurementDimensionField;
            }
            set
            {
                _palletSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference
        {
            get
            {
                return _shipmentDocumentReferenceField;
            }
            set
            {
                _shipmentDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public StatusType[] Status
        {
            get
            {
                return _statusField;
            }
            set
            {
                _statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration
        {
            get
            {
                return _customsDeclarationField;
            }
            set
            {
                _customsDeclarationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedShipment")]
        public ShipmentType[] ReferencedShipment
        {
            get
            {
                return _referencedShipmentField;
            }
            set
            {
                _referencedShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return _packageField;
            }
            set
            {
                _packageField = value;
            }
        }
    }
}