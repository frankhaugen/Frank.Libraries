using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TransportExecutionTermsType
{
    private PaymentTermsType bonusPaymentTermsField;

    private ChangeConditionsType[] changeConditionsField;

    private PaymentTermsType commissionPaymentTermsField;

    private DeliveryTermsType[] deliveryTermsField;

    private EnvironmentalEmissionType[] environmentalEmissionField;

    private NotificationRequirementType[] notificationRequirementField;

    private PaymentTermsType[] paymentTermsField;

    private PaymentTermsType penaltyPaymentTermsField;

    private PaymentTermsType serviceChargePaymentTermsField;

    private TransportServiceProviderSpecialTermsType[] transportServiceProviderSpecialTermsField;

    private TransportUserSpecialTermsType[] transportUserSpecialTermsField;

    /// <remarks />
    [XmlElement("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportUserSpecialTermsType[] TransportUserSpecialTerms
    {
        get => transportUserSpecialTermsField;
        set => transportUserSpecialTermsField = value;
    }

    /// <remarks />
    [XmlElement("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms
    {
        get => transportServiceProviderSpecialTermsField;
        set => transportServiceProviderSpecialTermsField = value;
    }

    /// <remarks />
    [XmlElement("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChangeConditionsType[] ChangeConditions
    {
        get => changeConditionsField;
        set => changeConditionsField = value;
    }

    /// <remarks />
    [XmlElement("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms
    {
        get => paymentTermsField;
        set => paymentTermsField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryTerms")]
    public DeliveryTermsType[] DeliveryTerms
    {
        get => deliveryTermsField;
        set => deliveryTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType BonusPaymentTerms
    {
        get => bonusPaymentTermsField;
        set => bonusPaymentTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType CommissionPaymentTerms
    {
        get => commissionPaymentTermsField;
        set => commissionPaymentTermsField = value;
    }

    /// <remarks />
    public PaymentTermsType PenaltyPaymentTerms
    {
        get => penaltyPaymentTermsField;
        set => penaltyPaymentTermsField = value;
    }

    /// <remarks />
    [XmlElement("EnvironmentalEmission")]
    public EnvironmentalEmissionType[] EnvironmentalEmission
    {
        get => environmentalEmissionField;
        set => environmentalEmissionField = value;
    }

    /// <remarks />
    [XmlElement("NotificationRequirement")]
    public NotificationRequirementType[] NotificationRequirement
    {
        get => notificationRequirementField;
        set => notificationRequirementField = value;
    }

    /// <remarks />
    public PaymentTermsType ServiceChargePaymentTerms
    {
        get => serviceChargePaymentTermsField;
        set => serviceChargePaymentTermsField = value;
    }
}