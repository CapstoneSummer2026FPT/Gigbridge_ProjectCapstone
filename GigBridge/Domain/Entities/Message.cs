using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Message
{
    public Guid MsgMessagesId { get; set; }

    public Guid ConvConversationsId { get; set; }

    public Guid UsrSenderId { get; set; }

    public string? Content { get; set; }

    /// <summary>
    /// Enum MessageType: 0=Text, 1=File, 2=System
    /// </summary>
    public int? Type { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsEdited { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Conversation ConvConversations { get; set; } = null!;

    public virtual ICollection<MessageAttachment> MessageAttachments { get; set; } = new List<MessageAttachment>();

    public virtual User UsrSender { get; set; } = null!;
}
