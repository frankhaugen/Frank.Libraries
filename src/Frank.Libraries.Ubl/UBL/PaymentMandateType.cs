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
[XmlRoot("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PaymentMandateType
{
    private ClauseType[] clauseField;

    private IDType idField;

    private MandateTypeCodeType mandateTypeCodeField;

    private MaximumPaidAmountType maximumPaidAmountField;

    private MaximumPaymentInstructionsNumericType maximumPaymentInstructionsNumericField;

    private FinancialAccountType payerFinancialAccountField;

    private PartyType payerPartyField;

    private PeriodType paymentReversalPeriodField;

    private SignatureIDType signatureIDField;

    private PeriodType validityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MandateTypeCodeType MandateTypeCode
    {
        get => mandateTypeCodeField;
        set => mandateTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric
    {
        get => maximumPaymentInstructionsNumericField;
        set => maximumPaymentInstructionsNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPaidAmountType MaximumPaidAmount
    {
        get => maximumPaidAmountField;
        set => maximumPaidAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SignatureIDType SignatureID
    {
        get => signatureIDField;
        set => signatureIDField = value;
    }

    /// <remarks />
    public PartyType PayerParty
    {
        get => payerPartyField;
        set => payerPartyField = value;
    }

    /// <remarks />
    public FinancialAccountType PayerFinancialAccount
    {
        get => payerFinancialAccountField;
        set => payerFinancialAccountField = value;
    }

    /// <remarks />
    public PeriodType ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    public PeriodType PaymentReversalPeriod
    {
        get => paymentReversalPeriodField;
        set => paymentReversalPeriodField = value;
    }

    /// <remarks />
    [XmlElement("Clause")]
    public ClauseType[] Clause
    {
        get => clauseField;
        set => clauseField = value;
    }
}