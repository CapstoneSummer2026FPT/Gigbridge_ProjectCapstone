using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PortfolioItem
{
    public Guid PortfolioItemsId { get; set; }

    public Guid FreelancerId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? ProjectUrl { get; set; }

    public string? ImageUrls { get; set; }

    public Guid? CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Category? Category { get; set; }

    public virtual FreelancerProfile Freelancer { get; set; } = null!;
}
