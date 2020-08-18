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
    public class Partner
    {
        private PartnerIdentification _identifierField;

        private ContactInformation[] _contactInformationField;

        /// <remarks/>
        public PartnerIdentification Identifier
        {
            get => _identifierField;
            set => _identifierField = value;
        }

        /// <remarks/>
        [XmlElement("ContactInformation")]
        public ContactInformation[] ContactInformation
        {
            get => _contactInformationField;
            set => _contactInformationField = value;
        }
    }
}