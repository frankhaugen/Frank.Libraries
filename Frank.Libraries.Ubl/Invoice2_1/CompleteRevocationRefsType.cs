namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CompleteRevocationRefsType
    {

        private CrlRefType[] _cRlRefsField;

        private OcspRefType[] _oCspRefsField;

        private AnyType[] _otherRefsField;

        private string _idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
        public CrlRefType[] CrlRefs
        {
            get
            {
                return _cRlRefsField;
            }
            set
            {
                _cRlRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
        public OcspRefType[] OcspRefs
        {
            get
            {
                return _oCspRefsField;
            }
            set
            {
                _oCspRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
        public AnyType[] OtherRefs
        {
            get
            {
                return _otherRefsField;
            }
            set
            {
                _otherRefsField = value;
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