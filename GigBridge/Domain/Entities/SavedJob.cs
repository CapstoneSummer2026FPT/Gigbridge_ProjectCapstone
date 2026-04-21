using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SavedJob
{
    public Guid SavedJobsId { get; set; }

    public Guid UserId { get; set; }

    public Guid JobPostsId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual JobPost JobPosts { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
