namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EconomicOperatorShortList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EconomicOperatorShortListType
    {

        private LimitationDescriptionType[] _limitationDescriptionField;

        private ExpectedQuantityType _expectedQuantityField;

        private MaximumQuantityType _maximumQuantityField;

        private MinimumQuantityType _minimumQuantityField;

        private PartyType[] _preSelectedPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LimitationDescriptionType[] LimitationDescription
        {
            get
            {
                return _limitationDescriptionField;
            }
            set
            {
                _limitationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpectedQuantityType ExpectedQuantity
        {
            get
            {
                return _expectedQuantityField;
            }
            set
            {
                _expectedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return _maximumQuantityField;
            }
            set
            {
                _maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return _minimumQuantityField;
            }
            set
            {
                _minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreSelectedParty")]
        public PartyType[] PreSelectedParty
        {
            get
            {
                return _preSelectedPartyField;
            }
            set
            {
                _preSelectedPartyField = value;
            }
        }
    }
}