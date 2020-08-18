using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.Models.StandardBusinessDocument
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace =
        "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public class Scope
    {
        private string _typeField;

        private string _instanceIdentifierField;

        private string _identifierField;

        private object[] _scopeInformationField;

        /// <remarks/>
        public string Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks/>
        public string InstanceIdentifier
        {
            get => _instanceIdentifierField;
            set => _instanceIdentifierField = value;
        }

        /// <remarks/>
        public string Identifier
        {
            get => _identifierField;
            set => _identifierField = value;
        }

        /// <remarks/>
        [XmlElement("ScopeInformation")]
        public object[] ScopeInformation
        {
            get => _scopeInformationField;
            set => _scopeInformationField = value;
        }
    }
}