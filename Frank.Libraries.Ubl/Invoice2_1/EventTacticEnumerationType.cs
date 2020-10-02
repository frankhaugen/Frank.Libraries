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

        private ConsumerIncentiveTacticTypeCodeType consumerIncentiveTacticTypeCodeField;

        private DisplayTacticTypeCodeType displayTacticTypeCodeField;

        private FeatureTacticTypeCodeType featureTacticTypeCodeField;

        private TradeItemPackingLabelingTypeCodeType tradeItemPackingLabelingTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
        {
            get
            {
                return consumerIncentiveTacticTypeCodeField;
            }
            set
            {
                consumerIncentiveTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DisplayTacticTypeCodeType DisplayTacticTypeCode
        {
            get
            {
                return displayTacticTypeCodeField;
            }
            set
            {
                displayTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FeatureTacticTypeCodeType FeatureTacticTypeCode
        {
            get
            {
                return featureTacticTypeCodeField;
            }
            set
            {
                featureTacticTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
        {
            get
            {
                return tradeItemPackingLabelingTypeCodeField;
            }
            set
            {
                tradeItemPackingLabelingTypeCodeField = value;
            }
        }
    }
}