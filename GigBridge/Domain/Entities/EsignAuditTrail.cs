using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsignAuditTrail
{
    public Guid EAuditEsignAuditTrailsId { get; set; }

    public Guid EDocEsignDocumentsId { get; set; }

    public Guid UsrUserId { get; set; }

    /// <summary>
    /// Enum ESignAuditAction: 0=DocumentCreated, 1=DocumentViewed, 2=SignatureAdded, 3=SignatureDeclined, 4=DocumentFinalized, 5=DocumentExported, 6=DocumentVoided
    /// </summary>
    public int Action { get; set; }

    public string? Description { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? Metadata { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual EsignDocument EDocEsignDocuments { get; set; } = null!;

    public virtual User UsrUser { get; set; } = null!;
}
