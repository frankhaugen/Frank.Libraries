namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignedInfoType
    {

        private CanonicalizationMethodType1 _canonicalizationMethodField;

        private SignatureMethodType1 _signatureMethodField;

        private ReferenceType1[] _referenceField;

        private string _idField;

        /// <remarks/>
        public CanonicalizationMethodType1 CanonicalizationMethod
        {
            get
            {
                return _canonicalizationMethodField;
            }
            set
            {
                _canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureMethodType1 SignatureMethod
        {
            get
            {
                return _signatureMethodField;
            }
            set
            {
                _signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType1[] Reference
        {
            get
            {
                return _referenceField;
            }
            set
            {
                _referenceField = value;
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