namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractType
    {

        private IdType _idField;

        private IssueDateType _issueDateField;

        private IssueTimeType _issueTimeField;

        private NominationDateType _nominationDateField;

        private NominationTimeType _nominationTimeField;

        private ContractTypeCodeType _contractTypeCodeField;

        private ContractTypeType _contractType1Field;

        private NoteType[] _noteField;

        private VersionIdType _versionIdField;

        private DescriptionType[] _descriptionField;

        private PeriodType _validityPeriodField;

        private DocumentReferenceType[] _contractDocumentReferenceField;

        private PeriodType _nominationPeriodField;

        private DeliveryType _contractualDeliveryField;

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
        public IssueDateType IssueDate
        {
            get
            {
                return _issueDateField;
            }
            set
            {
                _issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return _issueTimeField;
            }
            set
            {
                _issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationDateType NominationDate
        {
            get
            {
                return _nominationDateField;
            }
            set
            {
                _nominationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationTimeType NominationTime
        {
            get
            {
                return _nominationTimeField;
            }
            set
            {
                _nominationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractTypeCodeType ContractTypeCode
        {
            get
            {
                return _contractTypeCodeField;
            }
            set
            {
                _contractTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractTypeType ContractType1
        {
            get
            {
                return _contractType1Field;
            }
            set
            {
                _contractType1Field = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionIdType VersionId
        {
            get
            {
                return _versionIdField;
            }
            set
            {
                _versionIdField = value;
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
        public PeriodType ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return _contractDocumentReferenceField;
            }
            set
            {
                _contractDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public PeriodType NominationPeriod
        {
            get
            {
                return _nominationPeriodField;
            }
            set
            {
                _nominationPeriodField = value;
            }
        }

        /// <remarks/>
        public DeliveryType ContractualDelivery
        {
            get
            {
                return _contractualDeliveryField;
            }
            set
            {
                _contractualDeliveryField = value;
            }
        }
    }
}