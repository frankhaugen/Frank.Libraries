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
[XmlRoot("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ExternalReferenceType
{
    private CharacterSetCodeType characterSetCodeField;

    private DescriptionType[] descriptionField;

    private DocumentHashType documentHashField;

    private EncodingCodeType encodingCodeField;

    private ExpiryDateType expiryDateField;

    private ExpiryTimeType expiryTimeField;

    private FileNameType fileNameField;

    private FormatCodeType formatCodeField;

    private HashAlgorithmMethodType hashAlgorithmMethodField;

    private MimeCodeType mimeCodeField;

    private URIType uRIField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public URIType URI
    {
        get => uRIField;
        set => uRIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentHashType DocumentHash
    {
        get => documentHashField;
        set => documentHashField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HashAlgorithmMethodType HashAlgorithmMethod
    {
        get => hashAlgorithmMethodField;
        set => hashAlgorithmMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpiryDateType ExpiryDate
    {
        get => expiryDateField;
        set => expiryDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpiryTimeType ExpiryTime
    {
        get => expiryTimeField;
        set => expiryTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MimeCodeType MimeCode
    {
        get => mimeCodeField;
        set => mimeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FormatCodeType FormatCode
    {
        get => formatCodeField;
        set => formatCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EncodingCodeType EncodingCode
    {
        get => encodingCodeField;
        set => encodingCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CharacterSetCodeType CharacterSetCode
    {
        get => characterSetCodeField;
        set => characterSetCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FileNameType FileName
    {
        get => fileNameField;
        set => fileNameField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }
}