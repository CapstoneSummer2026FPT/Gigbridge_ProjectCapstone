using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AiinterviewSession
{
    public Guid AiIntvAiinterviewSessionsId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public Guid ClProClientProfilesId { get; set; }

    public Guid FlProFreelancerProfilesId { get; set; }

    public Guid? PropoProposalsId { get; set; }

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

    public virtual ClientProfile ClProClientProfiles { get; set; } = null!;

    public virtual FreelancerProfile FlProFreelancerProfiles { get; set; } = null!;

    public virtual JobPost JpJobPosts { get; set; } = null!;

    public virtual Proposal? PropoProposals { get; set; }
}
