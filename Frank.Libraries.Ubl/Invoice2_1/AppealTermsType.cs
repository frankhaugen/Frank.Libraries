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

        private DescriptionType[] _descriptionField;

        private PeriodType _presentationPeriodField;

        private PartyType _appealInformationPartyField;

        private PartyType _appealReceiverPartyField;

        private PartyType _mediationPartyField;

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
        public PeriodType PresentationPeriod
        {
            get
            {
                return _presentationPeriodField;
            }
            set
            {
                _presentationPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealInformationParty
        {
            get
            {
                return _appealInformationPartyField;
            }
            set
            {
                _appealInformationPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType AppealReceiverParty
        {
            get
            {
                return _appealReceiverPartyField;
            }
            set
            {
                _appealReceiverPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType MediationParty
        {
            get
            {
                return _mediationPartyField;
            }
            set
            {
                _mediationPartyField = value;
            }
        }
    }
}