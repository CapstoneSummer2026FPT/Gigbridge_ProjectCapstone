namespace Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    // Add repository properties here
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
