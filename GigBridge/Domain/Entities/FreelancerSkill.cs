using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FreelancerSkill
{
    public Guid FSkillFreelancerSkillsId { get; set; }

    public Guid FlFreelancerId { get; set; }

    public Guid SkSkillsId { get; set; }

    public int? YearsOfExperience { get; set; }

    /// <summary>
    /// Enum ProficiencyLevel: 0=Beginner, 1=Intermediate, 2=Advanced, 3=Expert
    /// </summary>
    public int? ProficiencyLevel { get; set; }

    public virtual FreelancerProfile FlFreelancer { get; set; } = null!;

    public virtual Skill SkSkills { get; set; } = null!;
}
