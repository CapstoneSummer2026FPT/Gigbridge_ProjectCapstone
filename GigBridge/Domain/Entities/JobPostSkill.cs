using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JobPostSkill
{
    public Guid JpSkillJobPostSkillsId { get; set; }

    public Guid JpJobPostsId { get; set; }

    public Guid SkSkillsId { get; set; }

    public bool? IsRequired { get; set; }

    public virtual JobPost JpJobPosts { get; set; } = null!;

    public virtual Skill SkSkills { get; set; } = null!;
}
