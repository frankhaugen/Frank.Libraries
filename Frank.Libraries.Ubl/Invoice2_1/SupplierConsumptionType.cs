namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SupplierConsumptionType
    {

        private DescriptionType[] _descriptionField;

        private PartyType _utilitySupplierPartyField;

        private PartyType _utilityCustomerPartyField;

        private ConsumptionType _consumptionField;

        private ContractType _contractField;

        private ConsumptionLineType[] _consumptionLineField;

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
        public PartyType UtilitySupplierParty
        {
            get
            {
                return _utilitySupplierPartyField;
            }
            set
            {
                _utilitySupplierPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType UtilityCustomerParty
        {
            get
            {
                return _utilityCustomerPartyField;
            }
            set
            {
                _utilityCustomerPartyField = value;
            }
        }

        /// <remarks/>
        public ConsumptionType Consumption
        {
            get
            {
                return _consumptionField;
            }
            set
            {
                _consumptionField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return _contractField;
            }
            set
            {
                _contractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine")]
        public ConsumptionLineType[] ConsumptionLine
        {
            get
            {
                return _consumptionLineField;
            }
            set
            {
                _consumptionLineField = value;
            }
        }
    }
}