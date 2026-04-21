using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WorkExperience
{
    public Guid WeWorkExperiencesId { get; set; }

    public Guid FlFreelancerId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }

    public bool? IsCurrentJob { get; set; }

    public virtual FreelancerProfile FlFreelancer { get; set; } = null!;
}
