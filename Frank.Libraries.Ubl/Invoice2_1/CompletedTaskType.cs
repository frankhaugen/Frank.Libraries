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

        private AnnualAverageAmountType annualAverageAmountField;

        private TotalTaskAmountType totalTaskAmountField;

        private PartyCapacityAmountType partyCapacityAmountField;

        private DescriptionType[] descriptionField;

        private EvidenceSuppliedType[] evidenceSuppliedField;

        private PeriodType periodField;

        private CustomerPartyType recipientCustomerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AnnualAverageAmountType AnnualAverageAmount
        {
            get
            {
                return annualAverageAmountField;
            }
            set
            {
                annualAverageAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalTaskAmountType TotalTaskAmount
        {
            get
            {
                return totalTaskAmountField;
            }
            set
            {
                totalTaskAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartyCapacityAmountType PartyCapacityAmount
        {
            get
            {
                return partyCapacityAmountField;
            }
            set
            {
                partyCapacityAmountField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied")]
        public EvidenceSuppliedType[] EvidenceSupplied
        {
            get
            {
                return evidenceSuppliedField;
            }
            set
            {
                evidenceSuppliedField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
        {
            get
            {
                return periodField;
            }
            set
            {
                periodField = value;
            }
        }

        /// <remarks/>
        public CustomerPartyType RecipientCustomerParty
        {
            get
            {
                return recipientCustomerPartyField;
            }
            set
            {
                recipientCustomerPartyField = value;
            }
        }
    }
}