using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MilestoneAttachment
{
    public Guid MStoneAttachMilestoneAttachmentsId { get; set; }

    public Guid MStoneMilestonesId { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public Guid? UploadedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Milestone MStoneMilestones { get; set; } = null!;

    public virtual User? UploadedByUser { get; set; }
}
