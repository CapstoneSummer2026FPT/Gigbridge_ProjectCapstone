using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Subscription
{
    public Guid SubSubscriptionsId { get; set; }

    public Guid UsrUserId { get; set; }

    public Guid SubPlanSubscriptionPlansId { get; set; }

    /// <summary>
    /// Enum SubscriptionStatus: 0=Active, 1=Expired, 2=Cancelled
    /// </summary>
    public int Status { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool? AutoRenew { get; set; }

    public string? PaymentReference { get; set; }

    public DateTime? CancelledAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual SubscriptionPlan SubPlanSubscriptionPlans { get; set; } = null!;

    public virtual User UsrUser { get; set; } = null!;
}
