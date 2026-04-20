using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Aimessage
{
    public Guid AimessagesId { get; set; }

    public Guid AiconversationSessionsId { get; set; }

    public string Role { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int? TokensUsed { get; set; }

    public int? SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual AiconversationSession AiconversationSessions { get; set; } = null!;
}
