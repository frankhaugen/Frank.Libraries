namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionReportType
    {

        private IdType _idField;

        private ConsumptionTypeType _consumptionTypeField;

        private ConsumptionTypeCodeType _consumptionTypeCodeField;

        private DescriptionType[] _descriptionField;

        private TotalConsumedQuantityType _totalConsumedQuantityField;

        private BasicConsumedQuantityType _basicConsumedQuantityField;

        private ResidentOccupantsNumericType _residentOccupantsNumericField;

        private ConsumersEnergyLevelCodeType _consumersEnergyLevelCodeField;

        private ConsumersEnergyLevelType _consumersEnergyLevelField;

        private ResidenceTypeType _residenceTypeField;

        private ResidenceTypeCodeType _residenceTypeCodeField;

        private HeatingTypeType _heatingTypeField;

        private HeatingTypeCodeType _heatingTypeCodeField;

        private PeriodType _periodField;

        private DocumentReferenceType _guidanceDocumentReferenceField;

        private DocumentReferenceType _documentReferenceField;

        private ConsumptionReportReferenceType[] _consumptionReportReferenceField;

        private ConsumptionHistoryType[] _consumptionHistoryField;

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
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return _consumptionTypeField;
            }
            set
            {
                _consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return _consumptionTypeCodeField;
            }
            set
            {
                _consumptionTypeCodeField = value;
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
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return _totalConsumedQuantityField;
            }
            set
            {
                _totalConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BasicConsumedQuantityType BasicConsumedQuantity
        {
            get
            {
                return _basicConsumedQuantityField;
            }
            set
            {
                _basicConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidentOccupantsNumericType ResidentOccupantsNumeric
        {
            get
            {
                return _residentOccupantsNumericField;
            }
            set
            {
                _residentOccupantsNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode
        {
            get
            {
                return _consumersEnergyLevelCodeField;
            }
            set
            {
                _consumersEnergyLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumersEnergyLevelType ConsumersEnergyLevel
        {
            get
            {
                return _consumersEnergyLevelField;
            }
            set
            {
                _consumersEnergyLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidenceTypeType ResidenceType
        {
            get
            {
                return _residenceTypeField;
            }
            set
            {
                _residenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidenceTypeCodeType ResidenceTypeCode
        {
            get
            {
                return _residenceTypeCodeField;
            }
            set
            {
                _residenceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HeatingTypeType HeatingType
        {
            get
            {
                return _heatingTypeField;
            }
            set
            {
                _heatingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HeatingTypeCodeType HeatingTypeCode
        {
            get
            {
                return _heatingTypeCodeField;
            }
            set
            {
                _heatingTypeCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
        {
            get
            {
                return _periodField;
            }
            set
            {
                _periodField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType GuidanceDocumentReference
        {
            get
            {
                return _guidanceDocumentReferenceField;
            }
            set
            {
                _guidanceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReportReference")]
        public ConsumptionReportReferenceType[] ConsumptionReportReference
        {
            get
            {
                return _consumptionReportReferenceField;
            }
            set
            {
                _consumptionReportReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionHistory")]
        public ConsumptionHistoryType[] ConsumptionHistory
        {
            get
            {
                return _consumptionHistoryField;
            }
            set
            {
                _consumptionHistoryField = value;
            }
        }
    }
}