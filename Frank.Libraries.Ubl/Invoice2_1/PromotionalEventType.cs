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

        private PromotionalEventTypeCodeType promotionalEventTypeCodeField;

        private SubmissionDateType submissionDateField;

        private FirstShipmentAvailibilityDateType firstShipmentAvailibilityDateField;

        private LatestProposalAcceptanceDateType latestProposalAcceptanceDateField;

        private PromotionalSpecificationType[] promotionalSpecificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PromotionalEventTypeCodeType PromotionalEventTypeCode
        {
            get
            {
                return promotionalEventTypeCodeField;
            }
            set
            {
                promotionalEventTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubmissionDateType SubmissionDate
        {
            get
            {
                return submissionDateField;
            }
            set
            {
                submissionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate
        {
            get
            {
                return firstShipmentAvailibilityDateField;
            }
            set
            {
                firstShipmentAvailibilityDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate
        {
            get
            {
                return latestProposalAcceptanceDateField;
            }
            set
            {
                latestProposalAcceptanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalSpecification")]
        public PromotionalSpecificationType[] PromotionalSpecification
        {
            get
            {
                return promotionalSpecificationField;
            }
            set
            {
                promotionalSpecificationField = value;
            }
        }
    }
}