namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AppealTermsType
    {

        private DescriptionType[] descriptionField;

        private PeriodType presentationPeriodField;

        private PartyType appealInformationPartyField;

        private PartyType appealReceiverPartyField;

        private PartyType mediationPartyField;

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
        public PeriodType PresentationPeriod
        {
            get
            {
                return presentationPeriodField;
            }
            set
            {
                presentationPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealInformationParty
        {
            get
            {
                return appealInformationPartyField;
            }
            set
            {
                appealInformationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealReceiverParty
        {
            get
            {
                return appealReceiverPartyField;
            }
            set
            {
                appealReceiverPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType MediationParty
        {
            get
            {
                return mediationPartyField;
            }
            set
            {
                mediationPartyField = value;
            }
        }
    }
}