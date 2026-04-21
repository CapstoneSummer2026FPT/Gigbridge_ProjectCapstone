using Application.Common.Interfaces;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly GigbridgeDbContext _context;

    public UnitOfWork(GigbridgeDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
