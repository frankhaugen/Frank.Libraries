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

        private IDType idField;

        private TransportHandlingUnitTypeCodeType transportHandlingUnitTypeCodeField;

        private HandlingCodeType handlingCodeField;

        private HandlingInstructionsType[] handlingInstructionsField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

        private TotalPackageQuantityType totalPackageQuantityField;

        private DamageRemarksType[] damageRemarksField;

        private ShippingMarksType[] shippingMarksField;

        private TraceIDType traceIDField;

        private DespatchLineType[] handlingUnitDespatchLineField;

        private PackageType[] actualPackageField;

        private ReceiptLineType[] receivedHandlingUnitReceiptLineField;

        private TransportEquipmentType[] transportEquipmentField;

        private TransportMeansType[] transportMeansField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private DimensionType[] measurementDimensionField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private GoodsItemType[] goodsItemField;

        private DimensionType floorSpaceMeasurementDimensionField;

        private DimensionType palletSpaceMeasurementDimensionField;

        private DocumentReferenceType[] shipmentDocumentReferenceField;

        private StatusType[] statusField;

        private CustomsDeclarationType[] customsDeclarationField;

        private ShipmentType[] referencedShipmentField;

        private PackageType[] packageField;

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
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return transportHandlingUnitTypeCodeField;
            }
            set
            {
                transportHandlingUnitTypeCodeField = value;
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
        public TotalPackageQuantityType TotalPackageQuantity
        {
            get
            {
                return totalPackageQuantityField;
            }
            set
            {
                totalPackageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DamageRemarksType[] DamageRemarks
        {
            get
            {
                return damageRemarksField;
            }
            set
            {
                damageRemarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ShippingMarksType[] ShippingMarks
        {
            get
            {
                return shippingMarksField;
            }
            set
            {
                shippingMarksField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine")]
        public DespatchLineType[] HandlingUnitDespatchLine
        {
            get
            {
                return handlingUnitDespatchLineField;
            }
            set
            {
                handlingUnitDespatchLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
        public PackageType[] ActualPackage
        {
            get
            {
                return actualPackageField;
            }
            set
            {
                actualPackageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
        public ReceiptLineType[] ReceivedHandlingUnitReceiptLine
        {
            get
            {
                return receivedHandlingUnitReceiptLineField;
            }
            set
            {
                receivedHandlingUnitReceiptLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return transportEquipmentField;
            }
            set
            {
                transportEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportMeans")]
        public TransportMeansType[] TransportMeans
        {
            get
            {
                return transportMeansField;
            }
            set
            {
                transportMeansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return hazardousGoodsTransitField;
            }
            set
            {
                hazardousGoodsTransitField = value;
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
        public DimensionType FloorSpaceMeasurementDimension
        {
            get
            {
                return floorSpaceMeasurementDimensionField;
            }
            set
            {
                floorSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        public DimensionType PalletSpaceMeasurementDimension
        {
            get
            {
                return palletSpaceMeasurementDimensionField;
            }
            set
            {
                palletSpaceMeasurementDimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
        public DocumentReferenceType[] ShipmentDocumentReference
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
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public StatusType[] Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
        public CustomsDeclarationType[] CustomsDeclaration
        {
            get
            {
                return customsDeclarationField;
            }
            set
            {
                customsDeclarationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedShipment")]
        public ShipmentType[] ReferencedShipment
        {
            get
            {
                return referencedShipmentField;
            }
            set
            {
                referencedShipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Package")]
        public PackageType[] Package
        {
            get
            {
                return packageField;
            }
            set
            {
                packageField = value;
            }
        }
    }
}