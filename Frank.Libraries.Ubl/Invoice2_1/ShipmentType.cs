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

        private IDType idField;

        private ShippingPriorityLevelCodeType shippingPriorityLevelCodeField;

        private HandlingCodeType handlingCodeField;

        private HandlingInstructionsType[] handlingInstructionsField;

        private InformationType[] informationField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private NetWeightMeasureType netWeightMeasureField;

        private NetNetWeightMeasureType netNetWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private NetVolumeMeasureType netVolumeMeasureField;

        private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

        private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

        private InsuranceValueAmountType insuranceValueAmountField;

        private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

        private SpecialInstructionsType[] specialInstructionsField;

        private DeliveryInstructionsType[] deliveryInstructionsField;

        private SplitConsignmentIndicatorType splitConsignmentIndicatorField;

        private ConsignmentQuantityType consignmentQuantityField;

        private ConsignmentType[] consignmentField;

        private GoodsItemType[] goodsItemField;

        private ShipmentStageType[] shipmentStageField;

        private DeliveryType deliveryField;

        private TransportHandlingUnitType[] transportHandlingUnitField;

        private AddressType returnAddressField;

        private AddressType originAddressField;

        private LocationType1 firstArrivalPortLocationField;

        private LocationType1 lastExitPortLocationField;

        private CountryType exportCountryField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return this.shippingPriorityLevelCodeField;
            }
            set
            {
                this.shippingPriorityLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return this.handlingCodeField;
            }
            set
            {
                this.handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions
        {
            get
            {
                return this.handlingInstructionsField;
            }
            set
            {
                this.handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return this.netNetWeightMeasureField;
            }
            set
            {
                this.netNetWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return this.grossVolumeMeasureField;
            }
            set
            {
                this.grossVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return this.totalGoodsItemQuantityField;
            }
            set
            {
                this.totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return this.totalTransportHandlingUnitQuantityField;
            }
            set
            {
                this.totalTransportHandlingUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return this.insuranceValueAmountField;
            }
            set
            {
                this.insuranceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return this.declaredCustomsValueAmountField;
            }
            set
            {
                this.declaredCustomsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return this.declaredForCarriageValueAmountField;
            }
            set
            {
                this.declaredForCarriageValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return this.declaredStatisticsValueAmountField;
            }
            set
            {
                this.declaredStatisticsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return this.freeOnBoardValueAmountField;
            }
            set
            {
                this.freeOnBoardValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return this.specialInstructionsField;
            }
            set
            {
                this.specialInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return this.deliveryInstructionsField;
            }
            set
            {
                this.deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return this.splitConsignmentIndicatorField;
            }
            set
            {
                this.splitConsignmentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return this.consignmentQuantityField;
            }
            set
            {
                this.consignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consignment")]
        public ConsignmentType[] Consignment
        {
            get
            {
                return this.consignmentField;
            }
            set
            {
                this.consignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return this.goodsItemField;
            }
            set
            {
                this.goodsItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return this.shipmentStageField;
            }
            set
            {
                this.shipmentStageField = value;
            }
        }

        /// <remarks/>
        public DeliveryType Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return this.transportHandlingUnitField;
            }
            set
            {
                this.transportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        public AddressType ReturnAddress
        {
            get
            {
                return this.returnAddressField;
            }
            set
            {
                this.returnAddressField = value;
            }
        }

        /// <remarks/>
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return this.firstArrivalPortLocationField;
            }
            set
            {
                this.firstArrivalPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return this.lastExitPortLocationField;
            }
            set
            {
                this.lastExitPortLocationField = value;
            }
        }

        /// <remarks/>
        public CountryType ExportCountry
        {
            get
            {
                return this.exportCountryField;
            }
            set
            {
                this.exportCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return this.freightAllowanceChargeField;
            }
            set
            {
                this.freightAllowanceChargeField = value;
            }
        }
    }
}