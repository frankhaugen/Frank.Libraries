namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ProcurementProjectType
    {

        private IDType idField;

        private NameType1[] nameField;

        private DescriptionType[] descriptionField;

        private ProcurementTypeCodeType procurementTypeCodeField;

        private ProcurementSubTypeCodeType procurementSubTypeCodeField;

        private QualityControlCodeType qualityControlCodeField;

        private RequiredFeeAmountType requiredFeeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private RequestedDeliveryDateType requestedDeliveryDateField;

        private EstimatedOverallContractQuantityType estimatedOverallContractQuantityField;

        private NoteType[] noteField;

        private RequestedTenderTotalType requestedTenderTotalField;

        private CommodityClassificationType mainCommodityClassificationField;

        private CommodityClassificationType[] additionalCommodityClassificationField;

        private LocationType1[] realizedLocationField;

        private PeriodType plannedPeriodField;

        private ContractExtensionType contractExtensionField;

        private RequestForTenderLineType[] requestForTenderLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1[] Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
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
        public ProcurementTypeCodeType ProcurementTypeCode
        {
            get
            {
                return procurementTypeCodeField;
            }
            set
            {
                procurementTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcurementSubTypeCodeType ProcurementSubTypeCode
        {
            get
            {
                return procurementSubTypeCodeField;
            }
            set
            {
                procurementSubTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QualityControlCodeType QualityControlCode
        {
            get
            {
                return qualityControlCodeField;
            }
            set
            {
                qualityControlCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredFeeAmountType RequiredFeeAmount
        {
            get
            {
                return requiredFeeAmountField;
            }
            set
            {
                requiredFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return feeDescriptionField;
            }
            set
            {
                feeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedDeliveryDateType RequestedDeliveryDate
        {
            get
            {
                return requestedDeliveryDateField;
            }
            set
            {
                requestedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
        {
            get
            {
                return estimatedOverallContractQuantityField;
            }
            set
            {
                estimatedOverallContractQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        public RequestedTenderTotalType RequestedTenderTotal
        {
            get
            {
                return requestedTenderTotalField;
            }
            set
            {
                requestedTenderTotalField = value;
            }
        }

        /// <remarks/>
        public CommodityClassificationType MainCommodityClassification
        {
            get
            {
                return mainCommodityClassificationField;
            }
            set
            {
                mainCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalCommodityClassification")]
        public CommodityClassificationType[] AdditionalCommodityClassification
        {
            get
            {
                return additionalCommodityClassificationField;
            }
            set
            {
                additionalCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RealizedLocation")]
        public LocationType1[] RealizedLocation
        {
            get
            {
                return realizedLocationField;
            }
            set
            {
                realizedLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType PlannedPeriod
        {
            get
            {
                return plannedPeriodField;
            }
            set
            {
                plannedPeriodField = value;
            }
        }

        /// <remarks/>
        public ContractExtensionType ContractExtension
        {
            get
            {
                return contractExtensionField;
            }
            set
            {
                contractExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine")]
        public RequestForTenderLineType[] RequestForTenderLine
        {
            get
            {
                return requestForTenderLineField;
            }
            set
            {
                requestForTenderLineField = value;
            }
        }
    }
}