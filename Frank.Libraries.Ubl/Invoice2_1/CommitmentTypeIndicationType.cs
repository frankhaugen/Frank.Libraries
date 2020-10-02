namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CommitmentTypeIndicationType
    {

        private ObjectIdentifierType _commitmentTypeIdField;

        private object[] _itemsField;

        private AnyType[] _commitmentTypeQualifiersField;

        /// <remarks/>
        public ObjectIdentifierType CommitmentTypeId
        {
            get
            {
                return _commitmentTypeIdField;
            }
            set
            {
                _commitmentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType = "anyURI")]
        public object[] Items
        {
            get
            {
                return _itemsField;
            }
            set
            {
                _itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable = false)]
        public AnyType[] CommitmentTypeQualifiers
        {
            get
            {
                return _commitmentTypeQualifiersField;
            }
            set
            {
                _commitmentTypeQualifiersField = value;
            }
        }
    }
}