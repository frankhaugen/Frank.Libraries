namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ShareholderPartyType
    {

        private PartecipationPercentType _partecipationPercentField;

        private PartyType _partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartecipationPercentType PartecipationPercent
        {
            get
            {
                return _partecipationPercentField;
            }
            set
            {
                _partecipationPercentField = value;
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