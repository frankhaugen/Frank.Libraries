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
[XmlRoot("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class BillingReferenceType
{
    private DocumentReferenceType additionalDocumentReferenceField;

    private BillingReferenceLineType[] billingReferenceLineField;

    private DocumentReferenceType creditNoteDocumentReferenceField;

    private DocumentReferenceType debitNoteDocumentReferenceField;

    private DocumentReferenceType invoiceDocumentReferenceField;

    private DocumentReferenceType reminderDocumentReferenceField;

    private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;

    private DocumentReferenceType selfBilledInvoiceDocumentReferenceField;

    /// <remarks />
    public DocumentReferenceType InvoiceDocumentReference
    {
        get => invoiceDocumentReferenceField;
        set => invoiceDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType SelfBilledInvoiceDocumentReference
    {
        get => selfBilledInvoiceDocumentReferenceField;
        set => selfBilledInvoiceDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType CreditNoteDocumentReference
    {
        get => creditNoteDocumentReferenceField;
        set => creditNoteDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType SelfBilledCreditNoteDocumentReference
    {
        get => selfBilledCreditNoteDocumentReferenceField;
        set => selfBilledCreditNoteDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType DebitNoteDocumentReference
    {
        get => debitNoteDocumentReferenceField;
        set => debitNoteDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType ReminderDocumentReference
    {
        get => reminderDocumentReferenceField;
        set => reminderDocumentReferenceField = value;
    }

    /// <remarks />
    public DocumentReferenceType AdditionalDocumentReference
    {
        get => additionalDocumentReferenceField;
        set => additionalDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("BillingReferenceLine")]
    public BillingReferenceLineType[] BillingReferenceLine
    {
        get => billingReferenceLineField;
        set => billingReferenceLineField = value;
    }
}