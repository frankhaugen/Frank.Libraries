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
[XmlRoot("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DeliveryTermsType
{
    private AllowanceChargeType allowanceChargeField;

    private AmountType2 amountField;

    private LocationType1 deliveryLocationField;

    private IDType idField;

    private LossRiskType[] lossRiskField;

    private LossRiskResponsibilityCodeType lossRiskResponsibilityCodeField;

    private SpecialTermsType[] specialTermsField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("SpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialTermsType[] SpecialTerms
    {
        get => specialTermsField;
        set => specialTermsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LossRiskResponsibilityCodeType LossRiskResponsibilityCode
    {
        get => lossRiskResponsibilityCodeField;
        set => lossRiskResponsibilityCodeField = value;
    }

    /// <remarks />
    [XmlElement("LossRisk", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LossRiskType[] LossRisk
    {
        get => lossRiskField;
        set => lossRiskField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get => amountField;
        set => amountField = value;
    }

    /// <remarks />
    public LocationType1 DeliveryLocation
    {
        get => deliveryLocationField;
        set => deliveryLocationField = value;
    }

    /// <remarks />
    public AllowanceChargeType AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }
}