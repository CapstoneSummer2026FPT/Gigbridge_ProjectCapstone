using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JobPostSkill
{
    public Guid JobPostSkillsId { get; set; }

    public Guid JobPostsId { get; set; }

    public Guid SkillsId { get; set; }

    public bool? IsRequired { get; set; }

    public virtual JobPost JobPosts { get; set; } = null!;

    public virtual Skill Skills { get; set; } = null!;
}
