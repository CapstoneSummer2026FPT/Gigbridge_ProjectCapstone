using Application.Common.Interfaces.Services;

namespace Infrastructure.Services.Implementation;

public class AuthService : IAuthService
{
    // Implementation placeholder
}

public class GoogleAuthService : IGoogleAuthService
{
    // Implementation placeholder
}

public class EmailService : IEmailService
{
    public Task SendEmailAsync(string to, string subject, string body)
    {
        // Implementation placeholder
        return Task.CompletedTask;
    }
}

public class MediaService : IMediaService
{
    public Task<string> UploadImageAsync(Stream fileStream, string fileName)
    {
        // Implementation placeholder
        return Task.FromResult(string.Empty);
    }

    public Task DeleteImageAsync(string publicId)
    {
        // Implementation placeholder
        return Task.CompletedTask;
    }
}

public class NotificationService : INotificationService
{
    public Task SendNotificationAsync(Guid userId, string message)
    {
        // Implementation placeholder
        return Task.CompletedTask;
    }
}
