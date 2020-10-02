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

        private IdType _idField;

        private NameType1[] _nameField;

        private DescriptionType[] _descriptionField;

        private ProcurementTypeCodeType _procurementTypeCodeField;

        private ProcurementSubTypeCodeType _procurementSubTypeCodeField;

        private QualityControlCodeType _qualityControlCodeField;

        private RequiredFeeAmountType _requiredFeeAmountField;

        private FeeDescriptionType[] _feeDescriptionField;

        private RequestedDeliveryDateType _requestedDeliveryDateField;

        private EstimatedOverallContractQuantityType _estimatedOverallContractQuantityField;

        private NoteType[] _noteField;

        private RequestedTenderTotalType _requestedTenderTotalField;

        private CommodityClassificationType _mainCommodityClassificationField;

        private CommodityClassificationType[] _additionalCommodityClassificationField;

        private LocationType1[] _realizedLocationField;

        private PeriodType _plannedPeriodField;

        private ContractExtensionType _contractExtensionField;

        private RequestForTenderLineType[] _requestForTenderLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1[] Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
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
        public ProcurementTypeCodeType ProcurementTypeCode
        {
            get
            {
                return _procurementTypeCodeField;
            }
            set
            {
                _procurementTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcurementSubTypeCodeType ProcurementSubTypeCode
        {
            get
            {
                return _procurementSubTypeCodeField;
            }
            set
            {
                _procurementSubTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QualityControlCodeType QualityControlCode
        {
            get
            {
                return _qualityControlCodeField;
            }
            set
            {
                _qualityControlCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequiredFeeAmountType RequiredFeeAmount
        {
            get
            {
                return _requiredFeeAmountField;
            }
            set
            {
                _requiredFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return _feeDescriptionField;
            }
            set
            {
                _feeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RequestedDeliveryDateType RequestedDeliveryDate
        {
            get
            {
                return _requestedDeliveryDateField;
            }
            set
            {
                _requestedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
        {
            get
            {
                return _estimatedOverallContractQuantityField;
            }
            set
            {
                _estimatedOverallContractQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        public RequestedTenderTotalType RequestedTenderTotal
        {
            get
            {
                return _requestedTenderTotalField;
            }
            set
            {
                _requestedTenderTotalField = value;
            }
        }

        /// <remarks/>
        public CommodityClassificationType MainCommodityClassification
        {
            get
            {
                return _mainCommodityClassificationField;
            }
            set
            {
                _mainCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalCommodityClassification")]
        public CommodityClassificationType[] AdditionalCommodityClassification
        {
            get
            {
                return _additionalCommodityClassificationField;
            }
            set
            {
                _additionalCommodityClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RealizedLocation")]
        public LocationType1[] RealizedLocation
        {
            get
            {
                return _realizedLocationField;
            }
            set
            {
                _realizedLocationField = value;
            }
        }

        /// <remarks/>
        public PeriodType PlannedPeriod
        {
            get
            {
                return _plannedPeriodField;
            }
            set
            {
                _plannedPeriodField = value;
            }
        }

        /// <remarks/>
        public ContractExtensionType ContractExtension
        {
            get
            {
                return _contractExtensionField;
            }
            set
            {
                _contractExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine")]
        public RequestForTenderLineType[] RequestForTenderLine
        {
            get
            {
                return _requestForTenderLineField;
            }
            set
            {
                _requestForTenderLineField = value;
            }
        }
    }
}