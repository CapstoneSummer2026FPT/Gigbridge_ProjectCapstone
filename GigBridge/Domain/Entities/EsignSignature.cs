using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsignSignature
{
    public Guid ESigEsignSignaturesId { get; set; }

    public Guid EDocEsignDocumentsId { get; set; }

    public Guid UsrUserId { get; set; }

    /// <summary>
    /// Enum ESignerRole: 0=Client, 1=Freelancer
    /// </summary>
    public int SignerRole { get; set; }

    public string SignatureImageUrl { get; set; } = null!;

    public int? SignatureWidth { get; set; }

    public int? SignatureHeight { get; set; }

    /// <summary>
    /// Enum ESignSignatureStatus: 0=Pending, 1=Signed, 2=Declined
    /// </summary>
    public int Status { get; set; }

    public DateTime? SignedAt { get; set; }

    public DateTime? DeclinedAt { get; set; }

    public string? DeclineReason { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual EsignDocument EDocEsignDocuments { get; set; } = null!;

    public virtual User UsrUser { get; set; } = null!;
}
