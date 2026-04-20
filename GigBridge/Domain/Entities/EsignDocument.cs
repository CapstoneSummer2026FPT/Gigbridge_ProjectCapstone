using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsignDocument
{
    public Guid EDocEsignDocumentsId { get; set; }

    public Guid ETplEsignTemplatesId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public Guid? ContContractsId { get; set; }

    public string DocumentCode { get; set; } = null!;

    public string RenderedHtmlContent { get; set; } = null!;

    /// <summary>
    /// Enum ESignDocumentStatus: 0=Draft, 1=PendingSignatures, 2=PartiallySigned, 3=FullySigned, 4=Expired, 5=Voided
    /// </summary>
    public int Status { get; set; }

    public string? DocumentHash { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public DateTime? FinalizedAt { get; set; }

    public string? ExportedPdfUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract? ContContracts { get; set; }

    public virtual EsignTemplate ETplEsignTemplates { get; set; } = null!;

    public virtual ICollection<EsignAuditTrail> EsignAuditTrails { get; set; } = new List<EsignAuditTrail>();

    public virtual ICollection<EsignSignature> EsignSignatures { get; set; } = new List<EsignSignature>();

    public virtual JobPost JpJobPosts { get; set; } = null!;
}
