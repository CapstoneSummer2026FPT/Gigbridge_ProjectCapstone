using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AiconversationSession
{
    public Guid AiconversationSessionsId { get; set; }

    public Guid UserId { get; set; }

    /// <summary>
    /// Enum AISessionType: 0=WorkAssistant, 1=ProfileOptimizer, 2=JobPostGenerator, 3=ProposalGenerator
    /// </summary>
    public int Type { get; set; }

    public string? Title { get; set; }

    public Guid? ContractsId { get; set; }

    public Guid? JobPostsId { get; set; }

    public string? ModelUsed { get; set; }

    public int? TotalTokensUsed { get; set; }

    public bool? IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Aimessage> Aimessages { get; set; } = new List<Aimessage>();

    public virtual Contract? Contracts { get; set; }

    public virtual JobPost? JobPosts { get; set; }

    public virtual User User { get; set; } = null!;
}
