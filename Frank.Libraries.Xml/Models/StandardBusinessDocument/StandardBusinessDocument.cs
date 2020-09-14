using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using Frank.Libraries.Xml;

namespace Frank.Libraries.Xml.Models.StandardBusinessDocument
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [XmlRoot(
        Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public class StandardBusinessDocument
    {
        private StandardBusinessDocumentHeader _standardBusinessDocumentHeaderField;

        private XmlElement _anyField;

        /// <remarks/>
        public StandardBusinessDocumentHeader StandardBusinessDocumentHeader
        {
            get => _standardBusinessDocumentHeaderField;
            set => _standardBusinessDocumentHeaderField = value;
        }

        /// <remarks/>
        [XmlAnyElement()]
        public XmlElement Any
        {
            get => _anyField;
            set => _anyField = value;
        }
    }
}