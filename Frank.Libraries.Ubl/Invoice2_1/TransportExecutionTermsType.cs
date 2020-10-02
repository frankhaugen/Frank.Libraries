namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TransportExecutionTermsType
    {

        private TransportUserSpecialTermsType[] transportUserSpecialTermsField;

        private TransportServiceProviderSpecialTermsType[] transportServiceProviderSpecialTermsField;

        private ChangeConditionsType[] changeConditionsField;

        private PaymentTermsType[] paymentTermsField;

        private DeliveryTermsType[] deliveryTermsField;

        private PaymentTermsType bonusPaymentTermsField;

        private PaymentTermsType commissionPaymentTermsField;

        private PaymentTermsType penaltyPaymentTermsField;

        private EnvironmentalEmissionType[] environmentalEmissionField;

        private NotificationRequirementType[] notificationRequirementField;

        private PaymentTermsType serviceChargePaymentTermsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportUserSpecialTermsType[] TransportUserSpecialTerms
        {
            get
            {
                return transportUserSpecialTermsField;
            }
            set
            {
                transportUserSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms
        {
            get
            {
                return transportServiceProviderSpecialTermsField;
            }
            set
            {
                transportServiceProviderSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChangeConditionsType[] ChangeConditions
        {
            get
            {
                return changeConditionsField;
            }
            set
            {
                changeConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return paymentTermsField;
            }
            set
            {
                paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return deliveryTermsField;
            }
            set
            {
                deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType BonusPaymentTerms
        {
            get
            {
                return bonusPaymentTermsField;
            }
            set
            {
                bonusPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType CommissionPaymentTerms
        {
            get
            {
                return commissionPaymentTermsField;
            }
            set
            {
                commissionPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PenaltyPaymentTerms
        {
            get
            {
                return penaltyPaymentTermsField;
            }
            set
            {
                penaltyPaymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return environmentalEmissionField;
            }
            set
            {
                environmentalEmissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement")]
        public NotificationRequirementType[] NotificationRequirement
        {
            get
            {
                return notificationRequirementField;
            }
            set
            {
                notificationRequirementField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType ServiceChargePaymentTerms
        {
            get
            {
                return serviceChargePaymentTermsField;
            }
            set
            {
                serviceChargePaymentTermsField = value;
            }
        }
    }
}