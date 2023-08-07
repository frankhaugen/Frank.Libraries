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
[XmlRoot("InterestedProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ProcurementProjectLotType
{
    private IDType idField;

    private ProcurementProjectType procurementProjectField;

    private TenderingTermsType tenderingTermsField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    public TenderingTermsType TenderingTerms
    {
        get => tenderingTermsField;
        set => tenderingTermsField = value;
    }

    /// <remarks />
    public ProcurementProjectType ProcurementProject
    {
        get => procurementProjectField;
        set => procurementProjectField = value;
    }
}