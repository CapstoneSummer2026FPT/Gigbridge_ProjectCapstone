using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Proposal
{
    public Guid PropoProposalsId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public Guid FlProFreelancerProfilesId { get; set; }

    public string? CoverLetter { get; set; }

    public decimal? ProposedRate { get; set; }

    public string? ProposedDuration { get; set; }

    /// <summary>
    /// Enum ProposalStatus: 0=Pending, 1=Shortlisted, 2=Accepted, 3=Rejected, 4=Withdrawn
    /// </summary>
    public int Status { get; set; }

    public DateTime? SubmittedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsAigenerated { get; set; }

    public virtual ICollection<AiinterviewSession> AiinterviewSessions { get; set; } = new List<AiinterviewSession>();

    public virtual Contract? Contract { get; set; }

    public virtual FreelancerProfile FlProFreelancerProfiles { get; set; } = null!;

    public virtual JobPost JpJobPosts { get; set; } = null!;

    public virtual ICollection<ProposalAttachment> ProposalAttachments { get; set; } = new List<ProposalAttachment>();
}
