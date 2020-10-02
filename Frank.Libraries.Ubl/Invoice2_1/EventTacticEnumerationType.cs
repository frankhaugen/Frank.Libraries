namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EventTacticEnumerationType
    {

        private ConsumerIncentiveTacticTypeCodeType _consumerIncentiveTacticTypeCodeField;

        private DisplayTacticTypeCodeType _displayTacticTypeCodeField;

        private FeatureTacticTypeCodeType _featureTacticTypeCodeField;

        private TradeItemPackingLabelingTypeCodeType _tradeItemPackingLabelingTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
        {
            get
            {
                return _consumerIncentiveTacticTypeCodeField;
            }
            set
            {
                _consumerIncentiveTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DisplayTacticTypeCodeType DisplayTacticTypeCode
        {
            get
            {
                return _displayTacticTypeCodeField;
            }
            set
            {
                _displayTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeatureTacticTypeCodeType FeatureTacticTypeCode
        {
            get
            {
                return _featureTacticTypeCodeField;
            }
            set
            {
                _featureTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
        {
            get
            {
                return _tradeItemPackingLabelingTypeCodeField;
            }
            set
            {
                _tradeItemPackingLabelingTypeCodeField = value;
            }
        }
    }
}