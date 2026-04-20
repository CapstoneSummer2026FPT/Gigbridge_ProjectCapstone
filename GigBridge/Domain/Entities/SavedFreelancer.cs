using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SavedFreelancer
{
    public Guid SfSavedFreelancersId { get; set; }

    public Guid UsrUserId { get; set; }

    public Guid FlProFreelancerProfilesId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual FreelancerProfile FlProFreelancerProfiles { get; set; } = null!;

    public virtual User UsrUser { get; set; } = null!;
}
