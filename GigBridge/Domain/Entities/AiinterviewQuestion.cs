using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AiinterviewQuestion
{
    public Guid AiinterviewQuestionsId { get; set; }

    public Guid AiinterviewSessionsId { get; set; }

    public string Question { get; set; } = null!;

    public string? Answer { get; set; }

    public decimal? Score { get; set; }

    public string? Aianalysis { get; set; }

    public int? SortOrder { get; set; }

    public DateTime? AnsweredAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual AiinterviewSession AiinterviewSessions { get; set; } = null!;
}
