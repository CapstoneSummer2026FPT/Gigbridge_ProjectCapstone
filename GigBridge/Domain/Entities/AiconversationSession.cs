using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AiconversationSession
{
    public Guid AiSessAiconversationSessionsId { get; set; }

    public Guid UsrUserId { get; set; }

    /// <summary>
    /// Enum AISessionType: 0=WorkAssistant, 1=ProfileOptimizer, 2=JobPostGenerator, 3=ProposalGenerator
    /// </summary>
    public int Type { get; set; }

    public string? Title { get; set; }

    public Guid? ContContractsId { get; set; }

    public Guid? JpJobPostsId { get; set; }

    public string? ModelUsed { get; set; }

    public int? TotalTokensUsed { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Aimessage> Aimessages { get; set; } = new List<Aimessage>();

    public virtual Contract? ContContracts { get; set; }

    public virtual JobPost? JpJobPosts { get; set; }

    public virtual User UsrUser { get; set; } = null!;
}
