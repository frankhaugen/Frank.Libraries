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

        private CRLRefType[] cRLRefsField;

        private OCSPRefType[] oCSPRefsField;

        private AnyType[] otherRefsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
        public CRLRefType[] CRLRefs
        {
            get
            {
                return cRLRefsField;
            }
            set
            {
                cRLRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
        public OCSPRefType[] OCSPRefs
        {
            get
            {
                return oCSPRefsField;
            }
            set
            {
                oCSPRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
        public AnyType[] OtherRefs
        {
            get
            {
                return otherRefsField;
            }
            set
            {
                otherRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }
}