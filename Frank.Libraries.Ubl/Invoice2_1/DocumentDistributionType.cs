namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DocumentDistribution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DocumentDistributionType
    {

        private PrintQualifierType _printQualifierField;

        private MaximumCopiesNumericType _maximumCopiesNumericField;

        private PartyType _partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrintQualifierType PrintQualifier
        {
            get
            {
                return _printQualifierField;
            }
            set
            {
                _printQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumCopiesNumericType MaximumCopiesNumeric
        {
            get
            {
                return _maximumCopiesNumericField;
            }
            set
            {
                _maximumCopiesNumericField = value;
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