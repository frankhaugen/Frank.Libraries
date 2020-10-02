namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PromotionalEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PromotionalEventType
    {

        private PromotionalEventTypeCodeType _promotionalEventTypeCodeField;

        private SubmissionDateType _submissionDateField;

        private FirstShipmentAvailibilityDateType _firstShipmentAvailibilityDateField;

        private LatestProposalAcceptanceDateType _latestProposalAcceptanceDateField;

        private PromotionalSpecificationType[] _promotionalSpecificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PromotionalEventTypeCodeType PromotionalEventTypeCode
        {
            get
            {
                return _promotionalEventTypeCodeField;
            }
            set
            {
                _promotionalEventTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionDateType SubmissionDate
        {
            get
            {
                return _submissionDateField;
            }
            set
            {
                _submissionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate
        {
            get
            {
                return _firstShipmentAvailibilityDateField;
            }
            set
            {
                _firstShipmentAvailibilityDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate
        {
            get
            {
                return _latestProposalAcceptanceDateField;
            }
            set
            {
                _latestProposalAcceptanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalSpecification")]
        public PromotionalSpecificationType[] PromotionalSpecification
        {
            get
            {
                return _promotionalSpecificationField;
            }
            set
            {
                _promotionalSpecificationField = value;
            }
        }
    }
}