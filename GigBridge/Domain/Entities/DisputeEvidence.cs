using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisputeEvidence
{
    public Guid DispEvDisputeEvidenceId { get; set; }

    public Guid DispDisputesId { get; set; }

    public Guid UsrUploadedById { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Dispute DispDisputes { get; set; } = null!;

    public virtual User UsrUploadedBy { get; set; } = null!;
}
