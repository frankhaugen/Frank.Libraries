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
[XmlRoot("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ExchangeRateType
{
    private CalculationRateType calculationRateField;

    private DateType1 dateField;

    private ExchangeMarketIDType exchangeMarketIDField;

    private ContractType foreignExchangeContractField;

    private MathematicOperatorCodeType mathematicOperatorCodeField;

    private SourceCurrencyBaseRateType sourceCurrencyBaseRateField;

    private SourceCurrencyCodeType sourceCurrencyCodeField;

    private TargetCurrencyBaseRateType targetCurrencyBaseRateField;

    private TargetCurrencyCodeType targetCurrencyCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SourceCurrencyCodeType SourceCurrencyCode
    {
        get => sourceCurrencyCodeField;
        set => sourceCurrencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SourceCurrencyBaseRateType SourceCurrencyBaseRate
    {
        get => sourceCurrencyBaseRateField;
        set => sourceCurrencyBaseRateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TargetCurrencyCodeType TargetCurrencyCode
    {
        get => targetCurrencyCodeField;
        set => targetCurrencyCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TargetCurrencyBaseRateType TargetCurrencyBaseRate
    {
        get => targetCurrencyBaseRateField;
        set => targetCurrencyBaseRateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExchangeMarketIDType ExchangeMarketID
    {
        get => exchangeMarketIDField;
        set => exchangeMarketIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationRateType CalculationRate
    {
        get => calculationRateField;
        set => calculationRateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MathematicOperatorCodeType MathematicOperatorCode
    {
        get => mathematicOperatorCodeField;
        set => mathematicOperatorCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DateType1 Date
    {
        get => dateField;
        set => dateField = value;
    }

    /// <remarks />
    public ContractType ForeignExchangeContract
    {
        get => foreignExchangeContractField;
        set => foreignExchangeContractField = value;
    }
}