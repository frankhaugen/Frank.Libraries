namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class RevocationValuesType
    {

        private EncapsulatedPkiDataType[] _cRlValuesField;

        private EncapsulatedPkiDataType[] _oCspValuesField;

        private AnyType[] _otherValuesField;

        private string _idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable = false)]
        public EncapsulatedPkiDataType[] CrlValues
        {
            get
            {
                return _cRlValuesField;
            }
            set
            {
                _cRlValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable = false)]
        public EncapsulatedPkiDataType[] OcspValues
        {
            get
            {
                return _oCspValuesField;
            }
            set
            {
                _oCspValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable = false)]
        public AnyType[] OtherValues
        {
            get
            {
                return _otherValuesField;
            }
            set
            {
                _otherValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }
    }
}