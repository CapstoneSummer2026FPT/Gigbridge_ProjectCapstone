using Domain.Common;

namespace Domain.Entities;

public enum UserRole
{
    Client = 0,
    Freelancer = 1,
    Admin = 2
}

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public UserRole Role { get; set; } = UserRole.Freelancer;
    public bool IsEmailVerified { get; set; } = false;
    public bool IsActive { get; set; } = true;
    public string PreferredLanguage { get; set; } = "en";
    public DateTime? LastLoginAt { get; set; }
    public int AccessFailedCount { get; set; }
}
