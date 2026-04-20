namespace Application.Common.Interfaces.Services;

public interface IAuthService
{
    // Placeholder for authentication logic
}

public interface IGoogleAuthService
{
    // Placeholder for Google OAuth logic
}

public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, string body);
}

public interface IMediaService
{
    Task<string> UploadImageAsync(Stream fileStream, string fileName);
    Task DeleteImageAsync(string publicId);
}

public interface INotificationService
{
    Task SendNotificationAsync(Guid userId, string message);
}
