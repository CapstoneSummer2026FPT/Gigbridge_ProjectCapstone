using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SavedJob
{
    public Guid SjSavedJobsId { get; set; }

    public Guid UsrUserId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual JobPost JpJobPosts { get; set; } = null!;

    public virtual User UsrUser { get; set; } = null!;
}
