using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[XmlInclude(typeof(QuantityType1))]
[XmlInclude(typeof(VarianceQuantityType))]
[XmlInclude(typeof(ValueQuantityType))]
[XmlInclude(typeof(TotalTransportHandlingUnitQuantityType))]
[XmlInclude(typeof(TotalPackagesQuantityType))]
[XmlInclude(typeof(TotalPackageQuantityType))]
[XmlInclude(typeof(TotalMeteredQuantityType))]
[XmlInclude(typeof(TotalGoodsItemQuantityType))]
[XmlInclude(typeof(TotalDeliveredQuantityType))]
[XmlInclude(typeof(TotalConsumedQuantityType))]
[XmlInclude(typeof(TimeDeltaDaysQuantityType))]
[XmlInclude(typeof(ThresholdQuantityType))]
[XmlInclude(typeof(TargetInventoryQuantityType))]
[XmlInclude(typeof(ShortQuantityType))]
[XmlInclude(typeof(SharesNumberQuantityType))]
[XmlInclude(typeof(ReturnableQuantityType))]
[XmlInclude(typeof(RejectedQuantityType))]
[XmlInclude(typeof(ReceivedTenderQuantityType))]
[XmlInclude(typeof(ReceivedQuantityType))]
[XmlInclude(typeof(ReceivedForeignTenderQuantityType))]
[XmlInclude(typeof(ReceivedElectronicTenderQuantityType))]
[XmlInclude(typeof(QuantityType2))]
[XmlInclude(typeof(PreviousMeterQuantityType))]
[XmlInclude(typeof(PerformanceValueQuantityType))]
[XmlInclude(typeof(PassengerQuantityType))]
[XmlInclude(typeof(PackQuantityType))]
[XmlInclude(typeof(OversupplyQuantityType))]
[XmlInclude(typeof(OutstandingQuantityType))]
[XmlInclude(typeof(OperatingYearsQuantityType))]
[XmlInclude(typeof(NormalTemperatureReductionQuantityType))]
[XmlInclude(typeof(MultipleOrderQuantityType))]
[XmlInclude(typeof(MinimumQuantityType))]
[XmlInclude(typeof(MinimumOrderQuantityType))]
[XmlInclude(typeof(MinimumInventoryQuantityType))]
[XmlInclude(typeof(MinimumBackorderQuantityType))]
[XmlInclude(typeof(MaximumVariantQuantityType))]
[XmlInclude(typeof(MaximumQuantityType))]
[XmlInclude(typeof(MaximumOrderQuantityType))]
[XmlInclude(typeof(MaximumOperatorQuantityType))]
[XmlInclude(typeof(MaximumBackorderQuantityType))]
[XmlInclude(typeof(LatestMeterQuantityType))]
[XmlInclude(typeof(InvoicedQuantityType))]
[XmlInclude(typeof(GasPressureQuantityType))]
[XmlInclude(typeof(ExpectedQuantityType))]
[XmlInclude(typeof(ExpectedOperatorQuantityType))]
[XmlInclude(typeof(EstimatedOverallContractQuantityType))]
[XmlInclude(typeof(EstimatedConsumedQuantityType))]
[XmlInclude(typeof(EmployeeQuantityType))]
[XmlInclude(typeof(DifferenceTemperatureReductionQuantityType))]
[XmlInclude(typeof(DeliveredQuantityType))]
[XmlInclude(typeof(DebitedQuantityType))]
[XmlInclude(typeof(CustomsTariffQuantityType))]
[XmlInclude(typeof(CrewQuantityType))]
[XmlInclude(typeof(CreditedQuantityType))]
[XmlInclude(typeof(ContentUnitQuantityType))]
[XmlInclude(typeof(ConsumptionWaterQuantityType))]
[XmlInclude(typeof(ConsumptionEnergyQuantityType))]
[XmlInclude(typeof(ConsumerUnitQuantityType))]
[XmlInclude(typeof(ConsignmentQuantityType))]
[XmlInclude(typeof(ChildConsignmentQuantityType))]
[XmlInclude(typeof(ChargeableQuantityType))]
[XmlInclude(typeof(BatchQuantityType))]
[XmlInclude(typeof(BasicConsumedQuantityType))]
[XmlInclude(typeof(BaseQuantityType))]
[XmlInclude(typeof(BackorderQuantityType))]
[XmlInclude(typeof(ActualTemperatureReductionQuantityType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public class QuantityType
{
    private string unitCodeField;

    private string unitCodeListAgencyIDField;

    private string unitCodeListAgencyNameField;

    private string unitCodeListIDField;

    private decimal valueField;

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string unitCode
    {
        get => unitCodeField;
        set => unitCodeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string unitCodeListID
    {
        get => unitCodeListIDField;
        set => unitCodeListIDField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string unitCodeListAgencyID
    {
        get => unitCodeListAgencyIDField;
        set => unitCodeListAgencyIDField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string unitCodeListAgencyName
    {
        get => unitCodeListAgencyNameField;
        set => unitCodeListAgencyNameField = value;
    }

    /// <remarks />
    [XmlText]
    public decimal Value
    {
        get => valueField;
        set => valueField = value;
    }
}