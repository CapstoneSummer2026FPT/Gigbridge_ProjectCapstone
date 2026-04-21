namespace Application.Common.Interfaces;

public interface IAuthService
{
    Task<string?> LoginAsync(string username, string password);
}

public interface IGoogleAuthService
{
}

public interface IEmailService
{
}

public interface IMediaService
{
}

public interface INotificationService
{
}
