using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisputeMessage
{
    public Guid DispMsgDisputeMessagesId { get; set; }

    public Guid DispDisputesId { get; set; }

    public Guid UsrSenderId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual Dispute DispDisputes { get; set; } = null!;

    public virtual User UsrSender { get; set; } = null!;
}
