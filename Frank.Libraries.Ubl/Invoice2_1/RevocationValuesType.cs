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

        private EncapsulatedPKIDataType[] cRLValuesField;

        private EncapsulatedPKIDataType[] oCSPValuesField;

        private AnyType[] otherValuesField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable = false)]
        public EncapsulatedPKIDataType[] CRLValues
        {
            get
            {
                return cRLValuesField;
            }
            set
            {
                cRLValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable = false)]
        public EncapsulatedPKIDataType[] OCSPValues
        {
            get
            {
                return oCSPValuesField;
            }
            set
            {
                oCSPValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable = false)]
        public AnyType[] OtherValues
        {
            get
            {
                return otherValuesField;
            }
            set
            {
                otherValuesField = value;
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