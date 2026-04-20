using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Education
{
    public Guid EEducationsId { get; set; }

    public Guid FlFreelancerId { get; set; }

    public string Institution { get; set; } = null!;

    public string? Degree { get; set; }

    public string? FieldOfStudy { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Description { get; set; }

    public virtual FreelancerProfile FlFreelancer { get; set; } = null!;
}
