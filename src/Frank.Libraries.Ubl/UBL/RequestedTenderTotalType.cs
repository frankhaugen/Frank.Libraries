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
[XmlRoot("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class RequestedTenderTotalType
{
    private TaxCategoryType[] applicableTaxCategoryField;

    private AverageSubsequentContractAmountType averageSubsequentContractAmountField;

    private EstimatedOverallContractAmountType estimatedOverallContractAmountField;

    private MaximumAmountType maximumAmountField;

    private MinimumAmountType minimumAmountField;

    private MonetaryScopeType[] monetaryScopeField;

    private TaxIncludedIndicatorType taxIncludedIndicatorField;

    private TotalAmountType totalAmountField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedOverallContractAmountType EstimatedOverallContractAmount
    {
        get => estimatedOverallContractAmountField;
        set => estimatedOverallContractAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalAmountType TotalAmount
    {
        get => totalAmountField;
        set => totalAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxIncludedIndicatorType TaxIncludedIndicator
    {
        get => taxIncludedIndicatorField;
        set => taxIncludedIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumAmountType MinimumAmount
    {
        get => minimumAmountField;
        set => minimumAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumAmountType MaximumAmount
    {
        get => maximumAmountField;
        set => maximumAmountField = value;
    }

    /// <remarks />
    [XmlElement("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MonetaryScopeType[] MonetaryScope
    {
        get => monetaryScopeField;
        set => monetaryScopeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AverageSubsequentContractAmountType AverageSubsequentContractAmount
    {
        get => averageSubsequentContractAmountField;
        set => averageSubsequentContractAmountField = value;
    }

    /// <remarks />
    [XmlElement("ApplicableTaxCategory")]
    public TaxCategoryType[] ApplicableTaxCategory
    {
        get => applicableTaxCategoryField;
        set => applicableTaxCategoryField = value;
    }
}