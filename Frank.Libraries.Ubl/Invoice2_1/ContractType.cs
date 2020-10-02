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

        private IDType idField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private NominationDateType nominationDateField;

        private NominationTimeType nominationTimeField;

        private ContractTypeCodeType contractTypeCodeField;

        private ContractTypeType contractType1Field;

        private NoteType[] noteField;

        private VersionIDType versionIDField;

        private DescriptionType[] descriptionField;

        private PeriodType validityPeriodField;

        private DocumentReferenceType[] contractDocumentReferenceField;

        private PeriodType nominationPeriodField;

        private DeliveryType contractualDeliveryField;

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
        public IssueDateType IssueDate
        {
            get
            {
                return issueDateField;
            }
            set
            {
                issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return issueTimeField;
            }
            set
            {
                issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationDateType NominationDate
        {
            get
            {
                return nominationDateField;
            }
            set
            {
                nominationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NominationTimeType NominationTime
        {
            get
            {
                return nominationTimeField;
            }
            set
            {
                nominationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractTypeCodeType ContractTypeCode
        {
            get
            {
                return contractTypeCodeField;
            }
            set
            {
                contractTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractTypeType ContractType1
        {
            get
            {
                return contractType1Field;
            }
            set
            {
                contractType1Field = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionIDType VersionID
        {
            get
            {
                return versionIDField;
            }
            set
            {
                versionIDField = value;
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
        public PeriodType ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return contractDocumentReferenceField;
            }
            set
            {
                contractDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public PeriodType NominationPeriod
        {
            get
            {
                return nominationPeriodField;
            }
            set
            {
                nominationPeriodField = value;
            }
        }

        /// <remarks/>
        public DeliveryType ContractualDelivery
        {
            get
            {
                return contractualDeliveryField;
            }
            set
            {
                contractualDeliveryField = value;
            }
        }
    }
}