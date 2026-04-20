using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contract
{
    public Guid ContContractsId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public Guid ClProClientProfilesId { get; set; }

    public Guid FlProFreelancerProfilesId { get; set; }

    public Guid? PropoProposalsId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal TotalBudget { get; set; }

    /// <summary>
    /// Enum PaymentType: 0=Fixed, 1=Hourly
    /// </summary>
    public int PaymentType { get; set; }

    /// <summary>
    /// Enum ContractStatus: 0=Active, 1=Completed, 2=Cancelled, 3=Disputed
    /// </summary>
    public int Status { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// v1.2: URL bản hợp đồng lao động e-sign PDF khi có tranh chấp thanh toán
    /// </summary>
    public string? EsignContractPdfUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AiconversationSession> AiconversationSessions { get; set; } = new List<AiconversationSession>();

    public virtual ClientProfile ClProClientProfiles { get; set; } = null!;

    public virtual ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();

    public virtual ICollection<Dispute> Disputes { get; set; } = new List<Dispute>();

    public virtual EsignDocument? EsignDocument { get; set; }

    public virtual FreelancerProfile FlProFreelancerProfiles { get; set; } = null!;

    public virtual JobPost JpJobPosts { get; set; } = null!;

    public virtual ICollection<Milestone> Milestones { get; set; } = new List<Milestone>();

    public virtual Proposal? PropoProposals { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
