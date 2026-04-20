using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Report
{
    public Guid RptReportsId { get; set; }

    public Guid UsrReporterId { get; set; }

    public Guid ReportedEntityId { get; set; }

    public string ReportedEntityType { get; set; } = null!;

    /// <summary>
    /// Enum ReportType: 0=Spam, 1=Fraud, 2=InappropriateContent, 3=HarassmentOrAbuse, 4=Other, 5=PaymentDispute
    /// </summary>
    public int Type { get; set; }

    public string Reason { get; set; } = null!;

    /// <summary>
    /// Enum ReportStatus: 0=Pending, 1=Reviewing, 2=Resolved, 3=Dismissed
    /// </summary>
    public int Status { get; set; }

    public string? AdminNote { get; set; }

    public Guid? ResolvedByAdminId { get; set; }

    public DateTime? ResolvedAt { get; set; }

    /// <summary>
    /// v1.2: Admin đính kèm bản hợp đồng lao động e-sign PDF cho tranh chấp thanh toán
    /// </summary>
    public string? AdminAttachmentUrl { get; set; }

    public string? AdminAttachmentFileName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User? ResolvedByAdmin { get; set; }

    public virtual User UsrReporter { get; set; } = null!;
}
