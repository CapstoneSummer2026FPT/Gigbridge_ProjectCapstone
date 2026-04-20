using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PlatformSetting
{
    public Guid PlatformSettingsId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Description { get; set; }

    public string? DataType { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedByAdminId { get; set; }

    public virtual User? UpdatedByAdmin { get; set; }
}
