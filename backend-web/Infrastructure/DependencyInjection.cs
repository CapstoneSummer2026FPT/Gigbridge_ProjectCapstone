using Application.Common.Interfaces;
using Application.Common.Interfaces.Services;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Infrastructure.Services.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayOS;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Persistence
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Identity
        services.AddScoped<IIdentityService, IdentityService>();

        // Application Services Shells
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IGoogleAuthService, GoogleAuthService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IMediaService, MediaService>();
        services.AddScoped<INotificationService, NotificationService>();

        // PayOS Configuration
        services.AddKeyedSingleton("OrderClient", (sp, key) =>
        {
            return new PayOSClient(new PayOSOptions
            {
                ClientId = configuration["PayOS:ClientId"] ?? string.Empty,
                ApiKey = configuration["PayOS:ApiKey"] ?? string.Empty,
                ChecksumKey = configuration["PayOS:ChecksumKey"] ?? string.Empty
            });
        });

        return services;
    }
}
