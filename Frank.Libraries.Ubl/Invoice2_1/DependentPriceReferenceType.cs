namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DependentPriceReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DependentPriceReferenceType
    {

        private PercentType1 _percentField;

        private AddressType _locationAddressField;

        private LineReferenceType _dependentLineReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return _percentField;
            }
            set
            {
                _percentField = value;
            }
        }

        /// <remarks/>
        public AddressType LocationAddress
        {
            get
            {
                return _locationAddressField;
            }
            set
            {
                _locationAddressField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType DependentLineReference
        {
            get
            {
                return _dependentLineReferenceField;
            }
            set
            {
                _dependentLineReferenceField = value;
            }
        }
    }
}