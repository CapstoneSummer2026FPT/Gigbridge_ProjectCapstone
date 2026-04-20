using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RefreshToken
{
    public Guid RtId { get; set; }

    public Guid UsrUserId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime ExpiresAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? RevokedAt { get; set; }

    public virtual User UsrUser { get; set; } = null!;
}
