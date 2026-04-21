using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AiinterviewSession
{
    public Guid AiinterviewSessionsId { get; set; }

    public Guid JobPostsId { get; set; }

    public Guid ClientProfilesId { get; set; }

    public Guid FreelancerProfilesId { get; set; }

    public Guid? ProposalsId { get; set; }

    /// <summary>
    /// Enum InterviewStatus: 0=Pending, 1=InProgress, 2=Completed, 3=Cancelled
    /// </summary>
    public int Status { get; set; }

    public decimal? OverallScore { get; set; }

    public string? Aifeedback { get; set; }

    public DateTime? StartedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AiinterviewQuestion> AiinterviewQuestions { get; set; } = new List<AiinterviewQuestion>();

    public virtual ClientProfile ClientProfiles { get; set; } = null!;

    public virtual FreelancerProfile FreelancerProfiles { get; set; } = null!;

    public virtual JobPost JobPosts { get; set; } = null!;

    public virtual Proposal? Proposals { get; set; }
}
