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
[XmlRoot("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class BudgetAccountType
{
    private BudgetYearNumericType budgetYearNumericField;

    private IDType idField;

    private ClassificationSchemeType requiredClassificationSchemeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BudgetYearNumericType BudgetYearNumeric
    {
        get => budgetYearNumericField;
        set => budgetYearNumericField = value;
    }

    /// <remarks />
    public ClassificationSchemeType RequiredClassificationScheme
    {
        get => requiredClassificationSchemeField;
        set => requiredClassificationSchemeField = value;
    }
}