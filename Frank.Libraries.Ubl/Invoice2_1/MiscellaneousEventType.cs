namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("MiscellaneousEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MiscellaneousEventType
    {

        private MiscellaneousEventTypeCodeType _miscellaneousEventTypeCodeField;

        private EventLineItemType[] _eventLineItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode
        {
            get
            {
                return _miscellaneousEventTypeCodeField;
            }
            set
            {
                _miscellaneousEventTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventLineItem")]
        public EventLineItemType[] EventLineItem
        {
            get
            {
                return _eventLineItemField;
            }
            set
            {
                _eventLineItemField = value;
            }
        }
    }
}