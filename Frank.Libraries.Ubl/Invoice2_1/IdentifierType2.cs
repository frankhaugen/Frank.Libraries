namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IdentifierType2
    {

        private QualifierType _qualifierField;

        private bool _qualifierFieldSpecified;

        private string _valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QualifierType Qualifier
        {
            get
            {
                return _qualifierField;
            }
            set
            {
                _qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifierSpecified
        {
            get
            {
                return _qualifierFieldSpecified;
            }
            set
            {
                _qualifierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "anyURI")]
        public string Value
        {
            get
            {
                return _valueField;
            }
            set
            {
                _valueField = value;
            }
        }
    }
}