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
    public class ServiceTransaction
    {
        private TypeOfServiceTransaction _typeOfServiceTransactionField;

        private bool _typeOfServiceTransactionFieldSpecified;

        private string _isNonRepudiationRequiredField;

        private string _isAuthenticationRequiredField;

        private string _isNonRepudiationOfReceiptRequiredField;

        private string _isIntelligibleCheckRequiredField;

        private string _isApplicationErrorResponseRequestedField;

        private string _timeToAcknowledgeReceiptField;

        private string _timeToAcknowledgeAcceptanceField;

        private string _timeToPerformField;

        private string _recurrenceField;

        /// <remarks/>
        [XmlAttribute()]
        public TypeOfServiceTransaction TypeOfServiceTransaction
        {
            get => _typeOfServiceTransactionField;
            set => _typeOfServiceTransactionField = value;
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TypeOfServiceTransactionSpecified
        {
            get => _typeOfServiceTransactionFieldSpecified;
            set => _typeOfServiceTransactionFieldSpecified = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string IsNonRepudiationRequired
        {
            get => _isNonRepudiationRequiredField;
            set => _isNonRepudiationRequiredField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string IsAuthenticationRequired
        {
            get => _isAuthenticationRequiredField;
            set => _isAuthenticationRequiredField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string IsNonRepudiationOfReceiptRequired
        {
            get => _isNonRepudiationOfReceiptRequiredField;
            set => _isNonRepudiationOfReceiptRequiredField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string IsIntelligibleCheckRequired
        {
            get => _isIntelligibleCheckRequiredField;
            set => _isIntelligibleCheckRequiredField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string IsApplicationErrorResponseRequested
        {
            get => _isApplicationErrorResponseRequestedField;
            set => _isApplicationErrorResponseRequestedField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string TimeToAcknowledgeReceipt
        {
            get => _timeToAcknowledgeReceiptField;
            set => _timeToAcknowledgeReceiptField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string TimeToAcknowledgeAcceptance
        {
            get => _timeToAcknowledgeAcceptanceField;
            set => _timeToAcknowledgeAcceptanceField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string TimeToPerform
        {
            get => _timeToPerformField;
            set => _timeToPerformField = value;
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Recurrence
        {
            get => _recurrenceField;
            set => _recurrenceField = value;
        }
    }
}