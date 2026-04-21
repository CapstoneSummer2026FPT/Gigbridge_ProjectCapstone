using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JobPostAttachment
{
    public Guid JpAttachJobPostAttachmentsId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public string FileName { get; set; } = null!;

    public string FileUrl { get; set; } = null!;

    public long? FileSize { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual JobPost JpJobPosts { get; set; } = null!;
}
