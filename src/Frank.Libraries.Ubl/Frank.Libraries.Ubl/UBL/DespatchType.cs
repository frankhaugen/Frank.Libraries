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
[XmlRoot("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DespatchType
{
    private ActualDespatchDateType actualDespatchDateField;

    private ActualDespatchTimeType actualDespatchTimeField;

    private PartyType carrierPartyField;

    private ContactType contactField;

    private AddressType despatchAddressField;

    private LocationType1 despatchLocationField;

    private PartyType despatchPartyField;

    private EstimatedDespatchDateType estimatedDespatchDateField;

    private PeriodType estimatedDespatchPeriodField;

    private EstimatedDespatchTimeType estimatedDespatchTimeField;

    private GuaranteedDespatchDateType guaranteedDespatchDateField;

    private GuaranteedDespatchTimeType guaranteedDespatchTimeField;

    private IDType idField;

    private InstructionsType[] instructionsField;

    private PartyType[] notifyPartyField;

    private ReleaseIDType releaseIDField;

    private RequestedDespatchDateType requestedDespatchDateField;

    private PeriodType requestedDespatchPeriodField;

    private RequestedDespatchTimeType requestedDespatchTimeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDespatchDateType RequestedDespatchDate
    {
        get => requestedDespatchDateField;
        set => requestedDespatchDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDespatchTimeType RequestedDespatchTime
    {
        get => requestedDespatchTimeField;
        set => requestedDespatchTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDespatchDateType EstimatedDespatchDate
    {
        get => estimatedDespatchDateField;
        set => estimatedDespatchDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedDespatchTimeType EstimatedDespatchTime
    {
        get => estimatedDespatchTimeField;
        set => estimatedDespatchTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDespatchDateType ActualDespatchDate
    {
        get => actualDespatchDateField;
        set => actualDespatchDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActualDespatchTimeType ActualDespatchTime
    {
        get => actualDespatchTimeField;
        set => actualDespatchTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteedDespatchDateType GuaranteedDespatchDate
    {
        get => guaranteedDespatchDateField;
        set => guaranteedDespatchDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GuaranteedDespatchTimeType GuaranteedDespatchTime
    {
        get => guaranteedDespatchTimeField;
        set => guaranteedDespatchTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReleaseIDType ReleaseID
    {
        get => releaseIDField;
        set => releaseIDField = value;
    }

    /// <remarks />
    [XmlElement("Instructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionsType[] Instructions
    {
        get => instructionsField;
        set => instructionsField = value;
    }

    /// <remarks />
    public AddressType DespatchAddress
    {
        get => despatchAddressField;
        set => despatchAddressField = value;
    }

    /// <remarks />
    public LocationType1 DespatchLocation
    {
        get => despatchLocationField;
        set => despatchLocationField = value;
    }

    /// <remarks />
    public PartyType DespatchParty
    {
        get => despatchPartyField;
        set => despatchPartyField = value;
    }

    /// <remarks />
    public PartyType CarrierParty
    {
        get => carrierPartyField;
        set => carrierPartyField = value;
    }

    /// <remarks />
    [XmlElement("NotifyParty")]
    public PartyType[] NotifyParty
    {
        get => notifyPartyField;
        set => notifyPartyField = value;
    }

    /// <remarks />
    public ContactType Contact
    {
        get => contactField;
        set => contactField = value;
    }

    /// <remarks />
    public PeriodType EstimatedDespatchPeriod
    {
        get => estimatedDespatchPeriodField;
        set => estimatedDespatchPeriodField = value;
    }

    /// <remarks />
    public PeriodType RequestedDespatchPeriod
    {
        get => requestedDespatchPeriodField;
        set => requestedDespatchPeriodField = value;
    }
}