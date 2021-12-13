namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("QualificationResolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class QualificationResolutionType
{

    private AdmissionCodeType admissionCodeField;

    private ExclusionReasonType[] exclusionReasonField;

    private ResolutionType[] resolutionField;

    private ResolutionDateType resolutionDateField;

    private ResolutionTimeType resolutionTimeField;

    private ProcurementProjectLotType procurementProjectLotField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdmissionCodeType AdmissionCode
    {
        get
        {
            return this.admissionCodeField;
        }
        set
        {
            this.admissionCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExclusionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExclusionReasonType[] ExclusionReason
    {
        get
        {
            return this.exclusionReasonField;
        }
        set
        {
            this.exclusionReasonField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Resolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionType[] Resolution
    {
        get
        {
            return this.resolutionField;
        }
        set
        {
            this.resolutionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionDateType ResolutionDate
    {
        get
        {
            return this.resolutionDateField;
        }
        set
        {
            this.resolutionDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionTimeType ResolutionTime
    {
        get
        {
            return this.resolutionTimeField;
        }
        set
        {
            this.resolutionTimeField = value;
        }
    }

    /// <remarks/>
    public ProcurementProjectLotType ProcurementProjectLot
    {
        get
        {
            return this.procurementProjectLotField;
        }
        set
        {
            this.procurementProjectLotField = value;
        }
    }
}