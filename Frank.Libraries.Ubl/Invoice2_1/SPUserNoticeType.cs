namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SPUserNoticeType
    {

        private NoticeReferenceType noticeRefField;

        private string explicitTextField;

        /// <remarks/>
        public NoticeReferenceType NoticeRef
        {
            get
            {
                return noticeRefField;
            }
            set
            {
                noticeRefField = value;
            }
        }

        /// <remarks/>
        public string ExplicitText
        {
            get
            {
                return explicitTextField;
            }
            set
            {
                explicitTextField = value;
            }
        }
    }
}