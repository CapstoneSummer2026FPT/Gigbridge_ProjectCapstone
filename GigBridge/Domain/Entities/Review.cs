using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Review
{
    public Guid RevReviewsId { get; set; }

    public Guid ContContractsId { get; set; }

    public Guid UsrReviewerId { get; set; }

    public Guid UsrRevieweeId { get; set; }

    public int Rating { get; set; }

    public string? Comment { get; set; }

    public int? CommunicationRating { get; set; }

    public int? QualityRating { get; set; }

    public int? TimelinessRating { get; set; }

    public bool? IsVisible { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract ContContracts { get; set; } = null!;

    public virtual User UsrReviewee { get; set; } = null!;

    public virtual User UsrReviewer { get; set; } = null!;
}
