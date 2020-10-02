namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ShipmentType
    {

        private IdType _idField;

        private ShippingPriorityLevelCodeType _shippingPriorityLevelCodeField;

        private HandlingCodeType _handlingCodeField;

        private HandlingInstructionsType[] _handlingInstructionsField;

        private InformationType[] _informationField;

        private GrossWeightMeasureType _grossWeightMeasureField;

        private NetWeightMeasureType _netWeightMeasureField;

        private NetNetWeightMeasureType _netNetWeightMeasureField;

        private GrossVolumeMeasureType _grossVolumeMeasureField;

        private NetVolumeMeasureType _netVolumeMeasureField;

        private TotalGoodsItemQuantityType _totalGoodsItemQuantityField;

        private TotalTransportHandlingUnitQuantityType _totalTransportHandlingUnitQuantityField;

        private InsuranceValueAmountType _insuranceValueAmountField;

        private DeclaredCustomsValueAmountType _declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType _declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType _declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType _freeOnBoardValueAmountField;

        private SpecialInstructionsType[] _specialInstructionsField;

        private DeliveryInstructionsType[] _deliveryInstructionsField;

        private SplitConsignmentIndicatorType _splitConsignmentIndicatorField;

        private ConsignmentQuantityType _consignmentQuantityField;

        private ConsignmentType[] _consignmentField;

        private GoodsItemType[] _goodsItemField;

        private ShipmentStageType[] _shipmentStageField;

        private DeliveryType _deliveryField;

        private TransportHandlingUnitType[] _transportHandlingUnitField;

        private AddressType _returnAddressField;

        private AddressType _originAddressField;

        private LocationType1 _firstArrivalPortLocationField;

        private LocationType1 _lastExitPortLocationField;

        private CountryType _exportCountryField;

        private AllowanceChargeType[] _freightAllowanceChargeField;

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
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return _shippingPriorityLevelCodeField;
            }
            set
            {
                _shippingPriorityLevelCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information
        {
            get
            {
                return _informationField;
            }
            set
            {
                _informationField = value;
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
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return _totalTransportHandlingUnitQuantityField;
            }
            set
            {
                _totalTransportHandlingUnitQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return _specialInstructionsField;
            }
            set
            {
                _specialInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return _deliveryInstructionsField;
            }
            set
            {
                _deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return _splitConsignmentIndicatorField;
            }
            set
            {
                _splitConsignmentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return _consignmentQuantityField;
            }
            set
            {
                _consignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consignment")]
        public ConsignmentType[] Consignment
        {
            get
            {
                return _consignmentField;
            }
            set
            {
                _consignmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return _shipmentStageField;
            }
            set
            {
                _shipmentStageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return _transportHandlingUnitField;
            }
            set
            {
                _transportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        public AddressType ReturnAddress
        {
            get
            {
                return _returnAddressField;
            }
            set
            {
                _returnAddressField = value;
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
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return _firstArrivalPortLocationField;
            }
            set
            {
                _firstArrivalPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return _lastExitPortLocationField;
            }
            set
            {
                _lastExitPortLocationField = value;
            }
        }

        /// <remarks/>
        public CountryType ExportCountry
        {
            get
            {
                return _exportCountryField;
            }
            set
            {
                _exportCountryField = value;
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
    }
}