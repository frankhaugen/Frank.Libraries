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
    public class ContactInformation
    {
        private string _contactField;

        private string _emailAddressField;

        private string _faxNumberField;

        private string _telephoneNumberField;

        private string _contactTypeIdentifierField;

        /// <remarks/>
        public string Contact
        {
            get => _contactField;
            set => _contactField = value;
        }

        /// <remarks/>
        public string EmailAddress
        {
            get => _emailAddressField;
            set => _emailAddressField = value;
        }

        /// <remarks/>
        public string FaxNumber
        {
            get => _faxNumberField;
            set => _faxNumberField = value;
        }

        /// <remarks/>
        public string TelephoneNumber
        {
            get => _telephoneNumberField;
            set => _telephoneNumberField = value;
        }

        /// <remarks/>
        public string ContactTypeIdentifier
        {
            get => _contactTypeIdentifierField;
            set => _contactTypeIdentifierField = value;
        }
    }
}