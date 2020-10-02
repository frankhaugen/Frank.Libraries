namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SpUserNoticeType
    {

        private NoticeReferenceType _noticeRefField;

        private string _explicitTextField;

        /// <remarks/>
        public NoticeReferenceType NoticeRef
        {
            get
            {
                return _noticeRefField;
            }
            set
            {
                _noticeRefField = value;
            }
        }

        /// <remarks/>
        public string ExplicitText
        {
            get
            {
                return _explicitTextField;
            }
            set
            {
                _explicitTextField = value;
            }
        }
    }
}