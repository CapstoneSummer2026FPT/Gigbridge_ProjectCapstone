using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MessageAttachment
{
    public Guid MessageAttachmentsId { get; set; }

    public Guid MessagesId { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public string? ContentType { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Message Messages { get; set; } = null!;
}
