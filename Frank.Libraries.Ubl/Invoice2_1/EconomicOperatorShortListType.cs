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

        private LimitationDescriptionType[] limitationDescriptionField;

        private ExpectedQuantityType expectedQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private MinimumQuantityType minimumQuantityField;

        private PartyType[] preSelectedPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LimitationDescriptionType[] LimitationDescription
        {
            get
            {
                return limitationDescriptionField;
            }
            set
            {
                limitationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpectedQuantityType ExpectedQuantity
        {
            get
            {
                return expectedQuantityField;
            }
            set
            {
                expectedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return maximumQuantityField;
            }
            set
            {
                maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return minimumQuantityField;
            }
            set
            {
                minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreSelectedParty")]
        public PartyType[] PreSelectedParty
        {
            get
            {
                return preSelectedPartyField;
            }
            set
            {
                preSelectedPartyField = value;
            }
        }
    }
}