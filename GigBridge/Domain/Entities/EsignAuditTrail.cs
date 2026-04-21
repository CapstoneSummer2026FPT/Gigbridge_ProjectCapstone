using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsignAuditTrail
{
    public Guid EsignAuditTrailsId { get; set; }

    public Guid EsignDocumentsId { get; set; }

    public Guid UserId { get; set; }

    /// <summary>
    /// Enum ESignAuditAction: 0=DocumentCreated, 1=DocumentViewed, 2=SignatureAdded, 3=SignatureDeclined, 4=DocumentFinalized, 5=DocumentExported, 6=DocumentVoided
    /// </summary>
    public int Action { get; set; }

    public string? Description { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? Metadata { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual EsignDocument EsignDocuments { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
