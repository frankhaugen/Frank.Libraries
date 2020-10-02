namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ContractingPartyType
    {

        private BuyerProfileUriType _buyerProfileUriField;

        private ContractingPartyTypeType[] _contractingPartyType1Field;

        private ContractingActivityType[] _contractingActivityField;

        private PartyType _partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerProfileUriType BuyerProfileUri
        {
            get
            {
                return _buyerProfileUriField;
            }
            set
            {
                _buyerProfileUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractingPartyType")]
        public ContractingPartyTypeType[] ContractingPartyType1
        {
            get
            {
                return _contractingPartyType1Field;
            }
            set
            {
                _contractingPartyType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractingActivity")]
        public ContractingActivityType[] ContractingActivity
        {
            get
            {
                return _contractingActivityField;
            }
            set
            {
                _contractingActivityField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return _partyField;
            }
            set
            {
                _partyField = value;
            }
        }
    }
}