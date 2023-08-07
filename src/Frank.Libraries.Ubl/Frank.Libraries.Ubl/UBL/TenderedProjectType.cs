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
[XmlRoot("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderedProjectType
{
    private AwardingCriterionResponseType[] awardingCriterionResponseField;

    private DocumentReferenceType[] evidenceDocumentReferenceField;

    private FeeAmountType feeAmountField;

    private FeeDescriptionType[] feeDescriptionField;

    private MonetaryTotalType legalMonetaryTotalField;

    private ProcurementProjectLotType procurementProjectLotField;

    private TaxTotalType[] taxTotalField;

    private TenderEnvelopeIDType tenderEnvelopeIDField;

    private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

    private TenderLineType[] tenderLineField;

    private VariantIDType variantIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VariantIDType VariantID
    {
        get => variantIDField;
        set => variantIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeAmountType FeeAmount
    {
        get => feeAmountField;
        set => feeAmountField = value;
    }

    /// <remarks />
    [XmlElement("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeDescriptionType[] FeeDescription
    {
        get => feeDescriptionField;
        set => feeDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeIDType TenderEnvelopeID
    {
        get => tenderEnvelopeIDField;
        set => tenderEnvelopeIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
    {
        get => tenderEnvelopeTypeCodeField;
        set => tenderEnvelopeTypeCodeField = value;
    }

    /// <remarks />
    public ProcurementProjectLotType ProcurementProjectLot
    {
        get => procurementProjectLotField;
        set => procurementProjectLotField = value;
    }

    /// <remarks />
    [XmlElement("EvidenceDocumentReference")]
    public DocumentReferenceType[] EvidenceDocumentReference
    {
        get => evidenceDocumentReferenceField;
        set => evidenceDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("TaxTotal")]
    public TaxTotalType[] TaxTotal
    {
        get => taxTotalField;
        set => taxTotalField = value;
    }

    /// <remarks />
    public MonetaryTotalType LegalMonetaryTotal
    {
        get => legalMonetaryTotalField;
        set => legalMonetaryTotalField = value;
    }

    /// <remarks />
    [XmlElement("TenderLine")]
    public TenderLineType[] TenderLine
    {
        get => tenderLineField;
        set => tenderLineField = value;
    }

    /// <remarks />
    [XmlElement("AwardingCriterionResponse")]
    public AwardingCriterionResponseType[] AwardingCriterionResponse
    {
        get => awardingCriterionResponseField;
        set => awardingCriterionResponseField = value;
    }
}