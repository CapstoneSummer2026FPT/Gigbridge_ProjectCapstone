using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProposalAttachment
{
    public Guid PropoAttachProposalAttachmentsId { get; set; }

    public Guid PropoProposalsId { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Proposal PropoProposals { get; set; } = null!;
}
