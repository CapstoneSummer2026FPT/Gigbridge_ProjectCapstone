using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AdminAuditLog
{
    public Guid AalAdminAuditLogsId { get; set; }

    public Guid UsrAdminId { get; set; }

    public string Action { get; set; } = null!;

    public Guid? EntityId { get; set; }

    public string? EntityType { get; set; }

    public string? OldValues { get; set; }

    public string? NewValues { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User UsrAdmin { get; set; } = null!;
}
