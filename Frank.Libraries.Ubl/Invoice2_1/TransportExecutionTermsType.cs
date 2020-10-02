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

        private TransportUserSpecialTermsType[] _transportUserSpecialTermsField;

        private TransportServiceProviderSpecialTermsType[] _transportServiceProviderSpecialTermsField;

        private ChangeConditionsType[] _changeConditionsField;

        private PaymentTermsType[] _paymentTermsField;

        private DeliveryTermsType[] _deliveryTermsField;

        private PaymentTermsType _bonusPaymentTermsField;

        private PaymentTermsType _commissionPaymentTermsField;

        private PaymentTermsType _penaltyPaymentTermsField;

        private EnvironmentalEmissionType[] _environmentalEmissionField;

        private NotificationRequirementType[] _notificationRequirementField;

        private PaymentTermsType _serviceChargePaymentTermsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportUserSpecialTermsType[] TransportUserSpecialTerms
        {
            get
            {
                return _transportUserSpecialTermsField;
            }
            set
            {
                _transportUserSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms
        {
            get
            {
                return _transportServiceProviderSpecialTermsField;
            }
            set
            {
                _transportServiceProviderSpecialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChangeConditionsType[] ChangeConditions
        {
            get
            {
                return _changeConditionsField;
            }
            set
            {
                _changeConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return _paymentTermsField;
            }
            set
            {
                _paymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return _deliveryTermsField;
            }
            set
            {
                _deliveryTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType BonusPaymentTerms
        {
            get
            {
                return _bonusPaymentTermsField;
            }
            set
            {
                _bonusPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType CommissionPaymentTerms
        {
            get
            {
                return _commissionPaymentTermsField;
            }
            set
            {
                _commissionPaymentTermsField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType PenaltyPaymentTerms
        {
            get
            {
                return _penaltyPaymentTermsField;
            }
            set
            {
                _penaltyPaymentTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return _environmentalEmissionField;
            }
            set
            {
                _environmentalEmissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement")]
        public NotificationRequirementType[] NotificationRequirement
        {
            get
            {
                return _notificationRequirementField;
            }
            set
            {
                _notificationRequirementField = value;
            }
        }

        /// <remarks/>
        public PaymentTermsType ServiceChargePaymentTerms
        {
            get
            {
                return _serviceChargePaymentTermsField;
            }
            set
            {
                _serviceChargePaymentTermsField = value;
            }
        }
    }
}