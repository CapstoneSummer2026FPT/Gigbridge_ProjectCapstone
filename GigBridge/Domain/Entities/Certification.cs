using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Certification
{
    public Guid CertificationsId { get; set; }

    public Guid FreelancerId { get; set; }

    public string Name { get; set; } = null!;

    public string? IssuingOrganization { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string? CredentialUrl { get; set; }

    public virtual FreelancerProfile Freelancer { get; set; } = null!;
}
