using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AppealTermsType
{
    private PartyType appealInformationPartyField;

    private PartyType appealReceiverPartyField;

    private DescriptionType[] descriptionField;

    private PartyType mediationPartyField;

    private PeriodType presentationPeriodField;

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public PeriodType PresentationPeriod
    {
        get => presentationPeriodField;
        set => presentationPeriodField = value;
    }

    /// <remarks />
    public PartyType AppealInformationParty
    {
        get => appealInformationPartyField;
        set => appealInformationPartyField = value;
    }

    /// <remarks />
    public PartyType AppealReceiverParty
    {
        get => appealReceiverPartyField;
        set => appealReceiverPartyField = value;
    }

    /// <remarks />
    public PartyType MediationParty
    {
        get => mediationPartyField;
        set => mediationPartyField = value;
    }
}