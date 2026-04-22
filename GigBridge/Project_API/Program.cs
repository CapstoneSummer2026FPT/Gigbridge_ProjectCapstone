using Application;
using Infrastructure;
using Infrastructure.Persistence;
using Project_API.Extensions;
using Project_API.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ApiExceptionFilterAttribute>();
});

// Layer registrations (Clean Architecture)
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

// API-layer concerns
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddSwaggerWithBearerAuth();
builder.Services.AddCorsPolicy();

var app = builder.Build();

// Enable Swagger in all environments for testing
app.UseSwagger();
app.UseSwaggerUI();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var db = scope.ServiceProvider.GetRequiredService<GigbridgeDbContext>();
        DbSeeder.Seed(db);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Seed failed: {ex.Message}");
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("AllowAll"); // CORS must be BEFORE MapControllers

app.UseAuthentication();
app.UseAuthorization();

app.MapHealthChecks("/health");
app.MapControllers();

app.Run();
