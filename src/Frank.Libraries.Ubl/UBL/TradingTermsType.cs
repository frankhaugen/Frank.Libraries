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
[XmlRoot("HaulageTradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TradingTermsType
{
    private AddressType applicableAddressField;

    private InformationType[] informationField;

    private ReferenceType referenceField;

    /// <remarks />
    [XmlElement("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information
    {
        get => informationField;
        set => informationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceType Reference
    {
        get => referenceField;
        set => referenceField = value;
    }

    /// <remarks />
    public AddressType ApplicableAddress
    {
        get => applicableAddressField;
        set => applicableAddressField = value;
    }
}