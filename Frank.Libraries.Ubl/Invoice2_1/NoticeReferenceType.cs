namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class NoticeReferenceType
    {

        private string _organizationField;

        private string[] _noticeNumbersField;

        /// <remarks/>
        public string Organization
        {
            get
            {
                return _organizationField;
            }
            set
            {
                _organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("int", DataType = "integer", IsNullable = false)]
        public string[] NoticeNumbers
        {
            get
            {
                return _noticeNumbersField;
            }
            set
            {
                _noticeNumbersField = value;
            }
        }
    }
}