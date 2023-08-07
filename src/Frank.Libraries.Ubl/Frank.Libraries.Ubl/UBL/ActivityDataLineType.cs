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
[XmlRoot("ActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ActivityDataLineType
{
    private LocationType1 activityFinalLocationField;

    private LocationType1 activityOriginLocationField;

    private PeriodType activityPeriodField;

    private CustomerPartyType buyerCustomerPartyField;

    private IDType idField;

    private SalesItemType[] salesItemField;

    private SupplierPartyType sellerSupplierPartyField;

    private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
    {
        get => supplyChainActivityTypeCodeField;
        set => supplyChainActivityTypeCodeField = value;
    }

    /// <remarks />
    public CustomerPartyType BuyerCustomerParty
    {
        get => buyerCustomerPartyField;
        set => buyerCustomerPartyField = value;
    }

    /// <remarks />
    public SupplierPartyType SellerSupplierParty
    {
        get => sellerSupplierPartyField;
        set => sellerSupplierPartyField = value;
    }

    /// <remarks />
    public PeriodType ActivityPeriod
    {
        get => activityPeriodField;
        set => activityPeriodField = value;
    }

    /// <remarks />
    public LocationType1 ActivityOriginLocation
    {
        get => activityOriginLocationField;
        set => activityOriginLocationField = value;
    }

    /// <remarks />
    public LocationType1 ActivityFinalLocation
    {
        get => activityFinalLocationField;
        set => activityFinalLocationField = value;
    }

    /// <remarks />
    [XmlElement("SalesItem")]
    public SalesItemType[] SalesItem
    {
        get => salesItemField;
        set => salesItemField = value;
    }
}