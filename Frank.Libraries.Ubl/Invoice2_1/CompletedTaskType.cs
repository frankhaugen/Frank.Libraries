namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CompletedTask", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CompletedTaskType
    {

        private AnnualAverageAmountType _annualAverageAmountField;

        private TotalTaskAmountType _totalTaskAmountField;

        private PartyCapacityAmountType _partyCapacityAmountField;

        private DescriptionType[] _descriptionField;

        private EvidenceSuppliedType[] _evidenceSuppliedField;

        private PeriodType _periodField;

        private CustomerPartyType _recipientCustomerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnnualAverageAmountType AnnualAverageAmount
        {
            get
            {
                return _annualAverageAmountField;
            }
            set
            {
                _annualAverageAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaskAmountType TotalTaskAmount
        {
            get
            {
                return _totalTaskAmountField;
            }
            set
            {
                _totalTaskAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartyCapacityAmountType PartyCapacityAmount
        {
            get
            {
                return _partyCapacityAmountField;
            }
            set
            {
                _partyCapacityAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied")]
        public EvidenceSuppliedType[] EvidenceSupplied
        {
            get
            {
                return _evidenceSuppliedField;
            }
            set
            {
                _evidenceSuppliedField = value;
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
        public CustomerPartyType RecipientCustomerParty
        {
            get
            {
                return _recipientCustomerPartyField;
            }
            set
            {
                _recipientCustomerPartyField = value;
            }
        }
    }
}