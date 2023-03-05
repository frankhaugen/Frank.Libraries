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
[XmlRoot("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ContractExtensionType
{
    private MaximumNumberNumericType maximumNumberNumericField;

    private MinimumNumberNumericType minimumNumberNumericField;

    private OptionsDescriptionType[] optionsDescriptionField;

    private PeriodType optionValidityPeriodField;

    private RenewalType[] renewalField;

    /// <remarks />
    [XmlElement("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OptionsDescriptionType[] OptionsDescription
    {
        get => optionsDescriptionField;
        set => optionsDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumNumberNumericType MinimumNumberNumeric
    {
        get => minimumNumberNumericField;
        set => minimumNumberNumericField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumNumberNumericType MaximumNumberNumeric
    {
        get => maximumNumberNumericField;
        set => maximumNumberNumericField = value;
    }

    /// <remarks />
    public PeriodType OptionValidityPeriod
    {
        get => optionValidityPeriodField;
        set => optionValidityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("Renewal")]
    public RenewalType[] Renewal
    {
        get => renewalField;
        set => renewalField = value;
    }
}