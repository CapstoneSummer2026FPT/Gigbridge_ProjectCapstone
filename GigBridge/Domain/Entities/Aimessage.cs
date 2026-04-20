using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Aimessage
{
    public Guid AiMsgAimessagesId { get; set; }

    public Guid AiSessAiconversationSessionsId { get; set; }

    public string Role { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int? TokensUsed { get; set; }

    public int? SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual AiconversationSession AiSessAiconversationSessions { get; set; } = null!;
}
