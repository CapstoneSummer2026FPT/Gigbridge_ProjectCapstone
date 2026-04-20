using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SavedFreelancer
{
    public Guid SavedFreelancersId { get; set; }

    public Guid UserId { get; set; }

    public Guid FreelancerProfilesId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual FreelancerProfile FreelancerProfiles { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
