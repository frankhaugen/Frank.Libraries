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
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return shippingPriorityLevelCodeField;
            }
            set
            {
                shippingPriorityLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return handlingCodeField;
            }
            set
            {
                handlingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HandlingInstructionsType[] HandlingInstructions
        {
            get
            {
                return handlingInstructionsField;
            }
            set
            {
                handlingInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationType[] Information
        {
            get
            {
                return informationField;
            }
            set
            {
                informationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return grossWeightMeasureField;
            }
            set
            {
                grossWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return netWeightMeasureField;
            }
            set
            {
                netWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return netNetWeightMeasureField;
            }
            set
            {
                netNetWeightMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return grossVolumeMeasureField;
            }
            set
            {
                grossVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return netVolumeMeasureField;
            }
            set
            {
                netVolumeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return totalGoodsItemQuantityField;
            }
            set
            {
                totalGoodsItemQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return totalTransportHandlingUnitQuantityField;
            }
            set
            {
                totalTransportHandlingUnitQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return insuranceValueAmountField;
            }
            set
            {
                insuranceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return declaredCustomsValueAmountField;
            }
            set
            {
                declaredCustomsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return declaredForCarriageValueAmountField;
            }
            set
            {
                declaredForCarriageValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return declaredStatisticsValueAmountField;
            }
            set
            {
                declaredStatisticsValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return freeOnBoardValueAmountField;
            }
            set
            {
                freeOnBoardValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return specialInstructionsField;
            }
            set
            {
                specialInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return deliveryInstructionsField;
            }
            set
            {
                deliveryInstructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return splitConsignmentIndicatorField;
            }
            set
            {
                splitConsignmentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return consignmentQuantityField;
            }
            set
            {
                consignmentQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consignment")]
        public ConsignmentType[] Consignment
        {
            get
            {
                return consignmentField;
            }
            set
            {
                consignmentField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return shipmentStageField;
            }
            set
            {
                shipmentStageField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return transportHandlingUnitField;
            }
            set
            {
                transportHandlingUnitField = value;
            }
        }

        /// <remarks/>
        public AddressType ReturnAddress
        {
            get
            {
                return returnAddressField;
            }
            set
            {
                returnAddressField = value;
            }
        }

        /// <remarks/>
        public AddressType OriginAddress
        {
            get
            {
                return originAddressField;
            }
            set
            {
                originAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return firstArrivalPortLocationField;
            }
            set
            {
                firstArrivalPortLocationField = value;
            }
        }

        /// <remarks/>
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return lastExitPortLocationField;
            }
            set
            {
                lastExitPortLocationField = value;
            }
        }

        /// <remarks/>
        public CountryType ExportCountry
        {
            get
            {
                return exportCountryField;
            }
            set
            {
                exportCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return freightAllowanceChargeField;
            }
            set
            {
                freightAllowanceChargeField = value;
            }
        }
    }
}