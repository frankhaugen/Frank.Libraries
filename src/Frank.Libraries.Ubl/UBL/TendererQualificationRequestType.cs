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
[XmlRoot("TendererQualificationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TendererQualificationRequestType
{
    private CompanyLegalFormCodeType companyLegalFormCodeField;

    private CompanyLegalFormType companyLegalFormField;

    private DescriptionType[] descriptionField;

    private EconomicOperatorRoleType[] economicOperatorRoleField;

    private EmployeeQuantityType employeeQuantityField;

    private EvaluationCriterionType[] financialEvaluationCriterionField;

    private OperatingYearsQuantityType operatingYearsQuantityField;

    private PersonalSituationType[] personalSituationField;

    private ClassificationSchemeType[] requiredBusinessClassificationSchemeField;

    private TendererRequirementType[] specificTendererRequirementField;

    private EvaluationCriterionType[] technicalEvaluationCriterionField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyLegalFormCodeType CompanyLegalFormCode
    {
        get => companyLegalFormCodeField;
        set => companyLegalFormCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CompanyLegalFormType CompanyLegalForm
    {
        get => companyLegalFormField;
        set => companyLegalFormField = value;
    }

    /// <remarks />
    [XmlElement("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PersonalSituationType[] PersonalSituation
    {
        get => personalSituationField;
        set => personalSituationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OperatingYearsQuantityType OperatingYearsQuantity
    {
        get => operatingYearsQuantityField;
        set => operatingYearsQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EmployeeQuantityType EmployeeQuantity
    {
        get => employeeQuantityField;
        set => employeeQuantityField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("RequiredBusinessClassificationScheme")]
    public ClassificationSchemeType[] RequiredBusinessClassificationScheme
    {
        get => requiredBusinessClassificationSchemeField;
        set => requiredBusinessClassificationSchemeField = value;
    }

    /// <remarks />
    [XmlElement("TechnicalEvaluationCriterion")]
    public EvaluationCriterionType[] TechnicalEvaluationCriterion
    {
        get => technicalEvaluationCriterionField;
        set => technicalEvaluationCriterionField = value;
    }

    /// <remarks />
    [XmlElement("FinancialEvaluationCriterion")]
    public EvaluationCriterionType[] FinancialEvaluationCriterion
    {
        get => financialEvaluationCriterionField;
        set => financialEvaluationCriterionField = value;
    }

    /// <remarks />
    [XmlElement("SpecificTendererRequirement")]
    public TendererRequirementType[] SpecificTendererRequirement
    {
        get => specificTendererRequirementField;
        set => specificTendererRequirementField = value;
    }

    /// <remarks />
    [XmlElement("EconomicOperatorRole")]
    public EconomicOperatorRoleType[] EconomicOperatorRole
    {
        get => economicOperatorRoleField;
        set => economicOperatorRoleField = value;
    }
}