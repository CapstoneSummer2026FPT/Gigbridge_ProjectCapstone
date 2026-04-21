using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProposalAttachment
{
    public Guid ProposalAttachmentsId { get; set; }

    public Guid ProposalsId { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Proposal Proposals { get; set; } = null!;
}
