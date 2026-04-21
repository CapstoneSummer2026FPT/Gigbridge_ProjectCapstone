using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FreelancerSkill
{
    public Guid FreelancerSkillsId { get; set; }

    public Guid FreelancerId { get; set; }

    public Guid SkillsId { get; set; }

    public int? YearsOfExperience { get; set; }

    /// <summary>
    /// Enum ProficiencyLevel: 0=Beginner, 1=Intermediate, 2=Advanced, 3=Expert
    /// </summary>
    public int? ProficiencyLevel { get; set; }

    public virtual FreelancerProfile Freelancer { get; set; } = null!;

    public virtual Skill Skills { get; set; } = null!;
}
