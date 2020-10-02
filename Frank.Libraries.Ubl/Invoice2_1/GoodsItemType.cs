namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class GoodsItemType
    {

        private IdType _idField;

        private SequenceNumberIdType _sequenceNumberIdField;

        private DescriptionType[] _descriptionField;

        private HazardousRiskIndicatorType _hazardousRiskIndicatorField;

        private DeclaredCustomsValueAmountType _declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType _declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType _declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType _freeOnBoardValueAmountField;

        private InsuranceValueAmountType _insuranceValueAmountField;

        private ValueAmountType _valueAmountField;

        private GrossWeightMeasureType _grossWeightMeasureField;

        private NetWeightMeasureType _netWeightMeasureField;

        private NetNetWeightMeasureType _netNetWeightMeasureField;

        private ChargeableWeightMeasureType _chargeableWeightMeasureField;

        private GrossVolumeMeasureType _grossVolumeMeasureField;

        private NetVolumeMeasureType _netVolumeMeasureField;

        private QuantityType2 _quantityField;

        private PreferenceCriterionCodeType _preferenceCriterionCodeField;

        private RequiredCustomsIdType _requiredCustomsIdField;

        private CustomsStatusCodeType _customsStatusCodeField;

        private CustomsTariffQuantityType _customsTariffQuantityField;

        private CustomsImportClassifiedIndicatorType _customsImportClassifiedIndicatorField;

        private ChargeableQuantityType _chargeableQuantityField;

        private ReturnableQuantityType _returnableQuantityField;

        private TraceIdType _traceIdField;

        private ItemType[] _itemField;

        private GoodsItemContainerType[] _goodsItemContainerField;

        private AllowanceChargeType[] _freightAllowanceChargeField;

        private InvoiceLineType[] _invoiceLineField;

        private TemperatureType[] _temperatureField;

        private GoodsItemType[] _containedGoodsItemField;

        private AddressType _originAddressField;

        private DeliveryType _deliveryField;

        private PickupType _pickupField;

        private DespatchType _despatchField;

        private DimensionType[] _measurementDimensionField;

        private PackageType[] _containingPackageField;

        private DocumentReferenceType _shipmentDocumentReferenceField;

        private TemperatureType _minimumTemperatureField;

        private TemperatureType _maximumTemperatureField;

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
        public SequenceNumberIdType SequenceNumberId
        {
            get
            {
                return _sequenceNumberIdField;
            }
            set
            {
                _sequenceNumberIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
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
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return _declaredCustomsValueAmountField;
            }
            set
            {
                _declaredCustomsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return _declaredForCarriageValueAmountField;
            }
            set
            {
                _declaredForCarriageValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return _declaredStatisticsValueAmountField;
            }
            set
            {
                _declaredStatisticsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return _freeOnBoardValueAmountField;
            }
            set
            {
                _freeOnBoardValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return _insuranceValueAmountField;
            }
            set
            {
                _insuranceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueAmountType ValueAmount
        {
            get
            {
                return _valueAmountField;
            }
            set
            {
                _valueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return _grossWeightMeasureField;
            }
            set
            {
                _grossWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return _netWeightMeasureField;
            }
            set
            {
                _netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return _netNetWeightMeasureField;
            }
            set
            {
                _netNetWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return _chargeableWeightMeasureField;
            }
            set
            {
                _chargeableWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return _grossVolumeMeasureField;
            }
            set
            {
                _grossVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return _netVolumeMeasureField;
            }
            set
            {
                _netVolumeMeasureField = value;
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
        public PreferenceCriterionCodeType PreferenceCriterionCode
        {
            get
            {
                return _preferenceCriterionCodeField;
            }
            set
            {
                _preferenceCriterionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredCustomsIdType RequiredCustomsId
        {
            get
            {
                return _requiredCustomsIdField;
            }
            set
            {
                _requiredCustomsIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsStatusCodeType CustomsStatusCode
        {
            get
            {
                return _customsStatusCodeField;
            }
            set
            {
                _customsStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsTariffQuantityType CustomsTariffQuantity
        {
            get
            {
                return _customsTariffQuantityField;
            }
            set
            {
                _customsTariffQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
        {
            get
            {
                return _customsImportClassifiedIndicatorField;
            }
            set
            {
                _customsImportClassifiedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableQuantityType ChargeableQuantity
        {
            get
            {
                return _chargeableQuantityField;
            }
            set
            {
                _chargeableQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableQuantityType ReturnableQuantity
        {
            get
            {
                return _returnableQuantityField;
            }
            set
            {
                _returnableQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return _itemField;
            }
            set
            {
                _itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer")]
        public GoodsItemContainerType[] GoodsItemContainer
        {
            get
            {
                return _goodsItemContainerField;
            }
            set
            {
                _goodsItemContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return _freightAllowanceChargeField;
            }
            set
            {
                _freightAllowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine")]
        public InvoiceLineType[] InvoiceLine
        {
            get
            {
                return _invoiceLineField;
            }
            set
            {
                _invoiceLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Temperature")]
        public TemperatureType[] Temperature
        {
            get
            {
                return _temperatureField;
            }
            set
            {
                _temperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem")]
        public GoodsItemType[] ContainedGoodsItem
        {
            get
            {
                return _containedGoodsItemField;
            }
            set
            {
                _containedGoodsItemField = value;
            }
        }

        /// <remarks/>
        public AddressType OriginAddress
        {
            get
            {
                return _originAddressField;
            }
            set
            {
                _originAddressField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ContainingPackage")]
        public PackageType[] ContainingPackage
        {
            get
            {
                return _containingPackageField;
            }
            set
            {
                _containingPackageField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ShipmentDocumentReference
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
    }
}