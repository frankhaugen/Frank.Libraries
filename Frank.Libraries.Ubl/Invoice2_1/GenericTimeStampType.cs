namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdEsTimeStampType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public abstract partial class GenericTimeStampType
    {

        private object[] _itemsField;

        private CanonicalizationMethodType1 _canonicalizationMethodField;

        private object[] _items1Field;

        private string _idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
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
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPkiDataType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
        public object[] Items1
        {
            get
            {
                return _items1Field;
            }
            set
            {
                _items1Field = value;
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