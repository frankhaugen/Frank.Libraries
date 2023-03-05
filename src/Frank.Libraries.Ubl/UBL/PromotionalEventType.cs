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
[XmlRoot("PromotionalEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PromotionalEventType
{
    private FirstShipmentAvailibilityDateType firstShipmentAvailibilityDateField;

    private LatestProposalAcceptanceDateType latestProposalAcceptanceDateField;

    private PromotionalEventTypeCodeType promotionalEventTypeCodeField;

    private PromotionalSpecificationType[] promotionalSpecificationField;

    private SubmissionDateType submissionDateField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PromotionalEventTypeCodeType PromotionalEventTypeCode
    {
        get => promotionalEventTypeCodeField;
        set => promotionalEventTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubmissionDateType SubmissionDate
    {
        get => submissionDateField;
        set => submissionDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate
    {
        get => firstShipmentAvailibilityDateField;
        set => firstShipmentAvailibilityDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate
    {
        get => latestProposalAcceptanceDateField;
        set => latestProposalAcceptanceDateField = value;
    }

    /// <remarks />
    [XmlElement("PromotionalSpecification")]
    public PromotionalSpecificationType[] PromotionalSpecification
    {
        get => promotionalSpecificationField;
        set => promotionalSpecificationField = value;
    }
}