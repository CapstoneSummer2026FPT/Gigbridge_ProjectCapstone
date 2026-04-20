using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<User> Users { get; }
    // Add other repositories here as entities are added
    
    Task<int> CompleteAsync();
}
