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

        private IDType idField;

        private SequenceNumberIDType sequenceNumberIDField;

        private DescriptionType[] descriptionField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

        private InsuranceValueAmountType insuranceValueAmountField;

        private ValueAmountType valueAmountField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private NetWeightMeasureType netWeightMeasureField;

        private NetNetWeightMeasureType netNetWeightMeasureField;

        private ChargeableWeightMeasureType chargeableWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private NetVolumeMeasureType netVolumeMeasureField;

        private QuantityType2 quantityField;

        private PreferenceCriterionCodeType preferenceCriterionCodeField;

        private RequiredCustomsIDType requiredCustomsIDField;

        private CustomsStatusCodeType customsStatusCodeField;

        private CustomsTariffQuantityType customsTariffQuantityField;

        private CustomsImportClassifiedIndicatorType customsImportClassifiedIndicatorField;

        private ChargeableQuantityType chargeableQuantityField;

        private ReturnableQuantityType returnableQuantityField;

        private TraceIDType traceIDField;

        private ItemType[] itemField;

        private GoodsItemContainerType[] goodsItemContainerField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private InvoiceLineType[] invoiceLineField;

        private TemperatureType[] temperatureField;

        private GoodsItemType[] containedGoodsItemField;

        private AddressType originAddressField;

        private DeliveryType deliveryField;

        private PickupType pickupField;

        private DespatchType despatchField;

        private DimensionType[] measurementDimensionField;

        private PackageType[] containingPackageField;

        private DocumentReferenceType shipmentDocumentReferenceField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

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
        public SequenceNumberIDType SequenceNumberID
        {
            get
            {
                return sequenceNumberIDField;
            }
            set
            {
                sequenceNumberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return hazardousRiskIndicatorField;
            }
            set
            {
                hazardousRiskIndicatorField = value;
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
        public ValueAmountType ValueAmount
        {
            get
            {
                return valueAmountField;
            }
            set
            {
                valueAmountField = value;
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
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return chargeableWeightMeasureField;
            }
            set
            {
                chargeableWeightMeasureField = value;
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
        public PreferenceCriterionCodeType PreferenceCriterionCode
        {
            get
            {
                return preferenceCriterionCodeField;
            }
            set
            {
                preferenceCriterionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredCustomsIDType RequiredCustomsID
        {
            get
            {
                return requiredCustomsIDField;
            }
            set
            {
                requiredCustomsIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsStatusCodeType CustomsStatusCode
        {
            get
            {
                return customsStatusCodeField;
            }
            set
            {
                customsStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsTariffQuantityType CustomsTariffQuantity
        {
            get
            {
                return customsTariffQuantityField;
            }
            set
            {
                customsTariffQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
        {
            get
            {
                return customsImportClassifiedIndicatorField;
            }
            set
            {
                customsImportClassifiedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeableQuantityType ChargeableQuantity
        {
            get
            {
                return chargeableQuantityField;
            }
            set
            {
                chargeableQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReturnableQuantityType ReturnableQuantity
        {
            get
            {
                return returnableQuantityField;
            }
            set
            {
                returnableQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemType[] Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer")]
        public GoodsItemContainerType[] GoodsItemContainer
        {
            get
            {
                return goodsItemContainerField;
            }
            set
            {
                goodsItemContainerField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine")]
        public InvoiceLineType[] InvoiceLine
        {
            get
            {
                return invoiceLineField;
            }
            set
            {
                invoiceLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Temperature")]
        public TemperatureType[] Temperature
        {
            get
            {
                return temperatureField;
            }
            set
            {
                temperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem")]
        public GoodsItemType[] ContainedGoodsItem
        {
            get
            {
                return containedGoodsItemField;
            }
            set
            {
                containedGoodsItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ContainingPackage")]
        public PackageType[] ContainingPackage
        {
            get
            {
                return containingPackageField;
            }
            set
            {
                containingPackageField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ShipmentDocumentReference
        {
            get
            {
                return shipmentDocumentReferenceField;
            }
            set
            {
                shipmentDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MinimumTemperature
        {
            get
            {
                return minimumTemperatureField;
            }
            set
            {
                minimumTemperatureField = value;
            }
        }

        /// <remarks/>
        public TemperatureType MaximumTemperature
        {
            get
            {
                return maximumTemperatureField;
            }
            set
            {
                maximumTemperatureField = value;
            }
        }
    }
}