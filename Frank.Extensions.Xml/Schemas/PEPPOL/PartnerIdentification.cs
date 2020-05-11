using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Extensions.Xml
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class PartnerIdentification
    {

        private string _authorityField;

        private string _valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }
}