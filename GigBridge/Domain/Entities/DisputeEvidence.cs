using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisputeEvidence
{
    public Guid DisputeEvidenceId { get; set; }

    public Guid DisputesId { get; set; }

    public Guid UploadedById { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Dispute Disputes { get; set; } = null!;

    public virtual User UploadedBy { get; set; } = null!;
}
