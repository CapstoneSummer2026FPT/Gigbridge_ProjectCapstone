using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Persistence;

public static class DbSeeder
{
    public static void Seed(ApplicationDbContext context)
    {
        // Add seeding logic here
        // Example:
        // if (!context.Users.Any()) { ... }
        
        context.SaveChanges();
    }
}
