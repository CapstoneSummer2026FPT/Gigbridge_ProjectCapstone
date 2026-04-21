using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DisputeMessage
{
    public Guid DisputeMessagesId { get; set; }

    public Guid DisputesId { get; set; }

    public Guid SenderId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual Dispute Disputes { get; set; } = null!;

    public virtual User Sender { get; set; } = null!;
}
