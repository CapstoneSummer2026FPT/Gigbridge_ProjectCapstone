using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Conversation
{
    public Guid ConversationsId { get; set; }

    public Guid User1Id { get; set; }

    public Guid User2Id { get; set; }

    public Guid? ContractsId { get; set; }

    /// <summary>
    /// Enum ConversationType: 0=DirectMessage, 1=ContractChat
    /// </summary>
    public int? Type { get; set; }

    public DateTime? LastMessageAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract? Contracts { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual User User1 { get; set; } = null!;

    public virtual User User2 { get; set; } = null!;
}
