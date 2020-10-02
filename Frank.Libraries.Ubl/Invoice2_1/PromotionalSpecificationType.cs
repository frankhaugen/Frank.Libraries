namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PromotionalSpecification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PromotionalSpecificationType
    {

        private SpecificationIdType _specificationIdField;

        private PromotionalEventLineItemType[] _promotionalEventLineItemField;

        private EventTacticType[] _eventTacticField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecificationIdType SpecificationId
        {
            get
            {
                return _specificationIdField;
            }
            set
            {
                _specificationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalEventLineItem")]
        public PromotionalEventLineItemType[] PromotionalEventLineItem
        {
            get
            {
                return _promotionalEventLineItemField;
            }
            set
            {
                _promotionalEventLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventTactic")]
        public EventTacticType[] EventTactic
        {
            get
            {
                return _eventTacticField;
            }
            set
            {
                _eventTacticField = value;
            }
        }
    }
}