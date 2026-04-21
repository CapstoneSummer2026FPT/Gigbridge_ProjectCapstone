using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentProof
{
    public Guid PpPaymentProofsId { get; set; }

    public Guid MStoneMilestonesId { get; set; }

    public Guid UsrUploadedById { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// Enum PaymentProofStatus: 0=Pending, 1=Confirmed, 2=Disputed
    /// </summary>
    public int Status { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public DateTime? DisputedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Milestone MStoneMilestones { get; set; } = null!;

    public virtual User UsrUploadedBy { get; set; } = null!;
}
