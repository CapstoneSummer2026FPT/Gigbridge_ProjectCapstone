using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Conversation
{
    public Guid ConvConversationsId { get; set; }

    public Guid UsrUser1Id { get; set; }

    public Guid UsrUser2Id { get; set; }

    public Guid? ContContractsId { get; set; }

    /// <summary>
    /// Enum ConversationType: 0=DirectMessage, 1=ContractChat
    /// </summary>
    public int? Type { get; set; }

    public DateTime? LastMessageAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract? ContContracts { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual User UsrUser1 { get; set; } = null!;

    public virtual User UsrUser2 { get; set; } = null!;
}
